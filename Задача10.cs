using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача10
{
    class Derevo
    {
        public double time;
        public Derevo levo, pravo;
        public Derevo()
        {
            time = 0;
            levo = null;
            pravo = null;
        }
        public Derevo(double t)
        {
            time = t;
            levo = null;
            pravo = null;
        }

        public override string ToString()
        {
            return time.ToString() + "  ";
        }
    }

    class Program
    {
        public static int k = 0, vivo, vavo, Chetchik =0;
        public static Derevo idDerevoo = null, idDereevoo = null, idDerevo = null;
        public static Derevo[] arra;
        public static Random ran = new Random();

        public static void Sdelat()
        {
            bool okey;
            //Проверка
            do
            {
                Console.WriteLine("Введите кол-во чисел для 1 дерево");
                okey = int.TryParse(Console.ReadLine(), out vivo);
                if (!okey)
                    Console.WriteLine("Требуется ввести натуральное число.");
            } while (!okey);
                      
            do
            {
                Console.WriteLine("Введите кол-во чисел для 2 дерева");
                okey = int.TryParse(Console.ReadLine(), out vavo);
                if (!okey)
                    Console.WriteLine("Требуется ввести натуральное число.");
            } while (!okey);
            arra = new Derevo[vivo+vavo];
           // Chetchik ++;
            Console.Clear();
        }
         
        public static Derevo IdealnDerevo(int viv, Derevo m, int typeIdealnDerevo)
        {
            Derevo t;
            int le, pr;
            if(vivo == 0)
            {
                m = null;
                return m;
            }
            le = viv / 2;
            pr = viv - le - 1;
            Derevo v = SostavDerev();
            t = v;
            
                arra[k] = t; 
                //k++;
            
            
            t.levo = IdealnDerevo(le, t.levo, typeIdealnDerevo);
            t.pravo = IdealnDerevo(pr, t.pravo, typeIdealnDerevo);

            m = t;
            return m;
        }

        public static Derevo IdealnDerevo(int viv, Derevo m)
        {
            Derevo t;
            int le, pr;
            if (viv == 0)
            {
                m = null;
                return m;
            }
            le = viv / 2;
            pr = viv - le - 1;
            Derevo v = arra[k];
            k++;
            t = v;
            t.levo = IdealnDerevo(le, t.levo);
            t.pravo = IdealnDerevo(pr, t.pravo);

            m = t;
            return m;
        }

        public static Derevo SostavDerev()
        {
            double f;
            if (Chetchik==0)
            {
                bool okey;
                do
                {
                    Console.WriteLine("Введите элемент:");
                    okey = double.TryParse(Console.ReadLine(), out f) ;
                    if (!okey)
                        Console.WriteLine("Требуется ввести натуральное число.");
                } while (!okey);

                Console.WriteLine("Добавленo!");
                Chetchik++;
                return new Derevo(f);
            }
            /*else
            {
                //f = ran.Next(0, 100);
                f = f / 10;
                return new Derevo(f);
            }*/
            return new Derevo();
        }
        private static void PokasDerevo(Derevo m, int l)
        {
            if (m != null)
            {
                PokasDerevo(m.levo, l + 3);//переход к левому поддереву
                for (int i = 0; i < l; i++) Console.Write(" ");
                Console.WriteLine(Convert.ToString(m.time) + "\n");
                PokasDerevo(m.pravo, l + 3);//переход к правому поддереву
            }
        }
        private static void Otvet()
        {
            Console.Clear();
            Console.WriteLine(" Дерево 1:");
            PokasDerevo(idDerevoo, 6);
            Console.WriteLine(" Дерево 2:");
            PokasDerevo(idDereevoo, 6);
            k = 0;
            idDerevo = IdealnDerevo(vivo + vavo, idDerevo);
            Console.WriteLine(" Итог: ");
            PokasDerevo(idDerevo, 6);
        }



        static void Main(string[] args)
        {
            Sdelat();
            idDerevoo = IdealnDerevo(vivo, idDerevoo, Chetchik);
            idDereevoo = IdealnDerevo(vavo, idDereevoo, Chetchik);
            Otvet();
        }
    }

    


}
