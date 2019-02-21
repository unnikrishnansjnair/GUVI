using System;

namespace GUVI
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            OddOrEven num = new OddOrEven();
            Console.Write("Enter the number to check: ");
            int n;
            bool parsedSuccessfully = int.TryParse(Console.ReadLine(), out n);
            if (parsedSuccessfully == false)
            {
                Console.Write("Please type a number.! Enter the number to check: ");
                n = int.Parse(Console.ReadLine());
                num.check(n);
            }
            else
            {
                num.check(n);
            }
            
        }

        private void check(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(n+" is an even number.");
            }
            else
            {
                Console.WriteLine(n + " is an odd number.");
            }
            Console.ReadLine();
        }
    }
}
