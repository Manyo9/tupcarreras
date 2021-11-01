using BackEndCarrera.Acceso_a_Datos.Implementaciones;
using BackEndCarrera.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndCarrera.Servicios
{
    class CarreraService : IService
    {
        private CarreraDao dao;

        public CarreraService()
        {
            dao = new DaoFactory().CrearCarreraDao();
        }

        public bool ActualizarAsignatura(Asignatura oAsignatura)
        {
            return dao.UpdateAsignatura(oAsignatura);
        }

        public bool ActualizarCarrera(Carrera oCarrera)
        {
            return dao.UpdateCarreras(oCarrera);
        }

        public Carrera BuscarCarreraPorId(int id)
        {
            return dao.GetCarrerasById(id);
        }

        public bool EliminarCarrera(int id)
        {
            return dao.DeleteCarreras(id);
        }

        public bool EliminarDetalle(List<int> lst)
        {
            return dao.DeleteDetalle(lst);
        }

        public bool GuardarAsignatura(Asignatura oAsignatura)
        {
            return dao.SaveAsignatura(oAsignatura);
        }

        public bool GuardarCarrera(Carrera oCarrera)
        {
            return dao.SaveCarrera(oCarrera);
        }

        public List<Asignatura> ObtenerAsignaturas()
        {
            return dao.GetAsignaturas();
        }
        public List<Carrera> ObtenerCarreras()
        {
            return dao.GetCarreras();
        }
        public bool EliminarAsignatura(int id)
        {
            return dao.DeleteAsignatura(id);
        }
    }
}
