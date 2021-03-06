using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Dominio;

namespace Backend.AccesoDatos.Interfaces
{
    public interface ICarreraDao
    {
        Carrera GetCarrerasById(int id);
        List<Carrera> GetCarreras();
        List<Asignatura> GetAsignaturas();
        bool SaveCarrera(Carrera oCarrera);
        bool SaveAsignatura(Asignatura oAsignatura);
        bool SaveDatalle(DetalleCarrera oDetalle);
        bool DeleteCarreras(int id);
        bool DeleteDetalle(int id);
        bool DeleteAsignatura(int id);
        bool UpdateCarreras(Carrera oCarrera);
        bool UpdateAsignatura(Asignatura oAsignatura);
        bool LoginIn(Credenciales oCredenciales);
    }
}
