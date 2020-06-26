
#include "Tree.hpp"

bool DeTree::BuildTree(const DataTable& inTable)
{
    mReportStream.clear();

    DataUtils::DumpTable(inTable, mReportStream, "Inital Data Table");

    mRootNode = new TreeNode();

    CalculateRecursivly(inTable, mRootNode, 10);
    CleanupLeafs(mRootNode);
    std::cout << "Done Calculations!\n";

    if (mDotWritter.Write(mRootNode, "output.dot"))
    {
        // convert to PNG
        std::cout << "Convert to PNG.\n";

#ifdef _WIN32
        const auto command = Constants::kDotPath + " " + Constants::kConvertCommand + "output.png";
        std::system(command.c_str());
#else
        const auto command = Constants::kConvertCommand + inFileName;
        std::system(command.c_str());
#endif
        return true;
    }

    // clear memory
    DeleteRecursivly(mRootNode);
    mRootNode = nullptr;

    return false;
}

std::string DeTree::GetReport()
{
    return mReportStream.str();
}

void DeTree::SaveGraphImage(const std::string& inFileName, const DataTable& inTable)
{
    BuildTree(inTable);

#ifdef _WIN32
    const auto command = Constants::kDotPath + " " + Constants::kConvertCommand + "output.png";
    std::system(command.c_str());
#else
    const auto command = Constants::kConvertCommand + inFileName;
    std::system(command.c_str());
#endif
}

void DeTree::SaveGraphReport(const std::string& inFileName, const DataTable& inTable)
{
    BuildTree(inTable);

    FILE* handle = fopen(inFileName.c_str(), "w");
    if (handle != NULL)
    {
        fwrite(mReportStream.str().c_str(), mReportStream.str().length(), 1, handle);
        fclose(handle);
    }
}

void DeTree::DeleteRecursivly(TreeNode* inNode)
{
    if (inNode)
    {
        const auto left = inNode->Left;
        const auto right = inNode->Right;

        delete inNode;

        if (left)
        {
            DeleteRecursivly(left);
        }

        if (right)
        {
            DeleteRecursivly(right);
        }
    }
}

std::vector< size_t > DeTree::GetAllOfType(const TDataType& inType, const TSign& inSign)
{
    std::vector< size_t > result;

    for (size_t i = 0; i < inSign.size(); i++)
    {
        if (inSign[i] == inType)
        {
            result.push_back(i);
        }
    }

    return result;
}

std::vector< size_t > DeTree::GetFromFunctionAllOfType(const TDataType& inType, const TFunction& inFunction, const std::vector<size_t>& inSignIndices)
{
    std::vector<size_t> result;

    for (size_t i = 0; i < inSignIndices.size(); i++)
    {
        const auto index = inSignIndices[i];

        if (inFunction[index] == inType)
        {
            result.push_back(inFunction[index]);
        }
    }

    return result;
}

DataTable DeTree::GenerateNextTableBasedOn(const DataTable& inTable, TDataType inType)
{
    const auto numSigns = inTable.Signs.size() - 1;
    const TSign prevSign = inTable.Signs[0];

    // get previous Sign values
    TSigns signs(numSigns);

    // get signs at same indices as prev sign
    for (size_t i = 0; i < prevSign.size(); i++)
    {
        if (prevSign[i] == inType)
        {
            for (size_t j = 0; j < numSigns; j++)
            {
                const auto oldIndex = j + 1;
                const auto valueAtSameIndex = inTable.Signs[oldIndex][i];
                signs[j].push_back(valueAtSameIndex);
            }
        }
    }

    // get function values at same indices as prev sign
    TFunction function;

    for (size_t i = 0; i < prevSign.size(); i++)
    {
        if (prevSign[i] == inType)
        {
            function.push_back(inTable.Function[i]);
        }
    }

    return DataTable(signs, function);
}

