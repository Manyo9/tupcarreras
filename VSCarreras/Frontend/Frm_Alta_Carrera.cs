using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Dominio;
using Frontend.Cliente;
using Newtonsoft.Json;


namespace Frontend
{
    public partial class Frm_Alta_Carrera : Form
    {
        private Accion modo;
        private Carrera oCarrera;
        private ClienteHttp cliente;
        public Frm_Alta_Carrera()
        {
            InitializeComponent();

        }
        public enum Accion
        {
            CREATE,
            READ,
            UPDATE,
            DELETE
        }
        private void Frm_Alta_Carrera_Load(object sender, EventArgs e)
        {
            modo = Accion.READ;
            habilitar(false);
            CargarComboAsync();
        }
        private void limpiar()
        {
           
            txtNombre.Text = "";
            txtTitulo.Text = "";
            numAnioCursado.Text= "";
            nudCantidadAnios.Text="";
            rbtnAnual.Checked = false;
            rbtnPrimero.Checked = false;
            rbtnSegundo.Checked = false;
            cboMateria.SelectedIndex = -1;

        }
      
        private void habilitar(bool x)
        {
            numAnioCursado.Enabled = x;
            nudCantidadAnios.Enabled = x;
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
           modo = Accion.CREATE; 
           limpiar();         
           habilitar(true);
           txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modo = Accion.READ;
            limpiar();
            habilitar(false);
            txtNombre.Focus();
        }
    

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modo = Accion.UPDATE;
            habilitar(true);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            modo = Accion.DELETE;
            habilitar(true);
            //if (MessageBox.Show("Se borrará permanentemente , desea seguir?",
            //              "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            //              MessageBoxDefaultButton.Button2) == DialogResult.Yes) ;
                
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();

            }
            else
            {
                return;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(modo.Equals(Accion.CREATE) || modo.Equals(Accion.UPDATE)|| modo.Equals(Accion.DELETE))
            {
                if (DgvMateria.Rows.Count == 0)
                {
                    MessageBox.Show("Debe ingresar al menos una materia en el plan", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboMateria.Focus();
                    return;
                }
                if (txtNombre.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un Nombre de carrera", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }
                if (txtTitulo.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un Titulo de egresado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }
                if(nudCantidadAnios.Value<=0 || nudCantidadAnios.Value>=100)
                {
                    MessageBox.Show("Debe ingresar un numero entre 1 y 99", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudCantidadAnios.Focus();
                    return;
                }
                if (modo.Equals(Accion.CREATE))
                {
                    GuardarCarrera();
                    limpiar();
                }
                else if (modo.Equals(Accion.UPDATE))
                {
                    EditarCarrera();
                    limpiar();
                }
                else if (modo.Equals(Accion.DELETE))
                {
                    if (MessageBox.Show("Se borrará permanentemente , desea seguir?",
                                  "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                        BorrarCarrera();
                        limpiar();
                    }                
                }
            }
        }
        public void GuardarCarrera()
        {
            Carrera oCarrera = new Carrera();
            oCarrera.Nombre = txtNombre.Text.ToString();
            oCarrera.Titulo = txtTitulo.Text.ToString();
            oCarrera.AnioMaximo = Convert.ToInt32(nudCantidadAnios.Value);
        }
        public void EditarCarrera()
        {
            Carrera oCarrera = new Carrera();
            oCarrera.Nombre = txtNombre.Text.ToString();
            oCarrera.Titulo = txtTitulo.Text.ToString();
            oCarrera.AnioMaximo = Convert.ToInt32(nudCantidadAnios.Value);
        }

        public void BorrarCarrera()
        {
            // primera row de la listbox
        }
        public async Task CargarComboAsync()
        {
            string url = "https://localhost:44361/api/asignaturas/";
            var resultado = await ClienteHttp.GetInstancia().GetAsync(url);
            List<Asignatura> materias = new List<Asignatura>();
            materias = JsonConvert.DeserializeObject<List<Asignatura>>(resultado);
            cboMateria.DataSource = materias;
            cboMateria.DisplayMember = "Nombre";
            cboMateria.ValueMember = "IdAsignatura";
            
        }

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
