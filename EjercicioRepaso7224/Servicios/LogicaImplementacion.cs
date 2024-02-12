using EjercicioRepaso7224.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso7224.Servicios
{
    internal class LogicaImplementacion : LogicaInterfaz
    {
        public void altaActividad(List<ActividadDto> listaAntigua)
        {
            ActividadDto newA = alta();
            listaAntigua.Add(newA);

        }

        private ActividadDto alta()
        {

            ActividadDto newA = new ActividadDto();

            Console.WriteLine("Añade una nueva activadad");


            Console.WriteLine("ID de la actividad: ");
            newA.IdActividad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nombre de la actividad: ");
            newA.Nombre = Console.ReadLine();

            Console.WriteLine("Fecha de inicio de la actividad: ");
            newA.FechaInicio = Convert.ToDateTime(Console.ReadLine());

            
            newA.FechaFin = DateTime.Now;

            Console.WriteLine("Minutos de la actividad: ");
            int anyo = newA.FechaInicio.Year - newA.FechaFin.Year;
            anyo = Math.Abs(anyo);
            Console.WriteLine(anyo);
            int mes = newA.FechaInicio.Month - newA.FechaFin.Month;
            Math.Abs(mes);
            Console.WriteLine(mes);
            int day = newA.FechaInicio.Day - newA.FechaFin.Day;
            Math.Abs(day); 
            Console.WriteLine(day);
            int horas = newA.FechaInicio.Hour - newA.FechaFin.Hour;
            horas = Math.Abs(horas);
            Console.WriteLine(horas);
            int min = newA.FechaInicio.Minute - newA.FechaFin.Minute;        
            min = Math.Abs(min);
            Console.WriteLine(min);
            int seg = newA.FechaInicio.Second - newA.FechaFin.Second;
            seg = Math.Abs(seg);
            Console.WriteLine(seg);


            // Anios a Meses
            int aniosMeses = anyo * 12;
            mes = mes + aniosMeses;

            // Meses a Dias
            int mesesDias = mes * 30;
            day = day + mesesDias;

            // Dias a Horas
            int HorasDias = day * 24;
            horas = horas + HorasDias;

            // Horas a Min

            int MinHoras = horas * 60;
            min = min + MinHoras;

            newA.Min = min;
            Console.WriteLine(min);
            return newA;
        }

        public void eliminaActividad(List<ActividadDto> listaAntigua)
        {
            Console.WriteLine("Eliminar una actividad");
            

            Console.WriteLine("Dame el nombre de la actividad");
            string nom = Console.ReadLine();

           

            bool siCoincide = false;
            foreach (ActividadDto activ in listaAntigua) {
                if (activ.Nombre.Equals(nom))
                {
                   siCoincide = true;
                    Console.WriteLine(siCoincide);
                    listaAntigua.Remove(activ);
                    Console.WriteLine("La lista se ha borrado");
                    break;
                    
                }
                
                else
                {
                    Console.WriteLine("El nombre no coincide con ningún nombre de actividad activa");
                }

               
            }
            

        }
    }
}
