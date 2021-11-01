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

        private void nuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alta_Carrera nuevo = new Frm_Alta_Carrera();
            nuevo.ShowDialog();
        }

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

      
    }
}