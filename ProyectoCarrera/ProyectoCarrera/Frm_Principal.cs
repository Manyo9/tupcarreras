using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCarrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alta_Carrera nuevo = new Frm_Alta_Carrera();
                nuevo.ShowDialog();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Reporte nuevo = new frm_Reporte();
            nuevo.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aBMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Materia nuevo = new Frm_Materia();
            nuevo.ShowDialog();
        }
    }
}
