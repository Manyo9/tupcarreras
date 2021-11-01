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
        bool DeleteCarreras(int id);
        bool DeleteDetalle(List<int> lst);
        bool DeleteAsignatura(int id);
        bool UpdateCarreras(Carrera oCarrera);
        bool UpdateAsignatura(Asignatura oAsignatura);
        bool LoginIn(string user,string password);
    }
}
