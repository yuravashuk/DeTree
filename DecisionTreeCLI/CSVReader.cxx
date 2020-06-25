
#include "CSVReader.hpp"

CSVReader::CSVReader(std::string inFileName, char inDelimiter) :
	mFileName(inFileName), mDelimiter(inDelimiter)
{ }

CSVReader::TDataTable CSVReader::ReadDataTable()
{
    TDataTable data;
    std::ifstream inputFile(mFileName);
    int l = 0;

    while (inputFile)
    {
        l++;
        std::string s;

        if (!getline(inputFile, s))
        {
            break;
        }

        if (s[0] != '#')
        {
            std::istringstream ss(s);
            std::vector<int> record;

            while (ss)
            {
                std::string line;

                if (!getline(ss, line, mDelimiter))
                {
                    break;
                }

                try
                {
                    record.push_back(stoi(line));
                }
                catch (const std::invalid_argument e)
                {
                    std::cout << "error while load csv file - " << mFileName << "  " << e.what() << "\n";
                }
            }

            data.push_back(record);
        }
    }

    if (!inputFile.eof())
    {
        std::cerr << "Could not read file " << mFileName << "\n";
    }

    inputFile.close();

    return data;
}