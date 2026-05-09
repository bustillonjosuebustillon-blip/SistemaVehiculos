using System;
namespace SistemaVehiculos

{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro
            {
                Marca = "Toyota",
                Modelo = "Corolla",
                Año = 2020,
                NumeroPuertas = 4,
                TipoCombustible = "Gasolina"
            };
            Carro carro2 = new Carro
            {
                Marca = "Honda",
                Modelo = "Civic",
                Año = 2019,
                NumeroPuertas = 4,
                TipoCombustible = "Electrico"
            };
            Moto moto1 = new Moto
            {
                Marca = "Honda",
                Modelo = "CBR",
                Año = 2021,
                Cilindrada = 250,
                TieneMaletero = false
            };
            Moto moto2 = new Moto
            {
                Marca = "Yamaha",
                Modelo = "XTZ",
                Año = 2022,
                Cilindrada = 150,
                TieneMaletero = true
            };

            carro1.MostrarInformacion();
            carro2.MostrarInformacion();
            moto1.MostrarInformacion();
            moto2.MostrarInformacion();
            Console.ReadKey();
            
        }
    }

}