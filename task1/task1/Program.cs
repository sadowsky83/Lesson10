using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Угол из градусов в радианы
        static void Main(string[] args)
        {
            Degrees degrees = new Degrees();
            Console.WriteLine("Введите градусы (целое число)");
            degrees.Gradus = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите минуты (целое число)");
            degrees.Min = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите секунды (целое число)");
            degrees.Sec = (Convert.ToInt32(Console.ReadLine()));
            degrees.ToRadians();
        }
    }
    class Degrees
    {
        int gradus = 45;
        int min = 0;
        int sec = 0;

        public int Gradus
        {
            set
            {
                if (value > 0)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Угол не может быть отрицательным. Принято значение по умолчанию " + gradus);
                }
            }
            get { return gradus; }
        }
        public int Min
        {
            set
            {
                if (value > 0 && value < 59)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Количество минут не может быть не может быть меньшн ноля и больше 59. Принято значение по умолчанию " + min);
                }
            }
            get { return gradus; }
        }
        public int Sec
        {
            set
            {
                if (value > 0 && value < 59)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Количество секунд не может быть не может быть меньшн ноля и больше 59. Принято значение по умолчанию " + sec);
                }
            }
            get { return gradus; }
        }

        public void ToRadians()
        {
            double rad = Math.Round(((double)gradus + min / 60 + sec / 3600) / 180, 3);
            Console.WriteLine("В угле {0}°{1}'{2}\" {3} радиан(ы).", gradus, min, sec, rad);
            Console.ReadKey();
        }
    }
}
