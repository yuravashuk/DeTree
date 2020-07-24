
#pragma once

#ifndef _TREE_DATA_TYPES_HPP_
#define _TREE_DATA_TYPES_HPP_

#include <vector>
#include <string>
#include <sstream>

// Data types

using TDataType = int;
using TCastType = double;
using TSign = std::vector< TDataType >;
using TSigns = std::vector< TSign >;
using TFunction = TSign;

// Structures

struct DataTable
{
    TSigns Signs;
    TFunction Function;

    DataTable()
    {
        MakeDefault();
    }

    DataTable(const TSigns& inSigns, const TFunction& inFunction)
        : Signs(inSigns)
        , Function(inFunction)
    { }

    void MakeDefault()
    {
        Function = {
            0, 1, 1, 0, 1, 1
        };

        Signs = {
            { 0, 0, 1, 0, 1, 1 },
            { 0, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 1, 0, 1 }
        };
    }
};

struct TreeNode
{
    TreeNode* Parent = nullptr;
    TreeNode* Left = nullptr;
    TreeNode* Right = nullptr;

    std::string Name;
    int Key;
    DataTable InfoTable;
    std::vector<TCastType> WPs;

    TreeNode()
        : Parent(nullptr)
        , Left(nullptr)
        , Right(nullptr)
        , Key(0)
    { }

    void SetKey(int inKey)
    {
        Key = inKey;
        Name = std::string("P") + std::to_string(inKey / 10);
    }
};

// Globals
inline TDataType g_PositiveType = 1;
inline TDataType g_NegativeType = 0;

namespace DataUtils
{
    template<typename T>
    inline void DumpVector(const std::vector<T>& inVector, std::stringstream& inStream, const std::string& title = "")
    {
        inStream << title << " : ";

        for (const auto item : inVector)
        {
            inStream << item << ", ";
        }

        inStream << "\n";
    }

    inline TSigns Transpose(const TSigns& inData)
    {
        TSigns transposed(inData[0].size(), std::vector<int>());

        for (size_t i = 0; i < inData.size(); i++)
        {
            for (size_t j = 0; j < inData[i].size(); j++)
            {
                transposed[j].push_back(inData[i][j]);
            }
        }

        return transposed;
    }

    inline void DumpTable(const DataTable& inTable, std::stringstream& inStream, const std::string& inTitle = "")
    {
        inStream << inTitle << " :\n";

        DataTable newTable(Transpose(inTable.Signs), inTable.Function);

        for (size_t i = 0; i < newTable.Signs[0].size() + 1; i++)
        {
            inStream << "------";
        }
        inStream << "\n";

        for (size_t i = 0; i < newTable.Signs[0].size(); i++)
        {
            inStream << "  P(" << i + 1 << ")";
        }

        inStream << "  Fx\n";

        for (size_t i = 0; i < newTable.Signs[0].size() + 1; i++)
        {
            inStream << "------";
        }
        inStream << "\n";

        for (size_t i = 0; i < newTable.Signs.size(); i++)
        {
            inStream << " | ";

            for (size_t j = 0; j < newTable.Signs[i].size(); j++)
            {
                inStream << newTable.Signs[i][j] << "  |  ";
            }

            inStream << newTable.Function[i] << "  |\n";
        }

        for (size_t i = 0; i < newTable.Signs[0].size() + 1; i++)
        {
            inStream << "------";
        }
        inStream << "\n\n";
    }
}

#endif //_TREE_DATA_TYPES_HPP_