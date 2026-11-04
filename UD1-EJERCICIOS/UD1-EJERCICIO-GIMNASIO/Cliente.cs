using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJERCICIO_GIMNASIO
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string CodigoCliente { get; set; }


        public Cliente(string nombre, string apellidos, string codigoCliente)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            CodigoCliente = codigoCliente;
        }
        public override string ToString()
        {
            return $"codigo: {CodigoCliente}, " +
                   $"Nombre: {Nombre}, " +
                   $"Apellidos: {Apellidos}";
        }
    }
}
