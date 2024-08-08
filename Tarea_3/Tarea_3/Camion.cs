using System;
namespace Tarea_3
{
	internal class Camion : Vehiculos
	{
		protected string CapacidadDeCarga;
		public Camion(int Año, String Marca, int Kilometraje, String Modelo, string CapacidadDeCarga)
		{
            this.Año = Año;
            this.Marca = Marca;
            this.Kilometraje = Kilometraje;
            this.Modelo = Modelo;
			this.CapacidadDeCarga = CapacidadDeCarga;
        }
	}
}

