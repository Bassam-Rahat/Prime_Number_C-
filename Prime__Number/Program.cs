using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime__Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to check whether number is prime or not: ");
            int number = int.Parse(Console.ReadLine());

            checkPrime(number);

            Console.ReadLine();
        }

        public static void checkPrime(int number)
        {
            bool checkPN = true;
            for(int i=2; i<=number/2 ; i++) {
            
                if(number%i==0) { 
                    checkPN = false;break; 
                }
            }

            if(checkPN)
            {
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is not Prime");
            }
        }
    }
}
