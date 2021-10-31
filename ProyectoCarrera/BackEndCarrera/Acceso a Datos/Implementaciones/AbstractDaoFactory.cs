﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndCarrera.Acceso_a_Datos.Implementaciones
{
    abstract class AbstractDaoFactory
    {
        public abstract CarreraDao CrearCarreraDao();
    }
}