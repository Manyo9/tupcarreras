using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frontend.Cliente;
using Backend.Dominio;
using Newtonsoft.Json;

namespace Frontend
{
    public partial class Frm_Materia : Form
    {
        private ClienteHttp cliente;
        private Accion modo;
        List<Asignatura> materias = new List<Asignatura>();
        public Frm_Materia()
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

        private void Frm_Materia_Load(object sender, EventArgs e)
        {
            modo = Accion.READ;
            habilitar(false);
            CargarFormAsync();
        }

        private void cboMateriasCargadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   .Text= cboMateriasCargadas.SelectedValue.ToString();  //aca muestra el id del objeto seleccionado en el combo 
            //txtNombreMateria ???
        }
        private void limpiar()
        {
            txtNombreMateria.Text = "";
        }

        private void habilitar(bool x)
        {

            txtNombreMateria.Enabled = x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = x;
            lstMaterias.Enabled = !x;
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            txtNombreMateria.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(true);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se borrará la materia, desea seguir?",
                         "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                         MessageBoxDefaultButton.Button2) == DialogResult.Yes) ;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public async Task CargarComboAsync()
        {
            string url = "https://localhost:44361/api/Carrera/asignaturas";
            var resultado = await ClienteHttp.GetInstancia().GetAsync(url);
            materias = JsonConvert.DeserializeObject<List<Asignatura>>(resultado);
            lstMaterias.DataSource = materias;
            lstMaterias.DisplayMember = "Nombre";
            lstMaterias.ValueMember = "IdAsignatura";
        }
        public async Task CargarFormAsync()
        {
            await CargarComboAsync();
            CargarCampo();
        }
        public void CargarCampo()
        {
            txtNombreMateria.Text = materias[lstMaterias.SelectedIndex].Nombre;
        }

        private void lstMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCampo();
        }

        //private void btnRefrescar_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(materias.ToString());
        //    CargarCampo();
        //}
    }
}
