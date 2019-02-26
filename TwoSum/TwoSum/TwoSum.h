#pragma once

#include <unordered_map> 

using namespace std;

class TwoSum
{
	/// <summary>This method will use the brute force method of linear iterating through with a double for loop. It has a time complexity of O(n^2), because it must iterate through the array twice.</summary>
	public: static int* TwoSumFromBruteForce(int *nums, int target);

	/// <summary>This method will use the hashmap method for selecting a key and value for faster results. It has a time complexity of O(n), because it only has to iterate through the array once.</summary>
	public: static int* TwoSumFromHash(int *nums, int target);
};