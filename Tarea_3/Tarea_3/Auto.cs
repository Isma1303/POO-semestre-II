using System;
namespace Tarea_3
{
	
	internal class Auto : Vehiculos
	{
        private string NumeroDePuertas;

        public Auto(int Año, String Marca, int Kilometraje, String Modelo, string NumeroDePuertas)
		{
			this.Año = Año;
			this.Marca = Marca;
			this.Kilometraje = Kilometraje;
			this.Modelo = Modelo;
			this.NumeroDePuertas = NumeroDePuertas;

		}
		
	}
}

