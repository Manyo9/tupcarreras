using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Dominio
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
            IdCarrera = 0;
            Detalles = new List<DetalleCarrera>();
        }
        public void AgregarDetalle(DetalleCarrera detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int nro)
        {
            Detalles.RemoveAt(nro);
        }

        public override string ToString()
        {
            return ("Nombre: "+Nombre+" Titulo: "+Titulo+" Año máximo: "+
                AnioMaximo+" Id Carrera: "+IdCarrera.ToString()+" Detalles: "+Detalles.Count);
        }

    }
}
