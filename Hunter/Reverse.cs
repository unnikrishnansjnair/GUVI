using System;

namespace GUVI
{
    class Reverse
    {
        static void Main(string[] args)
        {
            Reverse rev = new Reverse();
            Console.Write("Enter a String to reverse : ");
            string str = Console.ReadLine();
            rev.check(str);
        }

        private void check(string s)
        {
            char[] chAr = s.ToCharArray();
            Array.Reverse(chAr);
            Console.Write("Output : ");
            Console.WriteLine(chAr);
            Console.ReadLine();
        }
    }
}
