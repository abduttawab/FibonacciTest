using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    class Program
    {
        public static  void Fibonacci_Recursive()
        {
            Console.Write("The Fibonacci sequence is: \n\n");
            Fibonacci_Rec_Temp(0, 1,1, 0);
        }

        private static void Fibonacci_Rec_Temp(int a, int b, int terms, int sumOfEvenTerms)
        {
          
            
            if (a <= 4000000)
            {
                if (IsEven(a))
                {
                    sumOfEvenTerms+= terms;
                }
               
                Console.Write("{0} ", a);

                Fibonacci_Rec_Temp(b, a + b, terms+1, sumOfEvenTerms);
            }
            else
            {
                Console.Write("\n\n Sum of the even-valued terms: {0}", sumOfEvenTerms);
            }
        }
        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
        static void Main(string[] args)
        {
            Fibonacci_Recursive();

            Console.ReadKey();
        }
    }
}
