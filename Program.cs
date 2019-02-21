using System;

namespace GUVI
{
    class Program
    {
        static void Main(string[] args)
        {
            Program num = new Program();
            Console.Write("Enter the number to check: ");
            int n=int.Parse(Console.ReadLine());
            num.check(n);
        }

        private void check(int n)
        {
            
            if (n > 0)
            {
                Console.WriteLine("{0} is a positive Number", n);
            }
            else if (n < 0)
            {
                Console.WriteLine("{0} is a negative Number", n);
            }
            else
            {
                Console.WriteLine("{0} is a nutral Number", n);
            }
           
            Console.ReadLine();
        }
    }
}
