using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter string");
                string str = Console.ReadLine();
                str = str.Trim();

                string newString = GetAcronym(str);
                if (newString == String.Empty)
                {
                    return;
                }
                Console.WriteLine("new string");
                Console.WriteLine(newString);
            }
        }
        static string GetAcronym(string str)
        {
            if (str == "")
            {
                return String.Empty;
            }
            StringBuilder newStr = new StringBuilder();
            newStr.Append(Convert.ToString(str[0]));
            for (int i = 1; i < str.Length; i++)
            {
                if (Convert.ToString(str[i]) == " " && Convert.ToString(str[i + 1]) != " ")
                {
                    i++;
                    newStr.Append(str[i]);
                }
            }
            return newStr.ToString();
        }
    }
}
