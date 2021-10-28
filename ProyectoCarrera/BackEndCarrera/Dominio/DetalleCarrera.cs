using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndCarrera.Dominio
{
    public class DetalleCarrera
    {
        public int AnioDeCursado { get; set; }
        public string Cuatrimestre { get; set; }

        public Asignatura Materia { get; set; }
        public DetalleCarrera()
        {

        }
    }
}
