using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guvi2
{
    class Program1
    {
        static void Main(string[] args)
        {
            Program1 pg = new Program1();
            Console.Write("Enter number of inputs : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number to check : ");
            int m = int.Parse(Console.ReadLine());
            int[] rate = new int[n];
            Console.Write("Enter {0} inputs followed by enter key: ", n);
            for (int i = 0; i < rate.Length; i++)
            {
                rate[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            pg.check(rate,m);
            Console.ReadLine();
        }

        public void check(int[] array,int n)
        {
            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }
            int flag = 0;
            foreach (var pair in dict)
            {
                //Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
                if (n == (pair.Key * pair.Value))
                    flag = 1;
                
            }
            if (flag == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}
