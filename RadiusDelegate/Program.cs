using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusDelegate
{
    delegate double CalculateDelegate(double radius);
    class Program
    {
        static void Main(string[] args)
        {
            CalculateDelegate circumferenceDelegate = CalculateCircumference;
            CalculateDelegate areaDelegate = CalculateArea;
            CalculateDelegate volumeDeleagte = CalculateVolume;
            Console.WriteLine("Введите радиус:");
            double radius = Convert.ToInt32(Console.ReadLine());
            double circumference = circumferenceDelegate(radius);
            double area = areaDelegate(radius);
            double volume = volumeDeleagte(radius);

            Console.WriteLine($"Длина окружности: {circumference}");
            Console.WriteLine($"Площадь круга: {area}");
            Console.WriteLine($"Объем шара: {volume}");
            Console.ReadKey();

        }
        static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        static double CalculateVolume(double radius)
        {
            return (4 / 3) * Math.PI * Math.Pow(radius, 3);
        }

    }
}
