using System;

namespace GUVI
{
    class LargestNumberev
    {
        static void Main(string[] args)
        {
            LargestNumberev ln = new LargestNumberev();
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.Write("Enter {0} numbers followed by enter key: ",n);
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            ln.check(a,n);
            Console.ReadLine();
        }

        private void check(int[] a,int nu)
        {
            int temp = 0;
            for (int i = 0; i < nu; i++)
            {
                for(int j=i+1;j<nu; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                    //Console.Write(" "+a[i]+" and "+a[j]+" ");
                }
               
            }
                
            for(int i = a.Length-1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
            
        }
    }
}
