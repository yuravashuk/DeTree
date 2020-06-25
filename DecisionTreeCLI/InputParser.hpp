
#pragma once

#ifndef _INPUT_PARSER_HPP_
#define _INPUT_PARSER_HPP_

#include <vector>
#include <string>

class InputParser final
{
    std::vector <std::string> mTokens;

public:
    InputParser(int argc, char** argv)
    {
        for (int i = 1; i < argc; ++i)
        {
            this->mTokens.push_back(std::string(argv[i]));
        }
    }

    std::string GetArgument(const std::string& inOption) const
    {
        std::vector<std::string>::const_iterator itr;
        itr = std::find(mTokens.begin(), mTokens.end(), inOption);

        if (itr != mTokens.end() && ++itr != mTokens.end())
        {
            return *itr;
        }

        return "";
    }

    bool ArgumentExists(const std::string& option) const
    {
        return std::find(mTokens.begin(), mTokens.end(), option) != mTokens.end();
    }
};

#endif //_INPUT_PARSER_HPP_