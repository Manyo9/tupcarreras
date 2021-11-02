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
        public Asignatura Materia { get; set; }
        public int IdDetalle { get; set; }

        public DetalleCarrera()
        {
            Materia = new Asignatura();
        }
        public DetalleCarrera(int anioDeCursado, string cuatrimestre, Asignatura materia)
        {
            AnioDeCursado = anioDeCursado;
            Cuatrimestre = cuatrimestre;
            Materia = materia;
        }
        public override string ToString()
        {
            return ("Año de cursado"+AnioDeCursado.ToString()+ " Cuatrimestre "+Cuatrimestre+" Materia "+Materia.Nombre+" IdDetalle "+IdDetalle.ToString());
        }
    }
}