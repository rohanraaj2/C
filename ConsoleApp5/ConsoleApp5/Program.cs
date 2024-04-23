using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello Rohan. How are you";
            for (int i = 0; i < s.Length; i++) 
            {
                //Console.WriteLine(s[i].GetType());
                List<string> l;
                if (s[i].ToString() != " " && s[i].ToString() != ".")
                {

                    l.Append(s[i].ToString());
                    Console.WriteLine(l);
                    //Console.WriteLine(s[i].ToString() + ':');
                }
                
            };
        }
    }
}
