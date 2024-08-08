using System;
namespace Tarea_3
{
	internal class Moto : Vehiculos
	{
        protected string TipoDeMoto;

        public Moto(int Año, String Marca, int Kilometraje, String TipoDeMoto, string Modelo)
        {
            this.Año = Año;
            this.Marca = Marca;
            this.Kilometraje = Kilometraje;
            this.Modelo = Modelo;
            this.TipoDeMoto = TipoDeMoto;

        }
    }
}

