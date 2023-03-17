using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string f="";
            Console.WriteLine("Write a string");
            string s=Console.ReadLine();
            Console.WriteLine("Write a character");
            char c= char.Parse(Console.ReadLine());

            foreach (char i in s)
            {
                if (i!=c)
                {
                    f+=i;
                }
            }
            Console.WriteLine(f);

        }
    }
}
