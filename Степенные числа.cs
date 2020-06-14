using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Степенные_числа
{
    class Степенные_числа
    {
        public static int n = int.Parse(Console.ReadLine());
        static void Main()
        {
            string str;
            str = Console.ReadLine();
            string[] str1 = str.Split(' ');
            int[] str2 = Array.ConvertAll(str1, int.Parse);
           
            for (int j = 0; j < n; j++)
            {
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    str2[i] = str2[k];
                    k++;
                    
                    bool ok = false;
                    for (int l = 2; l <= Math.Sqrt(str2[i]); l++)
                    {
                        double x = Math.Log10(str2[i]) / Math.Log10(l);
                        int xx = Convert.ToInt32(x);
                        
                        if (Math.Pow(l, xx) == str2[i])
                        {
                            
                            Console.WriteLine("YES");
                            ok = true;
                            break;
                        }
                    }
                    if (!ok)
                        Console.WriteLine("NO");
                }
                
            }
           
        }
    }
}
