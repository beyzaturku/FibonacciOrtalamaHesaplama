using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciOrtalamaHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz:");
            int n = int.Parse(Console.ReadLine());
           
            int sum = 0;
            int prev = 0; //önceki eleman
            int curr = 1; //şu anki eleman

            for(int i=0; i<n; i++)
            {
                int next = prev + curr;
                sum += curr;
                prev = curr;
                curr = next;
            }

            double average = (double)sum / n;
            Console.WriteLine("Fibonacci serisindeki sayıların ortalaması:" + average);

            

        }
    }
}
