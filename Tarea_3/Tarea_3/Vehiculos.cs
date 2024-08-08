using System;
namespace Tarea_3
{
	internal class Vehiculos
	{
		public int Kilometraje;

		public string Marca;

		public string Modelo;

		public int Año;

		public void encendido()
		{
			Console.WriteLine("El Vehiculo esta encendido");
		}
		public void apagado()
		{
			Console.WriteLine("El vehiculo esta apagado");
		}
		public void conducir()
		{
			Console.WriteLine($"El vehiculo viaja a {Kilometraje}");
		}
	}
}

