using System;

namespace GUVI
{
    class Prog1
    {
        static void Main(string[] args)
        {
            Prog1 pro = new Prog1();
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            pro.check(n);
            Console.ReadLine();
        }

        private void check(int n)
        {
            int res = 1;
            int k;
            for(int i =1;i<=n;i++)
            {
                for(int j = 1; j <= 3; j++)
                {
                    for(k=j; k < j + 3; k++)
                    {
                        Console.Write(k+" ");
                    }
                }//i++;
            }
            //Console.WriteLine("Output :");
        }
    }
}
