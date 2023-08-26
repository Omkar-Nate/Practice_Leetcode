//// DSA_Striver.cpp : This file contains the 'main' function. Program execution begins and ends there.
////
//
//#include <iostream>
//using namespace std;
//
//int main()
//{
//	//STRIVER A2Z: PATTERNS
//	
//	#pragma region Patterns
//
//	// 22. Inward reducing number square
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber*2 - 1; i++)
//	{
//		for (size_t j = 0; j < inputNumber*2-1; j++)
//		{
//			int top = i;
//			int left = j;
//			int right = (2 * inputNumber - 2) - j;
//			int bottom = (2 * inputNumber - 2) - i;
//			cout << (inputNumber - min(min(top, bottom), min(left, right)));
//		}
//		cout << "\n";
//	}*/
//
//	// 21. Square border
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j < inputNumber; j++)
//		{
//			if (i == 0 || i == inputNumber - 1 || j == 0 || j == inputNumber - 1)
//			{
//				cout << "*";
//			}
//			else 
//			{
//				cout << " ";
//			}
//		}
//		cout << "\n";
//
//	}*/
//
//	// 20. Blank space diamond reversed
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber - 1; i++)
//	{
//		for (size_t j = 0; j < inputNumber * 2; j++)
//		{
//			if (j <= i || j >= (inputNumber * 2) - i - 1)
//			{
//				cout << "*";
//			}
//			else
//			{
//				cout << " ";
//			}
//		}
//		cout << "\n";
//	}
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j < inputNumber * 2; j++)
//		{
//			if (j >= inputNumber - i && j < inputNumber + i && i!=inputNumber)
//			{
//				cout << " ";
//			}
//			else
//			{
//				cout << "*";
//			}
//		}
//		cout << "\n";
//	}*/
//
//	// 19. Blank space diamond
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j < inputNumber * 2; j++)
//		{
//			if (j >= inputNumber - i && j < inputNumber + i && i!=inputNumber) 
//			{
//				cout << " ";
//			}
//			else
//			{
//				cout << "*";
//			}
//		}
//		cout << "\n";
//	}
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j < inputNumber * 2; j++)
//		{
//			if (j <= i || j >= (inputNumber * 2) - i - 1)
//			{
//				cout << "*";
//			}
//			else
//			{
//				cout << " ";
//			}
//		}
//		cout << "\n";
//	}*/
//
//	// 18. Reverse Alphabet right angled triangle
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = inputNumber + 64 - i; j <= inputNumber + 64; j++) 
//		{
//			cout << (char)j;
//		}
//		cout << "\n";
//	}*/
//
//	// 17. Alphabet equilateral triangle
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	inputNumber += 65;
//	for (size_t i = 65; i < inputNumber; i++)
//	{
//		for (size_t j = 65; j < inputNumber; j++)
//		{
//			if (j < (inputNumber - 1) - i + 65)
//			{
//				cout << " ";
//			}
//			else
//			{
//				cout << (char)(inputNumber - j + 64);
//			}
//		}
//		for (size_t j = 66; j <= i; j++)
//		{
//			cout << (char)(j);
//		}
//		cout << "\n";
//	}*/
//
//	// 16. Alphabets Trianlge; Same character row 
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 65; i < inputNumber + 65; i++)
//	{
//		for (size_t j = 65; j <= i; j++)
//		{
//			cout << (char)i;
//		}
//		cout << "\n";
//	}*/
//
//	// 15. Ulta Alphabets Triangle
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 65; i < inputNumber + 65; i++)
//	{
//		int alpha = 65;
//		for (size_t j = (inputNumber + 65) - i; j > 0; j--)
//		{
//			cout << (char)alpha++;
//		}
//		cout << "\n";
//	}*/
//
//	// 14. Alphabets triangle
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 65; i < inputNumber + 65; i++)
//	{
//		for (size_t j = 65; j <= i; j++)
//		{
//			cout << (char)j;
//		}
//		cout << "\n";
//	}*/
//
//	// 13. Continued number triangle
//	/*int inputNumber, count=0;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 1; i <= inputNumber; i++)
//	{
//		for (size_t j = 1; j <= i; j++)
//		{
//			cout << ++count << " ";
//		}
//		cout << "\n";
//	}*/
//
//	// 12. Ulta triablge blank space Number Pattern 
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j < inputNumber*2; j++)
//		{
//			if (j < i+1)
//			{
//				cout << j + 1;
//			}
//			else if (j >= ((inputNumber*2 - i) - 1) )
//			{
//				cout << (inputNumber * 2 - j);
//			}
//			else 
//			{
//				cout << " ";
//			}
//		}
//		cout << "\n";
//	}*/
//
//	// 11. Bit right angled triangle
//	/*int inputNumber;
//	bool bit = false;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		if (i % 2 == 0) 
//		{
//			bit = true;
//		}
//		else
//		{
//			bit = false;
//		}
//		for (size_t j = 0; j < i+1; j++)
//		{
//			cout << bit;
//			bit = !bit;
//		}
//		cout << "\n";
//	}*/
//
//	// 10. Right angled triangle plus Ulta right angled triangle
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber*2; i++)
//	{
//		if (i < inputNumber) 
//		{
//			for (size_t j = 0; j < i + 1; j++)
//			{
//				cout << "*";
//			}
//		}
//		else
//		{
//			for (size_t j = inputNumber*2 - i -1; j > 0 ; j--)
//			{
//				cout << "*";
//			}
//		}
//		cout << "\n";
//	}*/
//
//	// 9. Diamond
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j < inputNumber; j++)
//		{
//			if (j < (inputNumber - 1) - i)
//			{
//				cout << " ";
//			}
//			else
//			{
//				cout << "*";
//			}
//		}
//		for (size_t j = 0; j < i; j++)
//		{
//			cout << "*";
//		}
//		cout << "\n";
//	}
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j < inputNumber; j++)
//		{
//			if (j >= j - i)
//			{
//				cout << "*";
//			}
//			else
//			{
//				cout << " ";
//			}
//		}
//		for (size_t k = (inputNumber - 1) - i; k > 0; k--)
//		{
//			cout << "*";
//		}
//		cout << "\n";
//	}*/
//
//	// 8. Number Triangle
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j < inputNumber; j++)
//		{
//			if (j < (inputNumber - 1) - i) 
//			{
//				cout << " ";
//			}
//			else
//			{
//				cout << "*";
//			}
//		}
//		for (size_t j = 0; j < i; j++)
//		{
//			cout << "*";
//		}
//		cout << "\n";
//	}*/
//
//	// 7. Ulta Star triangle
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j < inputNumber; j++)
//		{
//			if (j >= j - i)
//			{
//				cout << "*";
//			}
//			else
//			{
//				cout << " ";
//			}
//		}
//		for (size_t k = (inputNumber - 1) - i; k > 0; k--)
//		{
//			cout << "*";
//		}
//		cout << "\n";
//	}*/
//
//	// 6. Ulta number Right angled Triangle
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = inputNumber; j > j - i - 1; j--)
//		{
//			cout << inputNumber - (j - 1);
//		}
//		cout << "\n";
//	}*/
//
//	// 5. Ulta * triangle pattern
//	/*int inputNumber;
//	cout << "Enter Number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = inputNumber; j > j-i-1; j--)
//		{
//			cout << "*";
//		}
//		cout << "\n";
//	}*/
//
//	// 4. Number pattern
//	/*int inputNumber;
//	cout << "Enter number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j < i+1; j++)
//		{
//			cout << i + 1;
//		}
//		cout << "\n";
//	}*/
//
//	// 3. Numbers right angled triangle
//	/*int inputNumber;
//	cout << "Enter number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j < i+1; j++)
//		{
//			cout << j + 1;
//		}
//		cout << "\n";
//	}*/
//
//	// 2. Star right angled triangle
//	/*int inputNumber;
//	cout << "Enter number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j <= i; j++)
//		{
//			cout << "*";
//		}
//		cout << "\n";
//	}*/
//
//	// 1. Star square pattern
//	/*int inputNumber;
//	cout << "Enter number" << endl;
//	cin >> inputNumber;
//	for (size_t i = 0; i < inputNumber; i++)
//	{
//		for (size_t j = 0; j < inputNumber; j++)
//		{
//			cout << "*";
//		}
//		cout << "\n";
//	}*/
//	
//	#pragma endregion
//
//	//STRIVER A2Z: WHILE LOOP
//	/*int numberForTable;
//	cout << "Enter number for it's table" << endl;
//	cin >> numberForTable;
//	int multiplier = 10;
//	while (multiplier != 0) 
//	{
//		cout << numberForTable * (multiplier--) << endl;
//	}*/
//
//	//STRIVER A2Z: SWITCH CASE
//	/*int choice;
//	cout << "Input Choice" << endl;
//	cin >> choice;
//	switch (choice)
//	{
//		case 1:
//			cout << "Calculating Area of the circle" << endl;
//			break;
//		case 2:
//			cout << "Calculating Area of the rectangle" << endl;
//			break;
//		default:
//			break;
//	}*/
//
//	//STRIVER A2Z: IF ELSE
//	/*int m, n;
//	cout << "Enter n.\n";
//	cin >> n;
//	cout << "Enter m.\n";
//	cin >> m;
//
//	if (n<m)
//	{
//		cout << "lesser" << endl;
//	}
//	else if (n > m)
//	{
//		cout << "greater" << endl;
//	}else
//	{
//		cout << "equal" << endl;
//	}*/
//	//cout << "Hello World!\n";
//}
//
//// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
//// Debug program: F5 or Debug > Start Debugging menu
//
//// Tips for Getting Started: 
////   1. Use the Solution Explorer window to add/manage files
////   2. Use the Team Explorer window to connect to source control
////   3. Use the Output window to see build output and other messages
////   4. Use the Error List window to view errors
////   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
////   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
