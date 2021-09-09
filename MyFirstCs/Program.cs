using System;
using System.Collections.Generic;
namespace MyFirstCs
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            string val;
            Console.Write("Enter a year after 1582 to check for leap year: ");
            val = Console.ReadLine();
            try
            {
                 int a = Convert.ToInt32(val);
                if (a<1582) {
                    throw new OverflowException();
                }
                if (isLeapYear(a)){
                    Console.Write("yay");
                } else  {
                Console.Write("nay");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("your number is too large or too small");
            }
            catch (FormatException)
            {
                Console.WriteLine("this is not a proper format");
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
