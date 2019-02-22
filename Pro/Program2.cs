using System;
using System.Collections.Generic;
using System.Linq;

namespace Exp2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Program2 pgm = new Program2();
            Console.Write("Enter number of Arrays do you want : ");
            int numberOfArrays = int.Parse(Console.ReadLine());
            int[] narray = new int[numberOfArrays];
            int[] el=new int[100];
            int[] el1 = new int[100];
            List<int> list1 = new List<int>(100);
            List<int> list2 = new List<int>(100);
            for (int i = 0; i < narray.Length; i++)
            {
                Console.Write("Enter number of Elements do you want in Array {0}: ",i+1);
                int ai = int.Parse(Console.ReadLine());
                for (int j = 0; j < ai; j++)
                {
                    Console.Write("Enter the {1} Elements do you want in Array {0}: ", i+1,j+1);
                    //list1[j]= int.Parse(Console.ReadLine());
                    int kj = int.Parse(Console.ReadLine());
                    list1.Add(kj);
                }
                //el1 =el1.Concat(el).ToArray();
                //list2.AddRange(list1);
            }
            list2.AddRange(list1);
            /*foreach (int val in list2)
            {
                Console.Write(val+" ");
            }*/
            int[] lst = list2.ToArray();
            Array.Sort(lst);
            Console.Write("One way: ");
            foreach (int val in lst)
            {
                Console.Write(val + " ");
            }
            pgm.asc(lst);
            Console.ReadLine();
        }

        public void asc(int[] list)
        {
            int temp;
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] > list[j])
                    {

                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            Console.Write("\nAnother way: ");
            foreach(int val in list)
            {
                Console.Write(val+" ");
            }
        }
    }
}