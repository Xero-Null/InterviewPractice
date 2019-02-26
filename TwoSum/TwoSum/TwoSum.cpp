
#include "TwoSum.h"

int* TwoSum::TwoSumFromBruteForce(int *nums, int target)
{
	for (int i = 0; i < sizeof(nums) - 1; i++) // start at index 0 and go until it reaches the (endIndex - 1)
	{
		for (int j = (i + 1); j < sizeof(nums); j++) // start at the index (i + 1) and iterate until the endIndex
		{
			if ((nums[i] + nums[j]) == target) // If num[i] + num[j] == target, return this set
				return new int[2]{ nums[i], nums[j] };
		}
	}

	// Return -1, -1 because the target was not found
	return new int[2]{ -1, -1 };
}

int* TwoSum::TwoSumFromHash(int *nums, int target)
{
	unordered_map<int, int> map; // Create new hashmap
	map.insert(make_pair(nums[0], nums[0])); // Insert the first index of the array

	unordered_map<int, int>::iterator it; // Create the iterator to store, search for, and collect data
	for (int i = 1; i < sizeof(nums); i++)// Start at the second index of the array
	{
		// Check to see if we find a match with the current iteration and map
		it = map.find(target - nums[i]); // Search for acceptable key/value
		if (it != map.end()) // if the iterator is not at the end, it found a match
			return new int[2]{ nums[i], it->second }; // Return match
		else // No match, insert index into hashmap
			map.insert(make_pair(nums[i], nums[i]));
	}

	// Return -1, -1 because the target was not found
	return new int[2]{ -1, -1 };
}