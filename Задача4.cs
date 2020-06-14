using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача4
{
    class Program
    {
        static void Main(string[] args)
        { 
            bool okey;
            double e;
            //Проверка
            do
            {
                Console.WriteLine("Введите точность: ");
                okey = double.TryParse(Console.ReadLine(), out e) && e > 0 && e <1;
                if (!okey)
                    Console.WriteLine("Требуется ввести натуральное число.");
            } while (!okey);
                 
                double sum = 0, i = 1, eps;
                while (e > 0)
                {
                    eps = (Math.Pow(-1, i + 1) ) / (i * (i + 1) * (i + 2));
                    if (Math.Abs(eps) < e) break;
                    sum += eps;
                    i++;
                }
                Console.WriteLine("Сумма eps = " + sum);
                Console.ReadKey();
        }
        
    }
}
