using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_01.Рослина;

namespace Task_01
{
    public class ЖивийОрганізм
    {
        public double Енергія { get; set; }
        public int Вік { get; set; }
        public double Розмір { get; set; }

        public ЖивийОрганізм()
        {
            Random random = new Random();
            Енергія = random.Next(1, 100);
            Вік = 0;
            Розмір = random.NextDouble() * 10;
        }

        public void ВідображенняХарактеристик()
        {
            Console.WriteLine($"Вік: {Вік}, Енергія: {Енергія}, Розмір: {Розмір:F2}");
        }
    }
   
    public interface IReproducible
    {
        void Розмножитися();
    }

    public interface IPredator
    {
        void Полювати(ЖивийОрганізм жертва);
    }

    public class Тварина : ЖивийОрганізм, IReproducible, IPredator
    {
        public void Розмножитися()
        {
            Console.WriteLine("Тварина розмножується.");

            
            Random random = new Random();
            double шансРозмноження = random.NextDouble(); 

            if (шансРозмноження > 0.6)
            {
                Console.WriteLine("Тварина розмножується.");
            }
            else
            {
                Console.WriteLine("Розмноження не відбулося.");
            }
        }

        public void Полювати(ЖивийОрганізм жертва)
        {
            Console.WriteLine("Тварина полює на організм.");

            if (жертва != null && жертва.Енергія > 0)
            {
                Console.WriteLine("Тварина успішно полювала на організм!");
                жертва.Енергія -= 20; 
            }
            else
            {
                Console.WriteLine("Полювання не вдалося.");
            }
        }
    }

    public class Рослина : ЖивийОрганізм, IReproducible
    {
        public void Розмножитися()
        {
            Console.WriteLine("Рослина розмножується.");

            Random random = new Random();
            double шансРозмноження = random.NextDouble(); 

            if (шансРозмноження > 0.7)
            {
                Console.WriteLine("Рослина розмножується шляхом насіння.");
            }
            else
            {
                Console.WriteLine("Розмноження не відбулося.");
            }
        }

        public class Мікроорганізм : ЖивийОрганізм, IReproducible
        {
            public void Розмножитися()
            {
                Console.WriteLine("Мікроорганізм розмножується.");


                Random random = new Random();
                double шансРозмноження = random.NextDouble();

                if (шансРозмноження > 0.5)
                {

                    Мікроорганізм новийМікроорганізм = new Мікроорганізм();
                    Console.WriteLine("Новий мікроорганізм створений!");
                }
                else
                {
                    Console.WriteLine("Розмноження не відбулося.");
                }
            }
        }
    }
}
