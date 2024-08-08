using System;
namespace Tarea_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Auto Camioneta = new Auto(2020, "Toyota", 0, "Land Crusier Prado", "4 Puertas");

            Console.WriteLine(Camioneta.encendido);
            Console.WriteLine(Camioneta.apagado);
            Console.WriteLine(Camioneta.conducir);

            Moto Ducati = new Moto(2024, "Ducati", 100, "MY21", "Deportiva");

            Console.WriteLine(Ducati.encendido);
            Console.WriteLine(Ducati.apagado);
            Console.WriteLine(Ducati.conducir);

            Camion Traviz = new Camion(2019, "Izuzu", 0, "Traviz", "2.5T");

            Console.WriteLine(Traviz.encendido);
            Console.WriteLine(Traviz.apagado);
            Console.WriteLine(Traviz.conducir);
        }
    }
}
