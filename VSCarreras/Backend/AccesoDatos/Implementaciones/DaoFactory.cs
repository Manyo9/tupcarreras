using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.AccesoDatos.Implementaciones
{
    class DaoFactory : AbstractDaoFactory
    {
        public override CarreraDao CrearCarreraDao()
        {
            return CarreraDao.GetInstancia();
        }
    }
}