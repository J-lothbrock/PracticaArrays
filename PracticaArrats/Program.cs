using System;
using System.Threading;

namespace PracticaArrats
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sueldos = new double[4];

            Console.WriteLine("Como te llamas?");
            string nombre = Console.ReadLine();

            Console.WriteLine("Introduce el primer sueldo");
            sueldos[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo sueldo");
            sueldos[1] = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer sueldo");
            sueldos[2] = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el cuarto sueldo");
            sueldos[3] = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Espere, estamos sumando sus sueldo");     
            Thread.Sleep(2000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            double total = (sueldos[0] + sueldos[1] + sueldos[2] + sueldos[3]);
            Console.ResetColor();

            Console.WriteLine(nombre + "el total de tu sueldo es " + total);
            
        }
    }
}
