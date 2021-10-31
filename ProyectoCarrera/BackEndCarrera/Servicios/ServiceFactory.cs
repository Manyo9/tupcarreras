using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndCarrera.Servicios
{
    public class ServiceFactory : AbstractServiceFactory
    {
        public override IService CrearService()
        {
            return new CarreraService();
        }
    }
}
