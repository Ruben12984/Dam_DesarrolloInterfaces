using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJERCICIOS
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Casa del terror de la feria de cordoba");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Escribe la edad del visitante");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la altura (en centimetros) del visitante");
            int altura = int.Parse(Console.ReadLine());

            CasaDelTerror casa1= new CasaDelTerror("Casa del terror", 5.5 , 14, 130, 8);
            casa1.AdmitirVisitante(edad, altura);

            Console.WriteLine("Pulse una tecla para finalizar");
            Console.ReadKey();


        }
    }
}
