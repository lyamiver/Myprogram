using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача5
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, Maxim;
            bool okey;
            Random random = new Random();
            //Проверка
            do
            {
                Console.WriteLine("Введите размер матрицы: ");
                okey = int.TryParse(Console.ReadLine(), out r) && r > 0;
                if (!okey)
                    Console.WriteLine("Требуется ввести натуральное число.");
            } while (!okey);

            int[,] Matrix = new int[r, r];
            int rand;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    rand = random.Next(0, 20);
                    Matrix[i, j] = rand;
                }
            }
            //Выводим матрицу на экран
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Ищем наибольшее значение в матрице в заштрихованной части(треугольник над диагональю) 
            Maxim = 0;

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    if ((i <= r - 1 - j) && (Matrix[i, j] > Maxim))
                    {
                        Maxim = Matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Наибольший элемент в выделенной области равен {0}.", Maxim);
            Console.ReadKey();
        }
    }
}
