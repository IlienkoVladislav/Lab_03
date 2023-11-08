using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Екосистема
    {
        private List<ЖивийОрганізм> організми;

        public Екосистема()
        {
            організми = new List<ЖивийОрганізм>();
        }

        public void ДодатиОрганізм(ЖивийОрганізм організм)
        {
            організми.Add(організм);
        }

        public void Взаємодія()
        {
            foreach (var організм in організми)
            {
                організм.Вік++;
                організм.Енергія -= 5;
                організм.Розмір += 0.1;

                Console.Write($"Організм з віком {організм.Вік} років: ");
                організм.ВідображенняХарактеристик();

                if (організм is IReproducible && організм.Енергія > 20)
                {
                    ((IReproducible)організм).Розмножитися();
                }

                if (організм is IPredator)
                {
                    foreach (var іншаОрганізм in організми)
                    {
                        if (іншаОрганізм != організм && іншаОрганізм.Енергія < організм.Енергія)
                        {
                            Console.WriteLine("Полювання:");
                            ((IPredator)організм).Полювати(іншаОрганізм);
                            організм.Енергія += 10;
                            іншаОрганізм.Енергія = 0;
                            break;
                        }
                    }
                }
            }
        }
    }
}
