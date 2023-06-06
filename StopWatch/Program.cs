using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();

            int[] numbers = new int[100000];
            Random random = new Random();

            for(int i = 0; i < 100000; i++)
            {
                numbers[i] = random.Next(1, 100000);
            }

            stopWatch.Start();
            SelectionSort(numbers);
            stopWatch.Stop();

            Console.WriteLine("Elapsed Time: " + stopWatch.GetElapsedTime() + " milliseconds");

            Console.ReadKey();
        }

        static void SelectionSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }
        }
    }
}
