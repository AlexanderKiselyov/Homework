#pragma once
#include "road.h"

bool isUsed(int n, int g, int k, int country[number][number])
{
	for (int i = 1; i <= k; i++)
	{
		for (int j = 1; j <= n; j++)
		{
			if (g == country[i][j])
			{
				return false;
			}
		}
	}
	return true;
}
