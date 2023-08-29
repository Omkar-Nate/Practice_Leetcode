using System.Collections;

namespace LeetCodePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Replace the function calls to test the function.
            // Do checkout the required arguments for them.
            Console.WriteLine(IsArmstrongNumber(143));
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
    }
}