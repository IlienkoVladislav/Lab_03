using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_02.Компютер;

namespace Task_02
{
    public class Мережа
    {
        private List<Компютер> компютери;

        public Мережа()
        {
            компютери = new List<Компютер>();
        }

        public void ДодатиКомпютер(Компютер компютер)
        {
            компютери.Add(компютер);
        }

        public void Підключити(IConnectable пристрій, Компютер компютер)
        {
            пристрій.Connect(компютер);
        }

        public void Відключити(IConnectable пристрій, Компютер компютер)
        {
            пристрій.Disconnect(компютер);
        }

        public void ВідправитиДані(IConnectable відправник, string data, Компютер отримувач)
        {
            відправник.SendData(data, отримувач);
        }
    }
}