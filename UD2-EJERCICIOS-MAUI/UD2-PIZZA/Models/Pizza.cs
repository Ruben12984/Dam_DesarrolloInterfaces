using System;
using System.Collections.Generic;
using System.Text;

namespace UD2_PIZZA.Models
{
    internal class Pizza
    {
        // --- Singleton ---
        private static Pizza _instancia;

        // Constructor privado: nadie puede hacer "new Pizza()" desde fuera
        private Pizza() { }

        // Punto de acceso único
        public static Pizza Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Pizza();
                return _instancia;
            }
        }


        public string Tipo { get; set; }
        public int Cantidad { get; set; }

        public bool QuesoExtra { get; set; }
        public bool Jamon { get; set; }
        public bool Champinones { get; set; }
        public bool Aceitunas { get; set; }
        public bool Pimientos { get; set; }


        public string Resumen
        {
            get
            {
                string extras = "";
                if (QuesoExtra) extras += "Queso extra, ";
                if (Jamon) extras += "Jamón, ";
                if (Champinones) extras += "Champiñones, ";
                if (Aceitunas) extras += "Aceitunas, ";
                if (Pimientos) extras += "Pimientos, ";

                if (extras == "") extras = "Ninguno";
                else extras = extras.TrimEnd(',', ' ');   // quita la última ", "

                return $"Pizza: {Tipo}\nCantidad: {Cantidad}\nIngredientes extra: {extras}";
            }
        }

        public void Reiniciar()
        {
            Tipo = string.Empty;
            Cantidad = 1;
            QuesoExtra = false;
            Jamon = false;
            Champinones = false;
            Aceitunas = false;
            Pimientos = false;
        }
    }
}
