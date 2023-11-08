using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Road основнаДорога = new Road(10, 20, 2);
            ТранспортнийЗасіб автомобіль = new ТранспортнийЗасіб("автомобіль", 60, 4.5);

            CityTraffick місто = new CityTraffick();
            місто.МоделюватиРух(основнаДорога, автомобіль);
        }
    }
}
