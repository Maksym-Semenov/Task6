using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        public static int Div(int a, int b) { return a / b; }
        public static int ReadNumber(int startRange, int finishRange)
        {
            if (currentValue > startRange && currentValue < finishRange)
            {
                return result;
            }
        }
        static void Main(string[] args)
        {
            //Part 1
        start:

            try
            {
                Console.WriteLine("Enter two values for divide");
                Console.WriteLine("Enter a = \t");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b = \t");
                int b = Convert.ToInt32(Console.ReadLine());
                int result = Div(a, b);
                Console.WriteLine(result);

                if (a < b)
                {
                    throw new Exception("Value 'a' must be > value 'b'");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }
            finally
            {
                Console.WriteLine("Yes!");
            }
            //Part 2
            Console.WriteLine("Enter start value: \t");




        }
    }
}
