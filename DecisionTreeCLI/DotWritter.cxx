
#include "DotWritter.hpp"

bool DotWritter::Write(TreeNode* inTree, const char* inFileName)
{
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