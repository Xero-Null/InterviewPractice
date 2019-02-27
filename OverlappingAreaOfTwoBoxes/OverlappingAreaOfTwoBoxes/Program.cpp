#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

enum BoxPoint
{
	BottomLeftY,
	BottomLeftX,
	TopRightY,
	TopRightX
};

int CalculateAreaOfOverlappingBoxes(vector<int> box1, vector<int> box2)
{
	if (((box1[BoxPoint::BottomLeftX] < box2[BoxPoint::BottomLeftX]) && (box1[BoxPoint::TopRightX] < box2[BoxPoint::BottomLeftX])) ||
		((box1[BoxPoint::BottomLeftX] > box2[BoxPoint::BottomLeftX]) && (box1[BoxPoint::TopRightX] > box2[BoxPoint::BottomLeftX])))
		return 0; // Boxes don't overlap in the x axis

	if (((box1[BoxPoint::BottomLeftY] < box2[BoxPoint::BottomLeftY]) && (box1[BoxPoint::TopRightY] < box2[BoxPoint::BottomLeftY])) ||
		((box1[BoxPoint::BottomLeftY] > box2[BoxPoint::BottomLeftY]) && (box1[BoxPoint::TopRightY] > box2[BoxPoint::BottomLeftY])))
		return 0; // Boxes don't overlap in the y axis

	// Overlapping points
	int xPoint1, yPoint1, // Bottom Left
		xPoint2, yPoint2; // Top Right

	// Bottom Left Point
	xPoint1 = max(box1[BoxPoint::BottomLeftX], box2[BoxPoint::BottomLeftX]);
	yPoint1 = max(box1[BoxPoint::BottomLeftY], box2[BoxPoint::BottomLeftY]);

	// Top Right point
	xPoint2 = min(box1[BoxPoint::TopRightX], box2[BoxPoint::TopRightX]);
	yPoint2 = min(box1[BoxPoint::TopRightY], box2[BoxPoint::TopRightY]);

	cout << "Area points: [" << xPoint1 << ", " << yPoint1 << "], [" << xPoint2 << ", " << yPoint2 << "]" << endl;

	if (xPoint2 > xPoint1)
		return (abs(xPoint2 - xPoint1) * abs(yPoint2 - yPoint1));
	else
		return (abs(xPoint1 - xPoint2) * abs(yPoint1 - yPoint2));
}

int main()
{
	#pragma region Example 1 -- Box 1 { [1, 2], [5, 5] }, Box 2 { [2, 3], [7, 5] } = area of 6 units

	vector<int> box1, box2;

	box1.push_back(1); // Bottom Left
	box1.push_back(2);

	box1.push_back(5); // Top Right
	box1.push_back(5);

	box2.push_back(2); // Bottom Left
	box2.push_back(3);

	box2.push_back(7); // Top Right
	box2.push_back(5);

	cout << "Box 1 [" << box1[BoxPoint::BottomLeftY] << "," << box1[BoxPoint::BottomLeftX] << "], ";
	cout << "[" << box1[BoxPoint::TopRightY] << "," << box1[BoxPoint::TopRightX] << "]" << endl;

	cout << "Box 2 [" << box2[BoxPoint::BottomLeftY] << "," << box2[BoxPoint::BottomLeftX] << "], ";
	cout << "[" << box2[BoxPoint::TopRightY] << "," << box2[BoxPoint::TopRightX] << "]" << endl;

	int oArea = CalculateAreaOfOverlappingBoxes(box1, box2);
	if (oArea > 0)
	{
		cout << "The boxes had an overlapping area of " << oArea << " units." << endl; // This should be 6 units
	}
	else
	{
		cout << "The boxes did not overlap." << endl;
	}

	#pragma endregion

	cout << endl;

	#pragma region Example 2 -- Box 1 { [-2, -1], [2, 2] }, Box 2 { [-1, 0], [4, 2] } = area of 6 units

	vector<int> ex2_Box1, ex2_Box2;

	ex2_Box1.push_back(-2); // Bottom Left
	ex2_Box1.push_back(-1);

	ex2_Box1.push_back(2); // Top Right
	ex2_Box1.push_back(2);

	ex2_Box2.push_back(-1); // Bottom Left
	ex2_Box2.push_back(0);

	ex2_Box2.push_back(4); // Top Right
	ex2_Box2.push_back(2);

	cout << "Box 1 [" << ex2_Box1[BoxPoint::BottomLeftY] << "," << ex2_Box1[BoxPoint::BottomLeftX] << "], ";
	cout << "[" << ex2_Box1[BoxPoint::TopRightY] << "," << ex2_Box1[BoxPoint::TopRightX] << "]" << endl;

	cout << "Box 2 [" << ex2_Box2[BoxPoint::BottomLeftY] << "," << ex2_Box2[BoxPoint::BottomLeftX] << "], ";
	cout << "[" << ex2_Box2[BoxPoint::TopRightY] << "," << ex2_Box2[BoxPoint::TopRightX] << "]" << endl;

	int ex2_oArea = CalculateAreaOfOverlappingBoxes(ex2_Box1, ex2_Box2);
	if (ex2_oArea > 0)
	{
		cout << "The boxes had an overlapping area of " << ex2_oArea << " units." << endl; // This should be 6 units
	}
	else
	{
		cout << "The boxes did not overlap." << endl;
	}

	#pragma endregion

	cout << endl;

	#pragma region Example 3 -- Box 1 { [1, 2], [5, 5] }, Box 2 { [-8, 3], [-3, 5] } = area of 0 units (no overlapping)

	vector<int> ex3_Box1, ex3_Box2;

	ex3_Box1.push_back(1); // Bottom Left
	ex3_Box1.push_back(2);

	ex3_Box1.push_back(5); // Top Right
	ex3_Box1.push_back(5);

	ex3_Box2.push_back(-8); // Bottom Left
	ex3_Box2.push_back(3);

	ex3_Box2.push_back(-3); // Top Right
	ex3_Box2.push_back(5);

	cout << "Box 1 [" << ex3_Box1[BoxPoint::BottomLeftY] << "," << ex3_Box1[BoxPoint::BottomLeftX] << "], ";
	cout << "[" << ex3_Box1[BoxPoint::TopRightY] << "," << ex3_Box1[BoxPoint::TopRightX] << "]" << endl;

	cout << "Box 2 [" << ex3_Box2[BoxPoint::BottomLeftY] << "," << ex3_Box2[BoxPoint::BottomLeftX] << "], ";
	cout << "[" << ex3_Box2[BoxPoint::TopRightY] << "," << ex3_Box2[BoxPoint::TopRightX] << "]" << endl;

	int ex3_oArea = CalculateAreaOfOverlappingBoxes(ex3_Box1, ex3_Box2);
	if (ex3_oArea > 0)
	{
		cout << "The boxes had an overlapping area of " << ex3_oArea << " units." << endl; // This should be 6 units
	}
	else
	{
		cout << "The boxes did not overlap." << endl;
	}

	#pragma endregion

	cin.ignore();
}