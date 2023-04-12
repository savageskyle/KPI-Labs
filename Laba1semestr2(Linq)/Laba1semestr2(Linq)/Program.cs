using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba1semestr2_Linq_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введiть кiлькiсть чисел: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if(n>0)
                {
                    int[] numbers = new int[n];
                    Console.WriteLine("введені числа: ");
                    for (int i = 0; i < n; i++)
                    {
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    var positiveNumbers = numbers.Where(m => m > 0);

                    Console.WriteLine("позитивнi числа:");

                    foreach (var num in positiveNumbers)
                    {
                        Console.Write($" {num}");
                    }
                }
                else
                {
                    Console.WriteLine("число має бути більшим за нуль");
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Невірний формат");
            }           
            Console.ReadLine();
        }
    }
}
