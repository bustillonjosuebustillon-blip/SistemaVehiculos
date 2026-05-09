using System;

namespace SistemaVehiculos
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }

        public bool TieneMaletero { get; set; }

        public override void MostrarInformacion()
        {
            Console.WriteLine("----- MOTO -----");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Año);
            Console.WriteLine("Cilindrada: " + Cilindrada + " cc");

            if (TieneMaletero)
            {
                Console.WriteLine("Tiene Maletero: Si");
            }
            else
            {
                Console.WriteLine("Tiene Maletero: No");
            }

            Console.WriteLine();
        }
    }
}
