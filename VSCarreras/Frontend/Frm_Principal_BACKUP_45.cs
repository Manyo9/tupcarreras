using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void gestionarCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
=======
        private void nuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
>>>>>>> 01a087b025d56cefb6418898387d51798e850c08
        {
            Frm_Alta_Carrera nuevo = new Frm_Alta_Carrera();
            nuevo.ShowDialog();
        }
<<<<<<< HEAD
=======

        private void nuevaMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Materia nuevo = new Frm_Materia();
            nuevo.ShowDialog();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reporte nuevo = new Frm_Reporte();
            nuevo.ShowDialog();
        }

        
>>>>>>> 01a087b025d56cefb6418898387d51798e850c08
    }
}
