using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeModified
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number: ");
                int input = int.Parse(Console.ReadLine());

                bool isPrime = true;

                for (int div = 2; div <= Math.Sqrt(input); div++)
                {
                    if (input % div == 0)
                    {
                        isPrime = false;
                        break; 
                    }
                }

                if (input <= 1)
                {
                    Console.WriteLine(input + " is not a Prime number"); // 1 and negative numbers are not prime
                }
                else if (isPrime)
                {
                    Console.WriteLine(input + " is a Prime Number");
                }
                else
                {
                    Console.WriteLine(input + " is not a Prime number");
                }
            
        }

    }
}
