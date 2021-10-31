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
        Carrera BuscarCarreraPorId(int id);
        List<Carrera> ObtenerCarreras();
        List<Asignatura> ObtenerAsignaturas();
        bool GuardarCarrera(Carrera oCarrera);
        bool GuardarAsignatura(Asignatura oAsignatura);
        bool EliminarCarrera(int id);
        bool EliminarDetalle(List<int> lst);
        bool EliminarAsignatura(int id);
        bool ActualizarCarrera(Carrera oCarrera);
        bool ActualizarAsignatura(Asignatura oAsignatura);
    }
}
