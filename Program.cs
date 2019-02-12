using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "chernyshov";

            if (source.Length < 2 || source.Length > 10)
            {
                Console.WriteLine("Login is incorrect");
            }

            if (!Char.IsDigit(source[0]))
            {
                Console.WriteLine("Login is incorrect");
            }
            bool correct = true;

            for (int i = 0; i < source.Length; i++)
            {
                if (!Char.IsLetterOrDigit(source[i]))
                {
                    correct = false;
                    break;
                }
            }
            if (correct)
            {
                Console.WriteLine("Login is correct");
            }
            else
            {
                Console.WriteLine("Login is incorrect");
            }
            Console.ReadKey();
        }


    }
    public static void dsd(string[] args)
    {
        Console.WriteLine(String.Join(" ", "У дома было шесть окон. одно выбили.".Split().Where(x => x.Length < 7)));


    }
}
