#include "KMP_algorithm.h"
#include <string.h>
#include <fstream>

int algorithmOfKMP(char s[], char q[]) // Knuth-Morris-Pratt algorithm
{
	int i = 0;
	int j = -1;
	int N = strlen(s);
	int M = strlen(q);
	int *d = (int*)malloc(M*sizeof(int));
	d[0] = -1;
	while (i<M - 1)
	{
		while ((j >= 0) && (q[j] != q[i]))
		{
			j = d[j];
		}
		i++;
		j++;
		if (q[i] == q[j])
		{
			d[i] = d[j];
		}
		else
		{
			d[i] = j;
		}
	}
	for (i = 0, j = 0; (i < N) && (j < M); i++, j++)
	{
		while ((j >= 0) && (q[j] != s[i]))
		{
			j = d[j];
		}
	}
	free(d);
	if (j == M)
	{
		return i - j + 1;
	}
	else
	{
		return -1;
	}
}
