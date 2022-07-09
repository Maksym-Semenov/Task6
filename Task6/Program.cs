using System;
using System.Collections;
using System.Collections.Generic;

namespace Task6
{
    internal class Program
    {
        public static int Div(int a, int b) { return a / b; }
        public static int ReadNumber(int startRange, int finishRange)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startRange);
        firstStep:    Console.WriteLine("Enter current value");
                bool succeess = int.TryParse(Console.ReadLine(), out int currentValue);
            try 
            {
                if (currentValue > startRange && currentValue < finishRange )
                {

                    queue.Enqueue(currentValue);
                    if (queue.Count > 10)
                        goto secondStep;
                    else
                        goto firstStep;
                }
                else
                {
                    throw new Exception("It's wrong!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto firstStep;
            }
        secondStep:    return currentValue;
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
            int result2 = ReadNumber(startRange, finishRange);
            Queue <int> queue = new Queue< int>();
            queue.Enqueue(result2);
            Console.WriteLine(queue);
            Console.ReadLine();
        }
    }
}
