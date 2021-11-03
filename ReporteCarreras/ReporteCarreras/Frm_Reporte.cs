using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteCarreras
{
    public partial class Frm_Reporte : Form
    {
        public Frm_Reporte()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSListado.DTListado' Puede moverla o quitarla según sea necesario.
            this.DTListadoTableAdapter.Fill(this.DSListado.DTListado);

            this.reportViewer1.RefreshReport();
        }
    }
}
