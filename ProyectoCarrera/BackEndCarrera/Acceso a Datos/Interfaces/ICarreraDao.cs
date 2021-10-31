using BackEndCarrera.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndCarrera.Acceso_a_Datos.Interfaces
{
    public interface ICarreraDao
    {
        Carrera GetCarrerasById();
        List<Asignatura> GetAsignatura();
        bool SaveCarrera(Carrera oCarrera);
        bool SaveAsignatura(Asignatura oAsignatura);    
        bool DeleteCarreras(Carrera oCarrera);
        bool DeleteDetalle(List<int> lst);
        bool UpdateCarreras(Carrera oCarrera);
        bool UpdateAsignatura(Asignatura oAsignatura);
    }
}
