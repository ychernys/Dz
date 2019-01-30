using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Min(string[] args)
        {
            int a = 2;
            int b = 100;
            int c = 10000;

            if (a < b && a < c) 
            {
                Console.WriteLine($"Min num = {a}");
            }
            else
            {
                if (b < c)
                {
                    Console.WriteLine($"Min num = {b}");
                }
                else
                {
                    Console.WriteLine($"Min num = {c}");
                }
                Console.ReadLine();
            }
            Console.ReadKey();
        }


    }
}
  
  static void ves3()
{
    Console.WriteLine("Введите вашу массу");
    Double m = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите ваш рост");
    Double h = Convert.ToDouble(Console.ReadLine());

    double l = m / (h * h);
    Console.WriteLine($"Ваш ИМТ = {l}");

    if (l > 0.003)
    {
        Console.WriteLine("Вам нужно похудеть");
    }
    else
    {
        Console.WriteLine("Вам нужно потолстеть");
    }
    Console.ReadKey();
}



static void numbers(string[] args)
{
    Console.WriteLine("Введите меньшее число");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите большее число");
    int b = int.Parse(Console.ReadLine());

    for (int i = a; i <= b; i++)
    {
        Console.WriteLine(i);
    }
    Console.ReadLine();
}