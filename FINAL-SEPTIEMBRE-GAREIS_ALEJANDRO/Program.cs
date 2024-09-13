using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_SEPTIEMBRE_GAREIS_ALEJANDRO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogicaPrincipal logica = new LogicaPrincipal();
            while (true)
            {
                Console.WriteLine("1. Crear Mascota");
                Console.WriteLine("2. Eliminar Mascota");
                Console.WriteLine("3. Listar Mascotas");
                Console.WriteLine("4. Salir");

                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        logica.CrearMascota();
                        break;
                    case "2":
                        logica.EliminarMascota();
                        break;
                    case "3":
                        logica.ListarMascotas();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}