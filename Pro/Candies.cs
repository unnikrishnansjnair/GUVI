using System;

namespace exp1
{
    class Candies
    {
        static void Main(string[] args)
        {
            Candies can = new Candies();
            Console.Write("Enter number of inputs : ");
            int n = int.Parse(Console.ReadLine());
            int[] rate = new int[n];
            Console.Write("Enter {0} inputs followed by enter key: ", n);
            for (int i = 0; i < rate.Length; i++)
            {
                rate[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            can.arrange(rate);
            Console.ReadLine();
        }

        public void arrange(int[] rate)
        {
            int temp;
            for (int i = 0; i < rate.Length - 1; i++)
            {
                for (int j = i + 1; j < rate.Length; j++)
                {
                    if (rate[i] > rate[j])
                    {

                        temp = rate[i];
                        rate[i] = rate[j];
                        rate[j] = temp;
                    }
                }
            }

            //Array.Sort(rate);
            //Array.Reverse(rate);
            int a = 0, b = 0;
            foreach (int val in rate)
            {
                
                //Console.Write(val + " ");
                
                if (val > b)
                {
                    a++;
                    //Console.WriteLine(a);
                    b = val;
                }
                
                
            }
            Console.WriteLine("There should need of minimum of {0} Candies.", a);
            
        }

    }
}
