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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Frm_Principal nuevo = new Frm_Principal();
            nuevo.ShowDialog();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            Frm_Principal nuevo = new Frm_Principal();
            nuevo.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
