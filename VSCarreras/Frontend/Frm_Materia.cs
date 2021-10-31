using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Frm_Materia : Form
    {
        public Frm_Materia()
        {
            InitializeComponent();
        }

        private void Frm_Materia_Load(object sender, EventArgs e)
        {
            habilitar(false);

            ////conexion = new conxion
            //conexion.open();
            //string
            //sql command comando
            //SqlDataAdapter adaptador = new SqlDaraAdapter(comando);
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //cboMateriasCargadas.DataSource=tabla;
            //cboMateriasCargadas.ValueMember="Id";
            //cboMateriasCargadas.DisplayMember="nombre";

            //AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //foreach (DataRow row in tabla.Rows)
            //{
            //  coleccion.Add(Convert.TiString(row["Nombre"]));  //consulta de sql
            //}
            //cboMateriasCargadas.AutoCompleteCustomSource=coleccion;
            //cboMateriasCargadas.AutoCompleteMode= AutoCompleteMode.SuggestAppend;
            //cboMateriasCargadas.AutoCompleteSource= AutoCompleteSource.CustomSource;

        }

        private void cboMateriasCargadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   .Text= cboMateriasCargadas.SelectedValue.ToString();  //aca muestra el id del objeto seleccionado en el combo 
            //txtNombreMateria ???
        }
        private void limpiar()
        {
            txtNombreMateria.Text = "";
            cboMateriasCargadas.SelectedIndex = -1;

        }

        private void habilitar(bool x)
        {

            txtNombreMateria.Enabled = x;
            cboMateriasCargadas.Enabled = x;
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
    }
}
