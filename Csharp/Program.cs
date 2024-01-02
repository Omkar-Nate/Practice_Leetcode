using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Replace the function calls to test the function.
            // Do checkout the required arguments for them.
            // Function calls that return a value should be added in a console.writeline
            // Functions that return a collection should be iterated using loops

            int[] arr = new int[] { 10, 6, 5, 1, 9, 10, 8, 2, 2, 2 };

            //arr = Shuffle(arr, arr.Length/2);

            //foreach(int number in arr)
            //{
            //    Console.WriteLine(number);
            //}
            IList<IList<int>> temp = FindMatrix(arr);

            foreach (IList<int> item in temp)
            {
                Console.Write("[");
                foreach (int item1 in item)
                {
                    Console.Write(" "+item1);
                }
                Console.Write("]");

            }
            Console.WriteLine();
        }

        #region Leetcode

        #region 2610. Convert an Array Into a 2D Array With Conditions

        public static IList<IList<int>> FindMatrix(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();

            Dictionary<int, int> numsFreq = new Dictionary<int, int>();

            for(int i = 0; i<nums.Length; i++)
            {
                if (numsFreq.ContainsKey(nums[i]))
                {
                    numsFreq[nums[i]]++;
                }
                else
                {
                    numsFreq.Add(nums[i], 1);
                }
            }
            int maxValue = numsFreq.Values.Max();
            for(int i = 0; i < maxValue; i++)
            {
                List<int> newList = new List<int>();
                foreach(int x in numsFreq.Keys)
                {
                    if (numsFreq[x]>i)
                    {
                        newList.Add(x);
                    }
                }
                result.Add(newList);
            }

            GC.Collect();
            return result;
        }

        #endregion

        #region 2114. Maximum Number of Words Found in Sentences

        /// <summary>
        /// Finds sentence having most words
        /// </summary>
        /// <param name="sentences"></param>
        /// <returns></returns>
        public static int MostWordsFound(string[] sentences)
        {
            int result = 0, max = 0;

            for (int i = 0; i < sentences.Length; i++)
            {
                string[] sentence = sentences[i].Split(' ');
                max = Math.Max(max, sentence.Length);
            }

            GC.Collect();
            return result;
        }

        #endregion

        #region 1365. How Many Numbers Are Smaller Than the Current Number

        /// <summary>
        /// Returns an array of integer. Each integer tells how many numbers 
        /// in the array are smaller than it
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            List<int> numsCopy = new List<int>(nums);
            numsCopy.Sort();
            int[] result = new int[nums.Length];
            for (int i = 0; i < numsCopy.Count; i++)
            {
                result[i] = numsCopy.IndexOf(nums[i]);
            }
            return result;
        }

        #endregion

        #region 2824. Count Pairs Whose Sum is Less than Target

        /// <summary>
        /// Count Pairs Whose Sum is Less than Target
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int CountPairs(IList<int> nums, int target)
        {
            int result = 0;
            for(int i=0; i<nums.Count; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if ((nums[i] + nums[j]) < target)
                    {
                        result++;
                    }
                }
            }
            GC.Collect();
            return result;
        }
        #endregion

        #region 1431. Kids With the Greatest Number of Candies

        /// <summary>
        /// Finds which kids will have the greates number of candies if given some extra candies
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="extraCandies"></param>
        /// <returns></returns>
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            bool[] result = new bool[candies.Length];

            for(int i=0; i<candies.Length;i++)
            {
                if ((candies[i]+extraCandies)>=max)
                {
                    result[i] = true;
                }
            }

            return result;
        }

        #endregion

        #region 2492. Find Words Containing Character

        /// <summary>
        /// Finds words containing a character
        /// </summary>
        /// <param name="words"></param>
        /// <param name="x"></param>
        /// <returns>list of indexes of words that contain character x</returns>
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x)) result.Add(i);
            }

            return result;
        }

        #endregion

        #region 1470. Shuffle the Array

        /// <summary>
        /// shuffles the array such that "i" and "i+n" are on adjacent indices
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] Shuffle(int[] nums, int n)
        {
            int[] shuffledArray = new int[2*n];
            for(int i=0; i < n; i++)
            {
                int index = i*2;
                shuffledArray[index] = nums[i];
                shuffledArray[index + 1] = nums[i + n];
            }
            return shuffledArray;
        }

        #endregion

        #region 1512 Number of Good Pairs

        /// <summary>
        /// Identifies the number of possible identical pairs in the given array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int NumIdenticalPairs(int[] nums)
        {
            if (nums.Length == 1) return 0;
            int goodPairs = 0;


            // Uses dictionary to count the frequency of a number in the array.
            // Uses arithmetic formula to calculate the number of good pairs (n*(n-1))/2

            Dictionary<int, int> identicalNumbers = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (identicalNumbers.ContainsKey(nums[i]))
                {
                    identicalNumbers[nums[i]]+=1;
                    Console.WriteLine(identicalNumbers[nums[i]]);
                }
                else
                {
                    identicalNumbers.Add(nums[i], 1);
                }
            }

            foreach(KeyValuePair<int,int> number in identicalNumbers)
            {
                
                if (number.Value > 1)
                {
                    int freq = number.Value;
                    goodPairs += (freq * (freq - 1)) / 2;
                }
            }


            // Brute force approach. Uses O(n^2) Time complexity

            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            goodPairs++;
            //        }
            //    }
            //}

            return goodPairs;
        }

        #endregion


        #region Sliding Window Algorithm

        #region Max Consecutive Ones

        /// <summary>
        /// Finds the maximum occurence of consecutive 1s in an array of 1s and 0s
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            if (!nums.Contains(0))
            {
                return nums.Length;
            }

            int sum = 0;
            int maxOnes = 0;

            for (int i = 0 ; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    if (maxOnes < sum)
                    {
                        maxOnes = sum;
                    }
                    sum++;
                }
                else
                {
                    sum = 0;
                }
            }
            return maxOnes;
        }

        #endregion

        #endregion
        #endregion

        #region Sorting

        #region Bubble Sort Recursive

        /// <summary>
        ///  Sorts an integer array by comparing the adjacent element. 
        ///  Moves one element in each iteration
        ///  Uses recursion
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="lengthOfArr"></param>
        public static void BubbleSort(int[] arr, int lengthOfArr)
        {
            if (lengthOfArr<=1)
            {
                return;
            }

            for (int i = 0; i < lengthOfArr-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    arr[i] = arr[i]+arr[i + 1];
                    arr[i+1] = arr[i] - arr[i+1];
                    arr[i] = arr[i] - arr[i + 1];
                }
            }

            BubbleSort(arr, lengthOfArr-1);
        }

        #endregion

        #region Merge Sort

        // Support the merge sort method to merge the sorted sub arrays
        public static void merge(int[] arr, int l, int m, int r)
        {
            List<int> list = new List<int>(); // List that will store the left array and the right array
            int left = l; // Left index of the array to sort from
            int right = m+1; // Right index of the array to sort upto

            // Terminate when left or right index is exhausted
            // compare element on the left index and right index, add smaller one to the list
            while(left <= m && right <= r)
            {
                if (arr[left] <= arr[right])
                {
                    list.Add(arr[left++]);
                }
                else
                {
                    list.Add(arr[right++]);
                }
            }

            // Exhaust the non-exhausted indices
            while (left <= m)
            {
                list.Add(arr[left++]);
            }

            while (right <= r)
            {
                list.Add(arr[right++]);
            }

            // Add all the elements in their right position in the array
            // (i-l) calculates the position of the element in the sub array passed
            for (int i = l; i <= r; i++)
            {
                arr[i] = list[i - l];
            }
        }

        /// <summary>
        /// Sorts the array using merge sort
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        public static void MergeSort(int[] arr, int l, int r)
        {
            if (l >= r) return; // Base Case

            int m = (l + r) / 2; // Find the mid

            // Divide the Left half of the array; Array starts from "l -> m"
            // Will eventually call the "merge()" which will take care of merging this left array with right
            MergeSort(arr, l, m);

            // Divide the Right half of the array; Array starts from "m+1 -> r"
            // Will eventually call the "merge()" which will take care of merging this right array with left
            MergeSort(arr, m + 1, r);

            // Merge the left and the right array
            // Also sorts the array by comparing each element of both left and right array
            merge(arr, l, m, r);
        }

        #endregion


        #region Insertion Sort
        /// <summary>
        /// Shift integer to its right position
        /// </summary>
        /// <param name="arr"></param>
        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i <= arr.Length-1; i++)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    arr[j - 1] += arr[j];
                    arr[j] = arr[j - 1] - arr[j];
                    arr[j - 1] = arr[j - 1] - arr[j];
                    j--;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        #endregion

        #region Bubble Sort

        /// <summary>
        /// Sort the integer array using BubbleSort
        /// Uses two index. Comparison happens between alternate numbers
        /// Uses swapping without third number
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j-1] > arr[j])
                    {
                        arr[j-1] += arr[j];
                        arr[j] = arr[j - 1] - arr[j];
                        arr[j - 1] = arr[j - 1] - arr[j];
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        #endregion

        #region Selection Sort
        /// <summary>
        /// Sorts an integer array by selection sort algorithm
        /// uses two index to compare and then swap if number on 2nd index is greater
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        SwapNumbers(ref arr[i], ref arr[j]);
                    }
                }
            }

            return arr;
        }

        #endregion

        #region Swap numbers by reference
        /// <summary>
        /// Swaps value of references
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void SwapNumbers(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #endregion

        #region Frequency of the Most Frequent Element
        /// <summary>
        /// Find minimum and maximum frequency of numbers in an array
        /// </summary>
        /// <param name="nums"></param>
        public static void MaxFrequency(int[] nums)
        {
            Dictionary<int, int> numberFrequencies = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numberFrequencies.ContainsKey(nums[i]))
                {
                    numberFrequencies[nums[i]]++;
                } else
                {
                    numberFrequencies.Add(nums[i], 1);
                }
            }

            int maxValue = 0,minValue=nums.Length;
            int maxKey=0,minKey=0;


            foreach (var item in numberFrequencies)
            {
                if (maxValue < item.Value)
                {
                    maxValue = item.Value;
                    maxKey = item.Key;
                }
                if (minValue > item.Value)
                {
                    minValue = item.Value;
                    minKey = item.Key;
                }
            }

            Console.WriteLine( maxKey);
            Console.WriteLine( minKey);
        }
        #endregion

        #region Count frequency in Array
        /// <summary>
        /// Given an array of size 'n' has elements from '1' - 'x', 
        /// this functions counts frequency of all elements from '1' - 'n'
        /// </summary>
        /// <param name="n">lenght of array</param>
        /// <param name="x">range of numbers from 1 to x</param>
        /// <param name="nums">array as input</param>
        /// <returns></returns>
        public static int[] countFrequency(int n, int x, int[] nums)
        {
            int[] result = new int[n];

            int index = 0;
            for (int i = 1; i < n + 1; i++)
            {
                if (true) { };

                index = nums[i - 1];
                if(index - 1 >= n)
                {
                    continue;
                }
                result[index - 1] += 1;
            }


            return result;
        }
        #endregion

        #region Paranthesis Check
        /// <summary>
        /// Validates paranthesis is balanced
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static bool ParanthesisCheck(string inputString)
        {

            while (inputString.Contains("()") || inputString.Contains("{}") || inputString.Contains("[]"))
            {
                inputString = inputString.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }
            return inputString.Length == 0;
        }
        #endregion

        #region Recursion

        /// <summary>
        /// returns nth fibonacci number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int GetNthFibonacci(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            
            return GetNthFibonacci(number - 1) + GetNthFibonacci(number - 2);
        }

        /// <summary>
        /// Checks if the string is palindrome
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string s)
        {
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]");
            s = r.Replace(s, String.Empty);
            s = s.ToLower();
            if (s.Length <= 1)
                return true;

            return IsPalindrome(s, 0);
        }

        /// <summary>
        /// Overriden method of IsPalindrome(string) that is called after removing
        /// special characters, spaces and changing case to lower
        /// Checks if the string is palindrome
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        private static bool IsPalindrome(string inputString, int startIndex)
        {
            if(inputString.Length/2<=startIndex)
                return true;

            if (inputString[startIndex] != inputString[inputString.Length - 1 - startIndex])
                return false;

            return IsPalindrome(inputString, ++startIndex);
        }

        /// <summary>
        /// Reverses an array using recursion
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="startIndex"></param>
        /// <param name="lastIndex"></param>
        /// <returns></returns>
        static int[] PrintArrayInReverse(int[] arr, int startIndex = 0, int lastIndex = 0)
        {
            if (lastIndex == 0)
            {
                lastIndex = arr.Length - 1;
            }
            if (startIndex<lastIndex)
            {
                int temp;
                temp = arr[startIndex];
                arr[startIndex] = arr[lastIndex];
                arr[lastIndex] = temp;
                return PrintArrayInReverse(arr, ++startIndex, --lastIndex);
            }
            return arr;

        }

        /// <summary>
        /// Does factorial of a given number
        /// </summary>
        /// <param name="number"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        static int Factorial(int number, int count = 1)
        {
            if (number == count)
            {
                return count;
            }
            return Factorial(number, count + 1) * count;
        }

        /// <summary>
        /// Does sum of first N numbers
        /// </summary>
        /// <param name="number"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        static int SumOfFirstNNumbers(int number, int count = 1)
        {
            if (count == number)
            {
                return number;
            }
            return SumOfFirstNNumbers(number, count+1) + count;
        }

        /// <summary>
        /// Prints numbers upto a given number
        /// </summary>
        /// <param name="number"></param>
        /// <param name="count"></param>
        static void PrintNumbers(int number, int count=1)
        {
            if (count > number)
            {
                return;
            }
            Console.WriteLine(count);
            PrintNumbers(number, ++count);
        }

        /// <summary>
        /// Uses recursion for printing input string
        /// </summary>
        /// <param name="name"></param>
        /// <param name="count"></param>
        static void PrintName(string name, int count)
        {
            if (count==0)
            {
                return;
            }
            Console.WriteLine(name);
            PrintName(name, --count);
        }

        #endregion

        #region Mathematical problems
        /// <summary>
        /// Checks if the given number is prime
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool CheckIfNumberIsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0 && i != number)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Prints divisors of a given number
        /// </summary>
        /// <param name="number"></param>
        static void GetAllDivisors(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
        }

        /// <summary>
        /// Checks if a number is armstrong or not.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool IsArmstrongNumber(int number)
        {
            int copyOfNumber = number;
            int copyOfNumber_2 = number;
            int count = 0;
            int sum = 0;
            while (copyOfNumber > 0)
            {
                count++;
                copyOfNumber /= 10;
            }

            while (copyOfNumber_2 > 0)
            {
                sum += (int)Math.Pow(copyOfNumber_2 % 10, count);
                copyOfNumber_2 /= 10;
            }

            // Well a bruteforce attempt. But hey, this works too

            //ArrayList digitsInNumber = new ArrayList();
            //ArrayList digitsInNumberAfterPower = new ArrayList();
            //int numberCopy = number;
            //while (numberCopy % 10 > 0)
            //{
            //    digitsInNumber.Add(numberCopy % 10);
            //    numberCopy = numberCopy / 10;
            //}

            //foreach (int item in digitsInNumber)
            //{
            //    int y = 1;
            //    for(int i=0; i<digitsInNumber.Count; i++)
            //    {
            //        y*=item;
            //    }
            //    digitsInNumberAfterPower.Add(y);
            //}

            //int sum = 0;
            //foreach (int item in digitsInNumberAfterPower)
            //{
            //    sum += item;
            //}

            return sum==number?true:false;
        }

        /// <summary>
        /// Gives the Greatest Common Divisor of two numbers
        /// </summary>
        /// <param name="number_1"></param>
        /// <param name="number_2"></param>
        /// <returns></returns>
        static int GetGreatestCommonDivisor(int number_1, int number_2)
        {
            
            int divisor = 2;
            int answer = 0;
            while(divisor<= Math.Min(number_1, number_2))
            {
                
                if(number_1 % divisor == 0 && number_2 % divisor == 0)
                {
                    answer = divisor;
                }
                divisor++;
            }
            return answer;
        }

        #endregion
    }
}