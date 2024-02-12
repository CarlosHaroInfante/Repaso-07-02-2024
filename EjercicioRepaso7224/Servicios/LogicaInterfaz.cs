using EjercicioRepaso7224.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso7224.Servicios
{
    internal interface LogicaInterfaz
    {
        public void altaActividad(List<ActividadDto> listaAntigua);

        public void eliminaActividad(List<ActividadDto> listaAntigua);
    }
}
