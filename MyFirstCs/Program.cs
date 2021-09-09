using System;
using System.Collections.Generic;
namespace MyFirstCs
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            string val;
            Console.Write("Enter integer to check for leap year: ");
            val = Console.ReadLine();
            int a = Convert.ToInt32(val);
            if (isLeapYear(a)){
                Console.Write("yay");
            } else
            {
                Console.Write("nay");
            }
        }

        public static bool isLeapYear(int year) {
            if (year%4==0)
            {
                if (year%100==0)
                {
                    if (year%400==0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
