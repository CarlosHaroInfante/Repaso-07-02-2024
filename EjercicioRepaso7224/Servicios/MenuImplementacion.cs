using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso7224.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menu()
        {

            Console.WriteLine("Menú de Actividades");
            Console.WriteLine("-------------------");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Ingresa una nueva actividad");
            Console.WriteLine("[2] - Eliminar actividad");
            Console.WriteLine("[3] - Mostrar actividad");
            Console.WriteLine("-------------------");

            int op = Convert.ToInt32(Console.ReadLine());   

            return op;


        }
    }
}
