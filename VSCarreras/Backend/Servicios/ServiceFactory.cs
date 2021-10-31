using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Servicios
{
    public class ServiceFactory : AbstractServiceFactory
    {
        public override IService CrearService()
        {
            return new CarreraService();
        }
    }
}