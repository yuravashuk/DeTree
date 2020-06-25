
#include <stdio.h>

#include "Tree.hpp"
#include "InputParser.hpp"
#include "CSVReader.hpp"

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
    }

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

    return 0;
}
