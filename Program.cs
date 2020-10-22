using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public static string DrawingHorizont(ulong factorial)
        {
            string horizont = "";
            for (int i = 1; i <= factorial.ToString().Length + 2; i++)
            {
                horizont = horizont + "--";
            }
            return horizont;
        }

        static ulong CountForFact(int n) 
        {
            ulong f = 1;
            for (ulong i = 1; i <= Convert.ToUInt64(n); i++)
            {
                f *= i;
            }
            return f;
        }
        static void Main(string[] args)
        {
            int n;
            ulong factorial;
            string fct;

            while (true)
            {
                Console.WriteLine("Введите число:");
                fct = Console.ReadLine().Trim();
                if (Int32.TryParse(fct, out n) && Convert.ToInt32(fct) >= 1)
                {
                    n = Convert.ToInt32(fct);
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
            factorial = CountForFact(n);
            Console.Clear();
            Console.WriteLine(DrawingHorizont(factorial));
            Console.WriteLine('|');
            Console.SetCursorPosition(factorial.ToString().Length/2 + 2, 1);
            Console.Write(factorial);
            Console.WriteLine(" |");
            Console.WriteLine(DrawingHorizont(factorial));
            Console.ReadLine();
        }
    }
}
