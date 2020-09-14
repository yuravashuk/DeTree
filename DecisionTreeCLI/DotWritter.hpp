
#pragma once

#ifndef _DOT_WRITTER_HPP_
#define _DOT_WRITTER_HPP_

#include <stdio.h>
#include <iostream>
#include <sstream>

#include "TreeDataTypes.hpp"

struct PathIndexer
{
	TreeNode* node = nullptr;
	int index = 0;
};

// Converter to GraphViz Dot format
class DotWritter final
{
public:
	bool Write(TreeNode* inTree, const char* inFileName);

	bool WriteDecompositionModel(const char* inFileName);

private:
	void WriteRootDot(TreeNode* tree, FILE* stream);

	void WriteDot(TreeNode* node, FILE* stream);

	void CalculateStats(TreeNode* node);

	void CalculateDecompositionModel(TreeNode* node);

	void CalculateDecompositionModelRecursive(TreeNode* node, PathIndexer paths[], int pathLen);

private:
	std::stringstream mDecompositionModel;
	int mNumberOfNodes;
	int mNumberOfResultLeafs;
};

#endif //_DOT_WRITTER_HPP_