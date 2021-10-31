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
        bool Save(Carrera oCarrera);
        List<Asignatura> GetAsignatura();
        bool UpdateCarreras(Carrera oCarrera);        
        bool DeleteCarreras(Carrera oCarrera);
        bool DeleteDetalle(List<int> lst);
    }
}
