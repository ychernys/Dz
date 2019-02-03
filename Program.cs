using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Чернышев Юрий 
namespace ConsoleApp9
{ 
  
    class Program
    {
        private static bool Check(int n)
        {
            return n % 2 != 0 && n > 0;
        }

        static int Numver()
        {
            int t = 0;
            bool res;
            do
            {
                Console.WriteLine("Введите число");
                res = int.TryParse(Console.ReadLine(), out t);
                if (!res) Console.WriteLine("Не число");
            } while (!res);
            return t;
        }


        static void Main(string[] args)
        {
            int s = 0;

            while (true)
            {
                int n = Numver();
                if (n == 0) break;
                    if (Check(n)) s += n;

                Console.WriteLine(s);
                

                } 


    }

        }

    }
struct Complex
{

   public double im;  
    public double re;  

    
   
   
 
 
   public Complex Plus(Complex x)
    {
       Complex y;
       y.im = im + x.im;
        y.re = re + x.re;
        return y;
   }

    
   
   
   
    
   public Complex Minus(Complex x)
    {
       Complex y;
       y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }

 
    public Complex Multi(Complex x)
    {
       Complex y;
        y.im = re * x.im + im * x.re;
       y.re = re * x.re - im * x.im;
       return y;
    }

    
    public string ToStr()
   {
        if (im >= 0) return $"{re}+{im}i";
        else return $"{re}{im}i";
   }
}


class Program
{
    static void Main(string[] args)
    {
      Complex complex1;
       complex1.re = 1;
        complex1.im = 1;

       Complex complex2;
       complex2.re = 2;
       complex2.im = 2;

       Console.WriteLine("Сложение комплексных чисел: ");
       Complex result = complex1.Plus(complex2);
        Console.WriteLine(result.ToStr());

       Console.WriteLine("Вычитание комплексных чисел: ");
        result = complex1.Minus(complex2);
        Console.WriteLine(result.ToStr());

       Console.WriteLine("Произведение комплексных чисел: ");
        result = complex1.Multi(complex2);
       Console.WriteLine(result.ToStr());

    }
}

