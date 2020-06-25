
#pragma once

#ifndef _DOT_WRITTER_HPP_
#define _DOT_WRITTER_HPP_

#include <stdio.h>
#include <iostream>

#include "TreeDataTypes.hpp"

// Converter to GraphViz Dot format
class DotWritter final
{
public:
	bool Write(TreeNode* inTree, const char* inFileName);

private:
	void WriteRootDot(TreeNode* tree, FILE* stream);

	void WriteDot(TreeNode* node, FILE* stream);

private:
	int mNumberOfNodes;
	int mNumberOfResultLeafs;
};

#endif //_DOT_WRITTER_HPP_