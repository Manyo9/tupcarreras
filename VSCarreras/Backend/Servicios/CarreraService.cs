using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Dominio;
using Backend.AccesoDatos.Implementaciones;

namespace Backend.Servicios
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

        public bool EliminarDetalle(int id)
        {
            return dao.DeleteDetalle(id);
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
        public bool IniciarSesion(Credenciales oCredenciales)
        {
            return dao.LoginIn(oCredenciales);
        }

        public bool GuardarDetalle(DetalleCarrera oDetalle)
        {
            return dao.SaveDatalle(oDetalle);
        }
    }
}

