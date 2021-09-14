using System;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime = false;
            int j;
            
            for (int i = 2; i <= 1000; i++)
            {
                for (j = 2; j < i; j++)  
                {  
                    if (i % j == 0)  
                    {  
                        prime = true;  
                        break;  
                    }
                }  
                if (!prime)  
                    Console.Write("{0} ", j);  
                else  
                    prime = false;
            }
            
            // Console.WriteLine("Hello World!");
        }
    }
}