using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJERCICIOS
{
    internal class CasaDelTerror : Atracción
    {
        private int _nivelMiedo;
        public int NivelMiedo 
        {
            get => _nivelMiedo; 
            set
            {
                if (value > 10)
                {
                    Console.WriteLine("El nivel de miedo tiene que ser entre 1 y 10");
                }
            } 
        }
        public CasaDelTerror(string nombre, double precio, int edadMinima, int alturaMinima, int nivelMiedo) : base(nombre, precio, edadMinima, alturaMinima)
        {
            NivelMiedo = nivelMiedo;
        }

        public override bool AdmitirVisitante(int edad, int altura)
        {
            if (edad >= EdadMinima && altura >= AlturaMinima)
            {
                Console.WriteLine($"Casa del terror: ¡preparate para un nivel de nivel {NivelMiedo}!");
                Console.WriteLine("El visitante puede disfrutar la atraccion perfectamente");
                return true;
            }
            else 
            {
                Console.WriteLine("El visitante no cumple los requisitos, tiene que ser mayor a 14 años y medir mas de 130 cm");
                return false; 
            }
        }
    }
}
