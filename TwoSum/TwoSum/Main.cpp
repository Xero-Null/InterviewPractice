#include <iostream>

#include "TwoSum.h"

int main()
{
	int nums_Test1[4] = { 2, 7, 11, 15 };
	int *res_TestB1 = TwoSum::TwoSumFromBruteForce(nums_Test1, 22);
	if (res_TestB1[0] >= 0)
		cout << "From BF: " << res_TestB1[0] << " + " << res_TestB1[1] << " = 22" << endl;
	else
		cout << "From BF: Unable to find a match to equal 22" << endl;

	int *res_TestH1 = TwoSum::TwoSumFromHash(nums_Test1, 22);
	if (res_TestH1[0] >= 0)
		cout << "From Hash: " << res_TestH1[0] << " + " << res_TestH1[1] << " = 22" << endl;
	else
		cout << "From Hash: Unable to find a match to equal 22" << endl;


	int nums_Test2[4] = { 2, 7, 11, 15 };
	int *res_TestB2 = TwoSum::TwoSumFromBruteForce(nums_Test2, 45);
	if (res_TestB2[0] >= 0)
		cout << "From BF: " << res_TestB2[0] << " + " << res_TestB2[1] << " = 45" << endl;
	else
		cout << "From BF: Unable to find a match to equal 45" << endl;

	int *res_TestH2 = TwoSum::TwoSumFromHash(nums_Test2, 45);
	if (res_TestH2[0] >= 0)
		cout << "From Hash: " << res_TestH2[0] << " + " << res_TestH2[1] << " = 45" << endl;
	else
		cout << "From Hash: Unable to find a match to equal 45" << endl;

	int nums_Test3[4] = { 25, 7, 11, 20 };
	int *res_TestB3 = TwoSum::TwoSumFromBruteForce(nums_Test3, 45);
	if (res_TestB3[0] >= 0)
		cout << "From BF: " << res_TestB3[0] << " + " << res_TestB3[1] << " = 45" << endl;
	else
		cout << "From BF: Unable to find a match to equal 45" << endl;

	int *res_TestH3 = TwoSum::TwoSumFromHash(nums_Test3, 45);
	if (res_TestH3[0] >= 0)
		cout << "From Hash: " << res_TestH3[0] << " + " << res_TestH3[1] << " = 45" << endl;
	else
		cout << "From Hash: Unable to find a match to equal 45" << endl;

	cin.ignore();
}