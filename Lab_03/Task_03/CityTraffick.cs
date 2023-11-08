using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class CityTraffick
    {
        public void МоделюватиРух(Road дорога, ТранспортнийЗасіб транспортнийЗасіб)
        {
            Console.WriteLine($"Дорога довжиною {дорога.Довжина} км, шириною {дорога.Ширина} м, {дорога.КількістьСмуг} смуг, рівень трафіку: {дорога.РівеньТрафіку}");

            if (дорога.РівеньТрафіку > 5)
            {
                транспортнийЗасіб.Зупинятися();
            }
            else
            {
                транспортнийЗасіб.Рухатися();
            }
        }
    }
}
