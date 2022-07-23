using System;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = Convert.ToInt32(Console.ReadLine());
           bool t = IsPalindrome(x);
            Console.WriteLine(t);
        }
        public static bool IsPalindrome(int x)
        {

            
            int n = x;
            int temp;
            int sum = 0;
            temp = x;
            if(temp < 0)
            {
                return false;
            } 
            if(temp == 10)
            {
                return true;
            }
            while (n > 0)
            {
                int r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
