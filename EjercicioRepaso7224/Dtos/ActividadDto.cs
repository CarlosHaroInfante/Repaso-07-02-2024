using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso7224.Dtos
{
    internal class ActividadDto
    {
        long idActividad;

        string nombre = "aaaaa";

        DateTime fechaInicio;

        DateTime fechaFin;

        int min;

        public ActividadDto()
        {
        }

        public ActividadDto(long idActividad, string nombre, DateTime fechaInicio, DateTime fechaFin, int min)
        {
            this.idActividad = idActividad;
            this.nombre = nombre;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.min = min;
        }

        public long IdActividad { get => idActividad; set => idActividad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public int Min { get => min; set => min = value; }

        override
            public string ToString()
        {

            string act = "idActividad " + this.idActividad +
                " Nombre " + this.nombre +
                " FechaDeInicio " + this.fechaInicio +
                " FechaDeFin " + this.fechaFin +
                " Minutos " + this.min;

            return act;
        }
    }
}
