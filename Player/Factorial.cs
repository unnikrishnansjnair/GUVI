using System;

namespace GUVI
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Factorial fact = new Factorial();
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            fact.check(n);
            Console.ReadLine();
        }

        private void check(int n)
        {
            int res = 1;
            for(int i =1;i<=n;i++)
            {
                res *= i;
            }
            Console.WriteLine("Output : Factorial of {0} is {1}.",n,res);
        }
    }
}
