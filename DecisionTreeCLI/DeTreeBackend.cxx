
#include <stdio.h>

#include "Tree.hpp"
#include "InputParser.hpp"
#include "CSVReader.hpp"
#include "SharClf.hpp"

void DumpDataTable(const CSVReader::TDataTable& inData)
{
    for (auto l : inData)
    {
        for (auto x : l)
        {
            std::cout << x << " ";
        }

        std::cout << "\n";
    }

    std::cout << "\n";
}

void ConvertDataTable(const std::string &inFileName, TSigns &outSigns, TFunction &outFunction)
{
    CSVReader reader(inFileName);
    auto data = reader.ReadDataTable();
    DumpDataTable(data);

    for (size_t i = 1; i < data.size(); i++)
    {
        outFunction.push_back(data[i][0]);
    }

    int j = 0;
    for (size_t k = 1; k < data[1].size(); k++)
    {
        TSign sign;

        for (size_t i = 1; i < data.size(); i++)
        {
            sign.push_back(data[i][k]);
        }

        outSigns.push_back(sign);
    }
}

std::tuple< bool, std::string > GetValidFileName(const InputParser& inParser)
{
    if (inParser.ArgumentExists("-f"))
    {
        const std::string filename = inParser.GetArgument("-f");
        if (!filename.empty())
        {
            return { true, filename };
        }
    }

    return { false, "" };
}

int GetValidAlgorithm(const InputParser& inParser)
{
    const std::string& algorithm = inParser.GetArgument("-e");
    if (!algorithm.empty())
    {
        return std::stoi(algorithm);
    }

    return 0;
}

int main(int argc, char ** argv)
{
    InputParser input(argc, argv);
    DeTree tree;
     
    // cleanup old files
    remove("output.png");
    remove("report.txt");

    if (input.ArgumentExists("-h"))
    {
        std::cout << "-f <filename> - path to CSV file, first column must be a Function, other must be a Signs.\n";
        std::cout << "-e <number> - use experimental algorithm.\n";
    }

    // use experimental algorithms
    if (input.ArgumentExists("-e"))
    {
        const auto [hasFile, filename] = GetValidFileName(input);

        if (hasFile)
        {
            int algorithmNum = GetValidAlgorithm(input);

            if (algorithmNum == 1)
            {
                TSigns signs;
                TFunction function;

                ConvertDataTable(filename, signs, function);
                ShafClf shaf(signs, function, 1);
                shaf.Calculate();
            }
        }
    }
    else
    {
        const std::string& filename = input.GetArgument("-f");

        if (!filename.empty())
        {
            CSVReader reader(filename);
            auto data = reader.ReadDataTable();
            DumpDataTable(data);

            TSigns signs;
            TFunction function;

            for (size_t i = 1; i < data.size(); i++)
            {
                function.push_back(data[i][0]);
            }

            int j = 0;
            for (size_t k = 1; k < data[1].size(); k++)
            {
                TSign sign;

                for (size_t i = 1; i < data.size(); i++)
                {
                    sign.push_back(data[i][k]);
                }

                signs.push_back(sign);
            }

            DataTable dataTable(signs, function);
            //tree.BuildTree(dataTable);
            tree.SaveGraphReport("report.txt", dataTable);
            tree.SaveGraphImage("output.png", dataTable);
        }
    }

    return 0;
}
