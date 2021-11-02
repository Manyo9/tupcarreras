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

        private Accion modo;

        List<Asignatura> materias = new List<Asignatura>();
        Asignatura oMateria = new Asignatura();
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
            modo = Accion.DELETE;
            habilitar(true);
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
        }
        public void CargarCampo()
        {
            txtNombreMateria.Text = oMateria.Nombre;
        }

        private void lstMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            oMateria.Nombre = ((Asignatura)(lstMaterias.SelectedItem)).Nombre;
            oMateria.IdAsignatura = ((Asignatura)(lstMaterias.SelectedItem)).IdAsignatura;
            CargarCampo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modo = Accion.READ;
            habilitar(false);
            limpiar();
            txtNombreMateria.Focus();
        }

        public async Task<string> BorrarMateria(int n)
        {
            string url = "https://localhost:44361/api/Carrera/asignaturas/"+ n.ToString();
            var resultado = await ClienteHttp.GetInstancia().DeleteAsync(url);
            return resultado;
        }
        public async Task<string> GuardarMateriaAsync(Asignatura asignatura)
        {
            string url = "https://localhost:44361/api/Carrera/asignaturas/";
            string datos = JsonConvert.SerializeObject(asignatura);
            var resultado = await ClienteHttp.GetInstancia().PostAsync(url, datos);
            return resultado;
        }
        public async Task<string> EditarMateriaAsync(int n)
        {
            string url = "https://localhost:44361/api/Carrera/asignaturas/" + n.ToString();
            string datos = JsonConvert.SerializeObject(oMateria);
            var resultado = await ClienteHttp.GetInstancia().PostAsync(url,datos);
            return resultado;
        }

        private async void btnAplicar_Click(object sender, EventArgs e)
        {
            if (modo.Equals(Accion.CREATE) || modo.Equals(Accion.UPDATE))
            {
                if (txtNombreMateria.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un nombre de materia", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreMateria.Focus();
                    return;
                }
                if (modo.Equals(Accion.CREATE))
                {
                    oMateria.Nombre = txtNombreMateria.Text;
                    await GuardarMateriaAsync(oMateria);
                    limpiar();
                    await CargarComboAsync();
                    habilitar(false);

                }
                else if (modo.Equals(Accion.UPDATE))
                {
                    oMateria.Nombre = txtNombreMateria.Text;
                    await EditarMateriaAsync(oMateria.IdAsignatura);
                    limpiar();
                    await CargarComboAsync();
                    habilitar(false);
                }
            }
            else if (modo.Equals(Accion.DELETE))
            {
                if (MessageBox.Show("Se borrará permanentemente , desea seguir?",
                              "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    await BorrarMateria(oMateria.IdAsignatura);
                    limpiar();
                    await CargarComboAsync();
                }
                habilitar(false);
            }
        }
    }
}