bool DeTree::IsValidSigns(const DataTable& inTable, TreeNode* inNode)
{
    if (inTable.Signs.empty())
    {
        return false;
    }

    if (inTable.Signs.size() == 1)
    {
        if (inTable.Signs[0].size() > 1)
        {
            if (inTable.Signs[0][1] == g_PositiveType)
            {
                inNode->SetKey(g_PositiveType);
            }
            else
            {
                inNode->SetKey(g_NegativeType);
            }
        }
        else
        {
            if (inTable.Signs[0][0] == g_NegativeType)
            {
                inNode->SetKey(g_NegativeType);
            }
            else
            {
                inNode->SetKey(g_PositiveType);
            }
        }

        return false;
    }

    return true;
}

void DeTree::CalculateRecursivly(const DataTable& inTable, TreeNode* inNode, int inKeyIncrement)
{
    if (!IsValidSigns(inTable, inNode))
    {
        return;
    }

    int counter = 1;

    for (const auto sign : inTable.Signs)
    {
        const auto positive = GetAllOfType(g_PositiveType, sign);
        const auto negative = GetAllOfType(g_NegativeType, sign);
        const auto positiveFunction = GetFromFunctionAllOfType(g_PositiveType, inTable.Function, positive);
        const auto negativeFunction = GetFromFunctionAllOfType(g_NegativeType, inTable.Function, negative);

        const auto numSigns = TCastType(sign.size());
        const auto numPositiveSigns = TCastType(positive.size());
        const auto numNegativeSigns = TCastType(negative.size());
        const auto numPositiveFx = TCastType(positiveFunction.size());
        const auto numNegativeFx = TCastType(negativeFunction.size());

        const TCastType positive_WP = numPositiveSigns / numSigns * numPositiveFx / numPositiveSigns;
        const TCastType negative_WP = numNegativeSigns / numSigns * numNegativeFx / numNegativeSigns;
        const TCastType WP = positive_WP + negative_WP;

        inNode->WPs.push_back(WP);

        mReportStream << "W(P" << counter << ") = " << numPositiveSigns << "/" << numSigns << " * " << numPositiveFx << "/" << numPositiveSigns << " + ";
        mReportStream << numNegativeSigns << "/" << numSigns << " * " << numNegativeFx << "/" << numNegativeSigns << " = " << WP << "\n";

        counter++;
    }

    std::cout << "Generating Left Table (Negative)\n";
    const DataTable leftTable = GenerateNextTableBasedOn(inTable, g_NegativeType);
    DataUtils::DumpTable(leftTable, mReportStream, "\nLeft Signs");

    std::cout << "Generating Right Table (Positive)\n";
    const DataTable rightTable = GenerateNextTableBasedOn(inTable, g_PositiveType);
    DataUtils::DumpTable(rightTable, mReportStream, "\nRight Signs");

    inNode->Left = new TreeNode();
    inNode->Right = new TreeNode();

   // inNode->InfoTable = inTable;
    inNode->Left->Parent = inNode;
    inNode->Right->Parent = inNode;
    inNode->SetKey(inKeyIncrement);

    const auto newKey0 = inNode->Key + 10;
    const auto newKey1 = inNode->Key + 20;
    CalculateRecursivly(leftTable, inNode->Left, newKey0);
    CalculateRecursivly(rightTable, inNode->Right, newKey1);
}

void DeTree::CleanupLeafs(TreeNode* inNode)
{
    if (inNode)
    {
        if (inNode->Left && inNode->Right)
        {
            CleanupLeafs(inNode->Left);
            CleanupLeafs(inNode->Right);
        }
        else
        {
            if (inNode->Parent->Left->Key == g_NegativeType &&
                inNode->Parent->Right->Key == g_NegativeType)
            {
                inNode->Parent->Key = inNode->Parent->Left->Key;
                inNode->Parent->Left = nullptr;
                inNode->Parent->Right = nullptr;
            }
            else if (inNode->Parent->Left->Key == g_PositiveType &&
                inNode->Parent->Right->Key == g_PositiveType)
            {
                inNode->Parent->Key = inNode->Parent->Left->Key;
                inNode->Parent->Left = nullptr;
                inNode->Parent->Right = nullptr;
            }
        }
    }
}
