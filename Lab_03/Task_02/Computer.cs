using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public interface IConnectable
    {
        void Connect(Компютер компютер);
        void Disconnect(Компютер компютер);
        void SendData(string data, Компютер отримувач);
    }

    public class Компютер
    {
        public string IPАдреса { get; set; }
        public int Потужність { get; set; }
        public string ТипОС { get; set; }

        public Компютер(string ipАдреса, int потужність, string типОС)
        {
            IPАдреса = ipАдреса;
            Потужність = потужність;
            ТипОС = типОС;
        }
    }

    public class Сервер : Компютер, IConnectable
    {
        public Сервер(string ipАдреса, int потужність, string типОС) : base(ipАдреса, потужність, типОС) { }

        public void Connect(Компютер компютер)
        {
            Console.WriteLine($"Сервер {IPАдреса} підключений до комп'ютера {компютер.IPАдреса}");
        }

        public void Disconnect(Компютер компютер)
        {
            Console.WriteLine($"Сервер {IPАдреса} відключений від комп'ютера {компютер.IPАдреса}");
        }

        public void SendData(string data, Компютер отримувач)
        {
            Console.WriteLine($"Дані '{data}' відправлені з сервера {IPАдреса} до комп'ютера {отримувач.IPАдреса}");
        }
    }

    public class РобочаСтанція : Компютер, IConnectable
    {
        public РобочаСтанція(string ipАдреса, int потужність, string типОС) : base(ipАдреса, потужність, типОС) { }

        public void Connect(Компютер компютер)
        {
            Console.WriteLine($"Робоча станція {IPАдреса} підключена до комп'ютера {компютер.IPАдреса}");
        }

        public void Disconnect(Компютер компютер)
        {
            Console.WriteLine($"Робоча станція {IPАдреса} відключена від комп'ютера {компютер.IPАдреса}");
        }

        public void SendData(string data, Компютер отримувач)
        {
            Console.WriteLine($"Дані '{data}' відправлені з робочої станції {IPАдреса} до комп'ютера {отримувач.IPАдреса}");
        }
    }

    public class Маршрутизатор : Компютер, IConnectable
    {
        public Маршрутизатор(string ipАдреса, int потужність, string типОС) : base(ipАдреса, потужність, типОС) { }

        public void Connect(Компютер компютер)
        {
            Console.WriteLine($"Маршрутизатор {IPАдреса} підключений до комп'ютера {компютер.IPАдреса}");
        }

        public void Disconnect(Компютер компютер)
        {
            Console.WriteLine($"Маршрутизатор {IPАдреса} відключений від комп'ютера {компютер.IPАдреса}");
        }

        public void SendData(string data, Компютер отримувач)
        {
            Console.WriteLine($"Дані '{data}' відправлені з маршрутизатора {IPАдреса} до комп'ютера {отримувач.IPАдреса}");
        }
    }
}
