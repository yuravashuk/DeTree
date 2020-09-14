
#include "DotWritter.hpp"

bool DotWritter::Write(TreeNode* inTree, const char* inFileName)
{
    if (inTree)
    {
        mDecompositionModel.clear();

        CalculateStats(inTree);
        CalculateDecompositionModel(inTree);
    }

    FILE* handler = fopen("output.dot", "w");

    if (handler)
    {
        WriteRootDot(inTree, handler);
        std::cout << "Dot written!\n";
        fclose(handler);
        return true;
    }

    return false;
}

bool DotWritter::WriteDecompositionModel(const char* inFileName)
{
    FILE* handle = fopen(inFileName, "w");

    if (handle == NULL)
    {
        std::cerr << "Failed to write to file - " << inFileName << "\n";
        return false;
    }

    fwrite(mDecompositionModel.str().c_str(), mDecompositionModel.str().length(), 1, handle);
    fclose(handle);

    return true;
}

void DotWritter::CalculateStats(TreeNode* node)
{
    if (node->Left && node->Right)
    {
        mNumberOfNodes++;

        CalculateStats(node->Left);
        CalculateStats(node->Right);
    }
    else
    {
        mNumberOfResultLeafs++;
    }
}

void DotWritter::CalculateDecompositionModel(TreeNode* node)
{
    PathIndexer path[1000];
    CalculateDecompositionModelRecursive(node, path, 0);
}

void DotWritter::CalculateDecompositionModelRecursive(TreeNode* node, PathIndexer paths[], int pathLen)
{
    if (node == NULL)
    {
        return;
    }

    static bool isRight = false;
    static int ruleIndex = 1;

    /* append this node to the path array */
    paths[pathLen].index = pathLen;
    paths[pathLen].node = node;
    pathLen++;

    /* it's a leaf, so print the path that led to here */
    if (node->Left == NULL && node->Right == NULL)
    {
        int index = 0;

        mDecompositionModel << ruleIndex << ") ";

        // dump main path
        for (int i = 0; i < pathLen - 1; i++)
        {
            index = paths[i].index + 1;
            int lastDirection = 0;

            if (paths[i].node->Parent != nullptr)
            {
                if (paths[i].node->Parent->Left == paths[i].node)
                {
                    lastDirection = 1;
                }
            }
            else
            {
                lastDirection = (isRight ? 0 : 1);
            }
            
            mDecompositionModel << "P" << index << ":" << lastDirection << ";";
        }

        // get last direction
        int lastDirection = 0;

        if (node->Parent != nullptr)
        {
            if (node->Parent->Left == node)
            {
                lastDirection = 1;
            }
        }
        
        index = paths[pathLen - 1].index + 1;
        mDecompositionModel << "P" << index << ":" << lastDirection;
        mDecompositionModel << " --> H";

        if (node->Key == g_NegativeType)
        {
            mDecompositionModel << std::to_string(node->Key) << ";";
        }
        else if (node->Key == g_PositiveType)
        {
            mDecompositionModel << std::to_string(node->Key) << ";";
        }

        mDecompositionModel << "\n\r";

        isRight = !isRight;
        ruleIndex++;
    }
    else
    {
        /* otherwise try both subtrees */
        CalculateDecompositionModelRecursive(node->Left, paths, pathLen);
        CalculateDecompositionModelRecursive(node->Right, paths, pathLen);
    }
}

void DotWritter::WriteDot(TreeNode* node, FILE* stream)
{
    static int nullcount = 0;
    static int leafCounter = 0;

    if (node->Left != nullptr)
    {
        if (node->Left->Key == g_NegativeType || node->Left->Key == g_PositiveType)
        {
            fprintf(stream, "    %s -> %d.%d;\n", node->Name.c_str(), node->Left->Key, leafCounter);
            fprintf(stream, "    %d.%d [label=\"%d\"];", node->Left->Key, leafCounter, node->Left->Key);
            leafCounter++;
        }
        else
        {
            fprintf(stream, "    %s -> %s;\n", node->Name.c_str(), node->Left->Name.c_str());
        }

        WriteDot(node->Left, stream);
    }

    if (node->Right != nullptr)
    {
        if (node->Right->Key == g_NegativeType || node->Right->Key == g_PositiveType)
        {
            fprintf(stream, "    %s -> %d.%d;\n", node->Name.c_str(), node->Right->Key, leafCounter);
            fprintf(stream, "    %d.%d [label=\"%d\"];", node->Right->Key, leafCounter, node->Right->Key);
            leafCounter++;
        }
        else
        {
            fprintf(stream, "    %s -> %s;\n", node->Name.c_str(), node->Right->Name.c_str());
        }

        WriteDot(node->Right, stream);
    }
}

void DotWritter::WriteRootDot(TreeNode* tree, FILE* stream)
{
    // shape=box, fontcolor=White, style=filled, fillcolor=green
    fprintf(stream, "digraph BST {\n");
    fprintf(stream, "    node [fontname=\"Arial\"];\n");

    if (!tree)
        fprintf(stream, "\n");
    else if (!tree->Right && !tree->Left)
        fprintf(stream, "    %d;\n", tree->Key);
    else
        WriteDot(tree, stream);

    fprintf(stream, "}\n");
}