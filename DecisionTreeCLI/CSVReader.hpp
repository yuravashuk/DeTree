
#pragma once

#ifndef _CSV_READER_HPP_
#define _CSV_READER_HPP_

#include <string>
#include <vector>
#include <fstream>
#include <sstream>
#include <iostream>

class CSVReader final
{
public:
    using TDataTable = std::vector<std::vector<int>>;

    CSVReader(std::string inFileName, char inDelimiter = ',');

    TDataTable ReadDataTable();

private:
    std::string mFileName;
    char mDelimiter;
};

#endif //_CSV_READER_HPP_