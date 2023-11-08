using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_01.Рослина;

namespace Task_01
{
 
    
        internal class Program
        {
            static void Main(string[] args)
            {
               Console.OutputEncoding = Encoding.UTF8;

            Екосистема екосистема = new Екосистема();

               
            Тварина тварина = new Тварина();
            Рослина рослина = new Рослина();
            Мікроорганізм мікроорганізм = new Мікроорганізм();

                екосистема.ДодатиОрганізм(тварина);
                екосистема.ДодатиОрганізм(рослина);
                екосистема.ДодатиОрганізм(мікроорганізм);

                for (int ітерація = 0; ітерація < 10; ітерація++)
                {
                    Console.WriteLine($"Ітерація {ітерація + 1}:");
                    екосистема.Взаємодія();
                    Console.WriteLine();
                }
            }
        }
   
}
