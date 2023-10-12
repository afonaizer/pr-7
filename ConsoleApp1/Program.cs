using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////задан1         

            //for (int i = 0; i < 256; i++)
            //    Console.WriteLine($"код {i} соотвст к {(char)i}");

            //задание2
            //Console.WriteLine("Введите символ: ");            
            //char ch = char.Parse(Console.ReadLine());           
            //Console.WriteLine("Символ: {0}; Код: {1}", ch, (int)ch);
            //Console.ReadKey(true);

            ////задан3
            //Console.Write("введ символ");
            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine($"Символ : {(char)(int)(ch+1)}"); 

            ////задан4
            //Console.WriteLine("введ симвл:  ");
            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine($"Символы : {(char)(int)(ch - 1)} и {(char)(int)(ch-2)}");

            ////задан5
            //Console.WriteLine("введ симвл:  ");
            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine($"Символы : {(char)(int)(ch - 1)} и {(char)(int)(ch + 1)}");

            ////задание6
            //Console.WriteLine("введ назван клуба");
            //string name = Convert.ToString(Console.ReadLine());
            //char[] omas = name.ToCharArray();
            //for (int i=0; i<omas.Length; i++)
            //{ Console.WriteLine(omas[i]);  }

            ////задание7
            //Console.WriteLine("Введите слово: ");
            //string name = Console.ReadLine();
            //char[] chars = name.ToCharArray();
            //for (int a = name.Length - 1; a >= 0; a--)
            //{ Console.WriteLine($"{chars[a]}"); }

            ////задание 8
            Console.Write("Введите строку:");
            string str = Console.ReadLine();
            char[] simvol = str.ToCharArray();
            for (int i = 0; i < simvol.Length; i++)
            {
                Console.Write(char.ToUpper(simvol[i]));
            }
            Console.WriteLine();
            for (int i = 0; i < simvol.Length; i++)
            {
                Console.Write(char.ToLower(simvol[i]));
            }




            Console.ReadKey();


















        }       
    }
}
