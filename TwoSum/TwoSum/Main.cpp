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

	/* LeetCode
		Results:	Runtime: 12 ms, faster than 97.81% of C++ online submissions for Two Sum.
					Memory Usage: 10.3 MB, less than 45.81% of C++ online submissions for Two Sum.
					Note: Memory usage is determined by how many iterations store map data... It's random.
	*/
	vector<int> nums_Test4 = { 230,863,916,585,981,404,316,785,88,12,70,435,384,778,887,755,740,337,86,92,325,422,815,650,920,125,277,336,221,847,168,23,677,61,400,136,874,363,394,199,863,997,794,587,124,321,212,957,764,173,314,422,927,783,930,282,306,506,44,926,691,568,68,730,933,737,531,180,414,751,28,546,60,371,493,370,527,387,43,541,13,457,328,227,652,365,430,803,59,858,538,427,583,368,375,173,809,896,370,789 };
	vector<int> res_TestH4 = TwoSum::TwoSum_LeetCode(nums_Test4, 542);
	if (res_TestH4[0] >= 0)
		cout << "LeetCode: " << res_TestH4[0] << " + " << res_TestH4[1] << " = 542" << endl;
	else
		cout << "LeetCode: Unable to find a match to equal 542" << endl;


	cin.ignore();
}