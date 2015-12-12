#include <iostream>
using namespace std;

int x;
int xsqrt;

int main()
{
	cout << "Write x: ";
	cin >> x;
	xsqrt = x*x;
	cout << ((xsqrt + 1)*(xsqrt + x) + 1);
}
