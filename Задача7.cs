using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод функции
            string input;
            input = CheckInput("Введите булеву функцию, заданную вектором значений. Для ввода используйте 0, 1 и *");
            // Строка, содержащая информацию о том, что функция никогда не может быть монотонной, если это так
            string never;
            // Проверка на немонотонность
            CheckNotMonotone(input, out never);
            // Если строка содержит информацию о том, что функция никогда не может быть монотонной, завершение работы
            if (never.Contains("никогда"))
            {
                return;
            }
            else
            {
                // Если функцию можно доопределить, доопределение и вывод всех способов
                string output = ChangeIfPossible(input);
                Console.WriteLine("Все возможные способы доопределения: ");
                MakeAnswer(output);
                Console.ReadKey();
            }
        }
        // Проверка ввода
        public static string CheckInput(string s)
        {
            Console.WriteLine(s);
            string input;
            input = Console.ReadLine();
            // Вычисление количества введённых символов
            int n = input.Length;

            // Проверка ввода
            for (int i = 0; i < n; i++)
            {
                // Если введённый символ соответствует одному из перечисленных (0, 1, *), ввод корректен
                if (input[i] == '0' || input[i] == '1' || input[i] == '*')
                {
                    // Ввод корректен
                }
                // Если присутствует что-либо другое, ввод некорректен
                else
                {
                    // Ввод некорректен
                    Console.WriteLine("Ввод некорректен, попробуйте снова");
                    // Повторный ввод функции
                    input = Console.ReadLine();
                    // Вычисление новой длины
                    n = input.Length;
                    // Обнуление индекса для проверки новой функции (-1, так как следующим действием в цикле будет i++)
                    i = -1;
                }
            }

            int two = n;
            // Проверка, что функция корректной длины
            do
            {
                if (two % 2 != 0)
                {
                    do
                    {
                        Console.WriteLine("Функция задана неверно. Количество введённых цифр должно быть степенью двойки");
                        input = Console.ReadLine();
                        n = input.Length;
                        two = n;
                    } while (two % 2 != 0);
                }
                two = two / 2;
            } while (two > 1);

            return input;
        }
       
        
    }
}
