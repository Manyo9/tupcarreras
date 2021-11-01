using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Dominio;

namespace Backend.Servicios
{
    public interface IService
    {
        public Carrera BuscarCarreraPorId(int id);
        public List<Carrera> ObtenerCarreras();
        public List<Asignatura> ObtenerAsignaturas();
        public bool GuardarCarrera(Carrera oCarrera);
        public bool GuardarAsignatura(Asignatura oAsignatura);
        public bool EliminarCarrera(int id);
        public bool EliminarDetalle(List<int> lst);
        public bool EliminarAsignatura(int id);
        public bool ActualizarCarrera(Carrera oCarrera);
        public bool ActualizarAsignatura(Asignatura oAsignatura);
        public bool IniciarSesion(string user, string password);
    }
}
