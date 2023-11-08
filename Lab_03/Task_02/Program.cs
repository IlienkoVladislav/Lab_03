using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Мережа мережа = new Мережа();

            Сервер сервер = new Сервер("192.168.0.1", 1000, "Windows Server");
            РобочаСтанція робочаСтанція = new РобочаСтанція("192.168.0.2", 500, "Windows 10");
            Маршрутизатор маршрутизатор = new Маршрутизатор("192.168.0.3", 800, "Cisco");

            мережа.ДодатиКомпютер(сервер);
            мережа.ДодатиКомпютер(робочаСтанція);
            мережа.ДодатиКомпютер(маршрутизатор);

            мережа.Підключити(сервер, робочаСтанція);
            мережа.Підключити(маршрутизатор, сервер);

            мережа.ВідправитиДані(робочаСтанція, "Привіт, світ!", сервер);

            мережа.Відключити(маршрутизатор, сервер);
        }
    }
}
