using EjercicioRepaso7224.Dtos;
using EjercicioRepaso7224.Servicios;

namespace EjercicioRepaso7224.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {

            MenuInterfaz menu = new MenuImplementacion();
            List<ActividadDto> actividad = new List<ActividadDto>();
            LogicaInterfaz log = new LogicaImplementacion();

            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                int opcion = menu.menu();

                switch (opcion)
                {

                    case 0:
                        Console.WriteLine("Se cerrará el menú");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("Se añadirá una nueva actividad");
                        log.altaActividad(actividad);
                        break;

                    case 2:
                        Console.WriteLine("Se eliminará una actividad");
                        log.eliminaActividad(actividad);
                        break;

                    case 3:
                        Console.WriteLine("Se mostrará una actividad");
                        foreach(ActividadDto activ in actividad)
                        {
                            Console.WriteLine(activ.ToString());
                        }
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;

                }



            }
            
                

            


        }


    }


}
