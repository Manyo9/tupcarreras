using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Dominio
{
    public class DetalleCarrera
    {
        public int AnioDeCursado { get; set; }
        public string Cuatrimestre { get; set; }
        public int IdDetalle { get; set; }
        public Asignatura Materia { get; set; }
        public DetalleCarrera()
        {
            Materia = new Asignatura();
            Materia.IdAsignatura = 0;
            Materia.Nombre = "";
        }
    }
}