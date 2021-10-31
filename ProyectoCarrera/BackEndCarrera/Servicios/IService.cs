using BackEndCarrera.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndCarrera.Servicios
{
    public interface IService
    {
        Carrera BuscarCarreraPorId();
        List<Asignatura> ObtenerAsignatura();
        bool GuardarCarrera(Carrera oCarrera);
        bool GuardarAsignatura(Asignatura oAsignatura);
        bool EliminarCarrera(Carrera oCarrera);
        bool EliminarDetalle(List<int> lst);
        bool ActualizarCarrera(Carrera oCarrera);
        bool ActualizarAsignatura(Asignatura oAsignatura);
    }
}
