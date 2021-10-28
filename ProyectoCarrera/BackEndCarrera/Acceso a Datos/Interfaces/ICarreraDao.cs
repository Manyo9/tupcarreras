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
        List<DetalleCarrera> GetCarreras();
        bool Save(Carrera oCarrera);
    }
}
