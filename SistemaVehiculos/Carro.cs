using System;

namespace SistemaVehiculos
{
    public class Carro : Vehiculo
    {
        public int NumeroPuertas { get; set; }

        public string TipoCombustible { get; set; } = "";

        public override void MostrarInformacion()
        {
            Console.WriteLine("----- CARRO -----");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Año);
            Console.WriteLine("Número de Puertas: " + NumeroPuertas);
            Console.WriteLine("Tipo de Combustible: " + TipoCombustible);
            Console.WriteLine();
        }
    }
}