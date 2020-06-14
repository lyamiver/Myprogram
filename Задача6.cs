using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задача6
{
    class Program
    {
        public static double Maa(double a1, double a2, double a3, int k )
        {
            double Ak;
            if(k ==1)
            {
                Ak = a1;
            }
            else if (k == 2)
            {
                Ak = a2;
            }
            else if (k == 3)
            {
                Ak = a3;
            }
            else
            {
                Ak = (Maa(a1, a2, a3, k - 1) + 1) / (Maa(a1, a2, a3, k - 2) + 2) * (Maa(a1, a2, a3, k - 3));
            }
            return Ak;
        }
        static void Main()
        {
            double a1 ;
            bool okey;
            do
            {
                Console.WriteLine("Введите первый член последовательности");
                okey = double.TryParse(Console.ReadLine(), out a1);
                if (!okey)
                    Console.WriteLine("Вы ввели не правильное число!.");
            } while (!okey);

            double a2;
            do
            {
                Console.WriteLine("Введите второй член последовательности");
                okey = double.TryParse(Console.ReadLine(), out a2);
                if (!okey)
                    Console.WriteLine("Вы ввели не правильное число!.");
            } while (!okey);
            double a3;
            do
            {
                Console.WriteLine("Введите третий член последовательности");
                okey = double.TryParse(Console.ReadLine(), out a3);
                if (!okey)
                    Console.WriteLine("Вы ввели не правильное число!.");
            } while (!okey);


            int N;
            do
            {
                Console.WriteLine("Введите кол-во чесел в последовательности");
                okey = int.TryParse(Console.ReadLine(), out N) && N > 0;
                if (!okey)
                    Console.WriteLine("Требуется ввести натуральное число.");
            } while (!okey);
            
            
            
            double[] arra = new double[N];
            double Ak = 0;
            
            for (int i = 1; i <= N; i++)
            {
                Ak = Maa(a1, a2, a3, i);
                Console.Write(Ak + " ");
            }

            int v = 0;
            bool ok = true;
            
            for (int may = 0; may<N; may++)
            {
                try
                {
                    if (arra[may] == arra[may - 1])
                    {
                        ok = false;
                        v++;
                    }
                    if (arra[may] < arra[may + 1])
                        v++;
                }
                catch (IndexOutOfRangeException) { }
               
            }
            if (v == N - 1 && ok)
                Console.WriteLine("Последовательность строго возрастающая");
            else if(v == N - 1 && !ok)
                Console.WriteLine("Последовательность монотонно неубывающая");
            else Console.WriteLine("Эта последовательность не относится к монотонно неубывающей или строго возрастающей ");
            Console.ReadKey();
        }


    }
}
