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
        private Carrera oCarrera = new Carrera();
        List<Asignatura> materias = new List<Asignatura>();
        List<Carrera> carreras = new List<Carrera>();
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
            btnCancelar.Enabled = x;
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

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMateria_Click(object sender, EventArgs e)
        {

            if (cboMateria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una materia", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMateria.Focus();
                return;
            }
            if (nudAnioCursado.Value <= 0 || nudAnioCursado.Value > carreras[lstCarrera.SelectedIndex].AnioMaximo)
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
                dgvMateria.Rows.Add(new object[] { detalle.Cuatrimestre, oAsignatura.Nombre, detalle.AnioDeCursado });
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
                oCarrera.QuitarDetalle(dgvMateria.CurrentRow.Index);
                dgvMateria.Rows.Remove(dgvMateria.CurrentRow);
            }
        }
        public async Task TraerCarreraAsync(int n)
        {
            string url = "https://localhost:44361/api/Carrera/" + n.ToString();
            var resultado = await ClienteHttp.GetInstancia().GetAsync(url);
            oCarrera = JsonConvert.DeserializeObject<Carrera>(resultado);
        }

        public async Task CargarCampos()
        {
            txtNombre.Text = carreras[lstCarrera.SelectedIndex].Nombre;
            txtTitulo.Text = carreras[lstCarrera.SelectedIndex].Titulo;
            nudCantidadAnios.Value = Convert.ToInt32(carreras[lstCarrera.SelectedIndex].AnioMaximo);
            await TraerCarreraAsync(carreras[lstCarrera.SelectedIndex].IdCarrera);
        }


        private void lstCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCampos();
        }

        public async Task CargarFormAsync()
        {
            await CargarComboAsync();
            await CargarListAsync();
            CargarCampos();
        }
    }
}
