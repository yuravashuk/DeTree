
#pragma once

#ifndef _TREE_HPP_
#define _TREE_HPP_

#include <vector>
#include <iostream>
#include <string>
#include <sstream>
#include <algorithm>
#include <stdio.h>

#ifdef WIN32
#include <windows.h>
#endif //WIN32

#include "TreeDataTypes.hpp"
#include "DotWritter.hpp"

// Constants

namespace Constants
{
#ifdef _WIN32
    static const std::string kDotPath = "\"C:\\Program Files (x86)\\Graphviz2.38\\bin\\dot.exe\"";
    static const std::string kConvertCommand = "-Tpng output.dot > ";
#else
    static const std::string kConvertCommand = "dot -Tpng output.dot > ";
#endif
}

class DeTree final
{
    std::stringstream mReportStream;
    DotWritter mDotWritter;
    TreeNode* mRootNode = nullptr;
    
public:

    bool BuildTree(const DataTable& inTable);

    void SaveGraphImage(const std::string& inFileName, const DataTable& inTable);

    void SaveGraphReport(const std::string& inFileName, const DataTable& inTable);

    std::string GetReport();

private:
    // Memory

    void DeleteRecursivly(TreeNode* inNode);

    // Calculation Functions

    std::vector< size_t > GetAllOfType(const TDataType& inType, const TSign& inSign);

    std::vector< size_t > GetFromFunctionAllOfType(const TDataType& inType, const TFunction& inFunction, const std::vector<size_t>& inSignIndices);

    DataTable GenerateNextTableBasedOn(const DataTable& inTable, TDataType inType);

    bool IsValidSigns(const DataTable& inTable, TreeNode* inNode);

    void CalculateRecursivly(const DataTable& inTable, TreeNode* inNode, int inKeyIncrement);

    // Other

    void CleanupLeafs(TreeNode* inNode);
};

#endif //_TREE_HPP_