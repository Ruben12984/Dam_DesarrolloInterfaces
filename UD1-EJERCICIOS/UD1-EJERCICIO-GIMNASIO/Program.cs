using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJERCICIO_GIMNASIO
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();


            int opcion = 0;
            do
            {

                Console.WriteLine("1. Dar de alta cliente");
                Console.WriteLine("2. Mostrar clientes");
                Console.WriteLine("3. Modificar clientes");
                Console.WriteLine("4. Eliminar clientes");
                Console.WriteLine("5. Borrar todos los clientes (Administrador)");
                Console.WriteLine("6. Guardar clientes en un archivo JSON");
                Console.WriteLine("7. Cargar Clientes de un archivo JSON");
                Console.WriteLine("8. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n\nHas seleccionado la opción 1.");
                        AltaCliente(clientes);
                        break;
                    case 2:
                        Console.WriteLine("\n\nHas seleccionado la opción 2.");
                        MostrarClientes(clientes);
                        break;
                    case 3:
                        Console.WriteLine("\n\nHas seleccionado la opción 3.");
                        ModificarCliente(clientes);
                        break;
                    case 4:
                        Console.WriteLine("\n\nHas seleccionado la opción 4.");
                        ModificarCliente(clientes);
                        break;
                    case 5:
                        Console.WriteLine("\n\nHas seleccionado la opción 5.");
                        break;
                    case 6:
                        Console.WriteLine("\n\nHas seleccionado la opción 6.");
                        break;
                    case 7:
                        Console.WriteLine("\n\nHas seleccionado la opción 7.");
                        break;
                    case 8:
                        Console.WriteLine("\n\nSaliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }
                Console.WriteLine();

            } while (opcion != 8);
        }
        static void AltaCliente(List<Cliente> clientes)
        {
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            string apellidos = Console.ReadLine();
            Console.WriteLine("CodigoCliente: ");
            string codigoCliente = Console.ReadLine();
            clientes.Add(new Cliente(nombre, apellidos, codigoCliente));
            Console.WriteLine("cliente añadido correctamente");
        }
        static void MostrarClientes(List<Cliente> clientes)
        {
            foreach (var c in clientes)
            {
                Console.WriteLine(c);
            }
        }
        static void ModificarCliente(List<Cliente> clientes)
        {
            Console.WriteLine("Introduce el codigo del cliente que quieres modificar");
            string codigo = Console.ReadLine();

            if (clientes != null)
            {
                Console.WriteLine("Introduzca nuevo nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Introduzca nuevos apellidos: ");
                string apellidos = Console.ReadLine();

                clientes.Add();
            }
           
            else
            {
                Console.WriteLine("Cliente no encontrado");
            }
        }
    }
}
