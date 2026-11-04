using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJERCICIOS
{
    internal class Atracción
    {
        public string Nombre { get; set; }
        public int EdadMinima { get; set; }
        
        public int AlturaMinima { get; set; }
             
        public double Precio { get; set; }

        //constructor
        public Atracción(string nombre, double precio, int edadMinima, int alturaMinima)
        {
            Nombre = nombre;
            Precio = precio;
            EdadMinima = edadMinima;
            AlturaMinima = alturaMinima;

        }

        //metodo
        
        public virtual bool AdmitirVisitante(int edad, int altura)
        {
            if (edad > EdadMinima && altura > AlturaMinima)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}
