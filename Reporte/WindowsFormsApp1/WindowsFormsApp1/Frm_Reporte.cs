using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_Reporte : Form
    {
        public Frm_Reporte()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSListado.Repo_Carrera' Puede moverla o quitarla según sea necesario.
            this.Repo_CarreraTableAdapter.Fill(this.DSListado.Repo_Carrera);

            this.reportViewer1.RefreshReport();
        }
    }
}
