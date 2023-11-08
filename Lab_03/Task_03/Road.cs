using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Road
    {
        public double Довжина { get; set; }
        public double Ширина { get; set; }
        public int КількістьСмуг { get; set; }
        public int РівеньТрафіку { get; set; }

        public Road(double довжина, double ширина, int кількістьСмуг)
        {
            Довжина = довжина;
            Ширина = ширина;
            КількістьСмуг = кількістьСмуг;
            РівеньТрафіку = 0;
        }
    }

    public interface IDriveable
    {
        void Рухатися();
        void Зупинятися();
    }

    public class ТранспортнийЗасіб : IDriveable
    {
        public string Тип { get; set; }
        public double Швидкість { get; set; }
        public double Розмір { get; set; }

        public ТранспортнийЗасіб(string тип, double швидкість, double розмір)
        {
            Тип = тип;
            Швидкість = швидкість;
            Розмір = розмір;
        }

        public void Рухатися()
        {
            Console.WriteLine($"Транспортний засіб типу {Тип} рухається зі швидкістю {Швидкість} км/год.");
        }

        public void Зупинятися()
        {
            Console.WriteLine($"Транспортний засіб типу {Тип} зупинився.");
        }
    }
}
