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
    public partial class Frm_Login : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private Credenciales credenciales = new Credenciales();
        ///
        /// drag form
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }


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

        private async void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            credenciales.Usuario = txtUsuario.Text;
            credenciales.Password = txtContraseña.Text;
            string login = await LoginAsync();
            if (login == "true")
            {
                Frm_Principal nuevo = new Frm_Principal();
                nuevo.ShowDialog();
            }
            else {
                MessageBox.Show("Login inválido");
            }
             
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public async Task<string> LoginAsync()
        {
            string url = "https://localhost:44361/login";
            string datos = JsonConvert.SerializeObject(credenciales);
            var resultado = await ClienteHttp.GetInstancia().PostAsync(url,datos);
            return resultado;
        }

    }
}
