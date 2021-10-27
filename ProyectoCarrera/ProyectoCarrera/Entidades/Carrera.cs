using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCarrera.Entidades
{
    class Carrera
    {
        public string NombreTitulo { get; set; }
        public List<DetalleCarrera> Detalles { get; set; }

        public Carrera()
        {

        }

    }
}
