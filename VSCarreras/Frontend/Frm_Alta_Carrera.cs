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
        List<Carrera> carreras = new List<Carrera>();
        Carrera oCarrera = new Carrera();
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
            CargarFormAsync();
        }
        private void limpiar()
        {

            txtNombre.Text = "";
            txtTitulo.Text = "";
            nudAnioCursado.Text = "";
            nudCantidadAnios.Text = "";
            rbtnAnual.Checked = false;
            rbtnPrimero.Checked = false;
            rbtnSegundo.Checked = false;
            cboMateria.SelectedIndex = -1;
            dgvMateria.Rows.Clear();
        }

        private void habilitar(bool x)
        {
            nudAnioCursado.Enabled = x;
            nudCantidadAnios.Enabled = x;
            txtNombre.Enabled = x;
            txtTitulo.Enabled = x;
            cboMateria.Enabled = x;
            rbtnAnual.Enabled = x;
            rbtnPrimero.Enabled = x;
            rbtnSegundo.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            lstCarrera.Enabled = !x;
            dgvMateria.Enabled = !x;
            btnMateria.Enabled = x;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = Accion.CREATE;
            limpiar();
            habilitar(true);
            txtNombre.Focus();
            oCarrera.Detalles.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modo = Accion.READ;
            limpiar();
            habilitar(false);
            txtNombre.Focus();
            oCarrera.IdCarrera = 0;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            modo = Accion.UPDATE;
            habilitar(true);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            modo = Accion.DELETE;
            oCarrera.IdCarrera = ((Carrera)lstCarrera.SelectedItem).IdCarrera;
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

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (modo.Equals(Accion.CREATE) || modo.Equals(Accion.UPDATE) || modo.Equals(Accion.DELETE))
            {
                if (dgvMateria.Rows.Count == 0)
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
                if (nudCantidadAnios.Value <= 0 || nudCantidadAnios.Value >= 100)
                {
                    MessageBox.Show("Debe ingresar un numero entre 1 y 99", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nudCantidadAnios.Focus();
                    return;
                }
                if (modo.Equals(Accion.CREATE))
                {
                    oCarrera.Nombre = txtNombre.Text;
                    oCarrera.Titulo = txtTitulo.Text;
                    oCarrera.AnioMaximo = Convert.ToInt32(nudCantidadAnios.Value);
                    await GuardarCarreraAsync();
                    limpiar();
                    await CargarListAsync();

                }
                else if (modo.Equals(Accion.UPDATE))
                {
                    await EditarCarreraAsync();
                    limpiar();
                }
                else if (modo.Equals(Accion.DELETE))
                {
                    if (MessageBox.Show("Se borrará permanentemente , desea seguir?",
                                  "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                        await BorrarCarreraAsync(oCarrera.IdCarrera);
                        limpiar();
                    }
                }
            }
        }
        public async Task<string> GuardarCarreraAsync()
        {
            string url = "https://localhost:44361/api/Carrera";
            string datos = JsonConvert.SerializeObject(oCarrera);
            var resultado = await ClienteHttp.GetInstancia().PostAsync(url, datos);
            return resultado;
        }
        public async Task<string> EditarCarreraAsync()
        {
            string url = "https://localhost:44361/api/Carrera";
            string datos = JsonConvert.SerializeObject((Carrera)lstCarrera.SelectedItem);
            var resultado = await ClienteHttp.GetInstancia().PostAsync(url, datos);
            return resultado;
        }

        public async Task<string> BorrarCarreraAsync(int n)
        {
            string url = "https://localhost:44361/api/Carrera" + n.ToString();
            string datos = JsonConvert.SerializeObject((Carrera)lstCarrera.SelectedItem);
            var resultado = await ClienteHttp.GetInstancia().DeleteAsync(url);
            return resultado;
        }
        public async Task CargarComboAsync()
        {
            string url = "https://localhost:44361/api/Carrera/asignaturas";
            var resultado = await ClienteHttp.GetInstancia().GetAsync(url);
            materias = JsonConvert.DeserializeObject<List<Asignatura>>(resultado);
            cboMateria.DataSource = materias;
            cboMateria.DisplayMember = "Nombre";
            cboMateria.ValueMember = "IdAsignatura";
        }

        public async Task CargarListAsync()
        {
            string url = "https://localhost:44361/api/Carrera";
            var resultado = await ClienteHttp.GetInstancia().GetAsync(url);
            carreras = JsonConvert.DeserializeObject<List<Carrera>>(resultado);
            lstCarrera.DataSource = carreras;
            lstCarrera.DisplayMember = "nombre";
            lstCarrera.ValueMember = "idCarrera";
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {

            if (cboMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una materia", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMateria.Focus();
                return;
            }
            if (nudAnioCursado.Value <= 0 || nudAnioCursado.Value > nudCantidadAnios.Value)
            {
                MessageBox.Show("Debe seleccionar un año de cursado entre uno y el año final de la carrera seleccionada", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudAnioCursado.Focus();
                return;
            }
            if (ExisteMateriaEnGrilla(cboMateria.Text))
            {
                MessageBox.Show("Materia ya ingresada", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Asignatura oAsignatura = (Asignatura)cboMateria.SelectedItem;
            DetalleCarrera detalle = new DetalleCarrera();
            string cuatrimestre;
            if (rbtnAnual.Checked)
            {
                cuatrimestre = "A";
            }
            else if (rbtnPrimero.Checked)
            {
                cuatrimestre = "P";
            }
            else
            {
                cuatrimestre = "S";
            }

            if (!ExisteMateriaEnGrilla(oAsignatura.Nombre))
            {
                detalle = new DetalleCarrera(Convert.ToInt32(nudAnioCursado.Value), cuatrimestre, oAsignatura);
                dgvMateria.Rows.Add(new object[] {String.Empty, detalle.Cuatrimestre, oAsignatura.Nombre, detalle.AnioDeCursado });
            }

            oCarrera.AgregarDetalle(detalle);
        }
        private bool ExisteMateriaEnGrilla(string text)
        {
            foreach (DataGridViewRow fila in dgvMateria.Rows)
            {
                if (fila.Cells["Materia"].Value.Equals(text))
                    return true;
            }
            return false;
        }
        private void dgvMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMateria.CurrentCell.ColumnIndex == 4)
            {
                ((Carrera)lstCarrera.SelectedItem).QuitarDetalle(dgvMateria.CurrentRow.Index);
                dgvMateria.Rows.Remove(dgvMateria.CurrentRow);
            }
        }
        public async Task TraerCarreraAsync(int n)
        {
            string url = "https://localhost:44361/api/Carrera/" + n.ToString();
            var resultado = await ClienteHttp.GetInstancia().GetAsync(url);
            oCarrera = JsonConvert.DeserializeObject<Carrera>(resultado);
        }

        public async Task CargarCampos(int n)
        {

            await TraerCarreraAsync(n);
            txtNombre.Text = oCarrera.Nombre;
            txtTitulo.Text = oCarrera.Titulo;
            nudCantidadAnios.Value = Convert.ToInt32(oCarrera.AnioMaximo);

            foreach (DetalleCarrera detalle in oCarrera.Detalles)
            {
                dgvMateria.Rows.Add(new object[] { String.Empty, detalle.Cuatrimestre, detalle.Materia.Nombre, detalle.AnioDeCursado});
            }

            
        }
        private async void lstCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMateria.Rows.Clear();
            await CargarCampos(((Carrera)(lstCarrera.SelectedItem)).IdCarrera);
        }

        public async Task CargarFormAsync()
        {
            await CargarComboAsync();
            await CargarListAsync();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
