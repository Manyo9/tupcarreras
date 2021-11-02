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
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        ///
        /// para mover el form con el mouse
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

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
            btnAgregar.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            lstMaterias.Enabled = !x;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = Accion.CREATE;
            limpiar();
            habilitar(true);
            txtNombreMateria.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modo = Accion.UPDATE;
            habilitar(true);
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se borrará la materia, desea seguir?",
                         "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                         MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string resultado = await BorrarMateria(((Asignatura)(lstMaterias.SelectedItem)).IdAsignatura);
            }

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
            txtNombreMateria.Text = ((Asignatura)(lstMaterias.SelectedItem)).Nombre;
        }

        private void lstMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCampo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modo = Accion.READ;
            habilitar(false);
            txtNombreMateria.Focus();
        }

        public async Task<string> BorrarMateria(int n)
        {
            string url = "https://localhost:44361/api/Carrera/asignaturas/"+ n.ToString();
            var resultado = await ClienteHttp.GetInstancia().DeleteAsync(url);
            return resultado;
        }

    }
}
