using System;

namespace GUVI
{
    class Unique
    {
        static void Main(string[] args)
        {
            Unique pro = new Unique();
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.Write("Enter {0} numbers followed by enter key: ",n);
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            pro.check(a,n);
            Console.ReadLine();
        }

        private void check(int[] a,int nu)
        {
            int count = 0;
            for (int i = 0; i < nu; i++)
            {
                for(int j=i+1;j<nu; j++)
                {
                    if (a[i] == a[j])
                    {
                        count=1;
                        break;
                    }
                    //Console.Write(" "+a[i]+" and "+a[j]+" ");
                }
                if (count == 0)
                {
                    Console.WriteLine(a[i]);
                    break;
                }
            }
            
        }
    }
}
