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
    public partial class Frm_Alta_Carrera : Form
    {
        public Frm_Alta_Carrera()
        {
            InitializeComponent();
        }

        private void Frm_Alta_Carrera_Load(object sender, EventArgs e)
        {
            habilitar(false);
        }
        private void limpiar()
        {
           
            txtNombre.Text = "";
            txtTitulo.Text = "";
            numAnioCursado.Text= "";
            numCantidadAnios.Text="";
            rbtnAnual.Checked = false;
            rbtnPrimero.Checked = false;
            rbtnSegundo.Checked = false;
            cboMateria.SelectedIndex = -1;

                    }
      
        private void habilitar(bool x)
        {
            numAnioCursado.Enabled = x;
            numCantidadAnios.Enabled = x;
            txtNombre.Enabled = x;
            txtTitulo.Enabled = x;
            cboMateria.Enabled = x;
            rbtnAnual.Enabled = x;
            rbtnPrimero.Enabled = x;
            rbtnSegundo.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            lstCarrera.Enabled = !x;
            DgvMateria.Enabled = !x;
            btnMateria.Enabled = x;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
         
            habilitar(true);
           txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            limpiar();

        }




        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se borrará permanentemente , desea seguir?",
                          "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button2) == DialogResult.Yes) ;
                
        }

        private void DgvMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
