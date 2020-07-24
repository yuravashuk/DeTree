
#pragma once

#ifndef _SHAF_CLF_HPP_
#define _SHAF_CLF_HPP_

#include "TreeDataTypes.hpp"
/*
class ShafClf final
{
public:
    ShafClf(const TSigns &inSigns, const TFunction &inFunction, int inTypeOfDistanceInSpace)
        : mSigns(inSigns)
        , mFunction(inFunction)
        , mTypeOfDistanceInSpace(inTypeOfDistanceInSpace)
    { }

	void Calculate()
	{
        int sum = 0;

        for (size_t k = 0; k < mSigns.size(); k++)
        {
            const auto d0 = mFunction[k];
            const auto d1 = mSigns[0][k];

            for (size_t i = 0; i < mSigns.size(); i++)
            {
                if (mTypeOfDistanceInSpace == 1)
                    sum += (d1 - d0) * (d1 - d0);

                if (mTypeOfDistanceInSpace == 2)
                    sum += abs(d1 - d0);

                if (mTypeOfDistanceInSpace == 3)
                {
                    if (abs(d1 - d0) > sum)
                        sum = abs(d1 - d0);
                }
            }

            if (mTypeOfDistanceInSpace == 1)
                sum = sqrt(sum);
        }
	}
private:
    TSigns mSigns;
    TFunction mFunction;
    int mTypeOfDistanceInSpace;
};
*/
#endif //_SHAF_CLF_HPP_