using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipile
{
    class Program
    {
        static void Palindrome()
        {
            string s, revs = string.Empty;
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            Console.WriteLine(revs + "=" + s);
        }
        
        static void Main(string[] args)
        {
            Palindrome();
            Console.Read();
        }
    }
}
