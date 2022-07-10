using System;
using System.Collections;
using System.Collections.Generic;

namespace Task6
{
    internal class Program
    {
        public static int Div(int a, int b) { return a / b; }

        public static List<int> ReadNumber(int startRange, int finishRange)
        {
            List<int> list = new List<int>(10);
            list.Add(startRange);
            int count = 0;
            try
            {
            firstStep:
                Console.WriteLine("Enter current value");
                bool succeess = int.TryParse(Console.ReadLine(), out int currentValue);
                if (count < 10 && currentValue > startRange && currentValue < finishRange && currentValue > list[count])
                {
                    list.Add(currentValue);
                    count++;
                    goto firstStep;
                }
                else if (count > 10)
                {
                    return list;
                }
                else
                    throw new Exception("It's wrong value");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }
        static void Main(string[] args)
        {
            //Part 1
        //start:

            //try
            //{
            //    Console.WriteLine("Enter two values for divide");
            //    Console.WriteLine("Enter a = \t");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter b = \t");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    int result1 = Div(a, b);
            //    Console.WriteLine(result1);

            //    if (a < b)
            //    {
            //        throw new Exception("Value 'a' must be > value 'b'");
            //    }
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    goto start;
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    goto start;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    goto start;
            //}
            //finally
            //{
            //    Console.WriteLine("Yes!");
            //}
            //Part 2
            Console.WriteLine("Enter start value: \t");
            int startRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter finish value: \t");
            int finishRange = Convert.ToInt32(Console.ReadLine());
            List<int> result = ReadNumber(startRange, finishRange);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
