using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using csl_ConexionBaseDatos;

namespace signIn_Login
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void lkl_singIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_signIn formSI = new frm_signIn();

            this.Hide();
            formSI.Show();
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            clsConexion conexion = new clsConexion();

            int result = conexion.Login(txt_usuario.Text, txt_contraseña.Text);

            if (result == 1)
            {
                MessageBox.Show("Cuenta Encontrada");
            }
            else
            {
                MessageBox.Show("El usuario o la contraseño son incorrectos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
