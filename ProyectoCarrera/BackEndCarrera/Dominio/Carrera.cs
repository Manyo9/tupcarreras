using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndCarrera.Dominio
{
    public class Carrera
    {
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public int AnioMaximo { get; set; }
        public int IdCarrera { get; set; }
        public List<DetalleCarrera> Detalles { get; set; }
        public Carrera()
        {
            Detalles = new List<DetalleCarrera>();
        }
    }
}
