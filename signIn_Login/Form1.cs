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
using Transitions;

namespace signIn_Login
{
    public partial class frm_signIn : Form
    {
        clsConexion conexion = new clsConexion();

        public frm_signIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transition tran = new Transition(new TransitionType_EaseInEaseOut(500));

            if (button1.Text != "Crear")
            {
                gpb_datosUsuario_1.Enabled = false;
                gpb_datosUsuario_2.Enabled = true;
                button1.Text = "Crear";
                btn_regresar.Enabled = true;

                tran.add(gpb_datosUsuario_1, "Left", -350);
                tran.add(gpb_datosUsuario_2, "Left", 1);
                tran.add(btn_regresar, "Left", 12);
                tran.run();
            }
            else
            {
                try
                {
                    int resultado = conexion.AgregarDatos(txt_usuario.Text, txt_contraseña.Text, txt_nombre.Text, txt_apellidoP.Text, txt_apellidoM.Text,
                     byte.Parse(txt_edad.Text), dtp_fechaNacimiento.Value, txt_numeroTelefono.Text);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Datos Guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
                catch
                {
                    MessageBox.Show("El Nombre de usuario ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_usuario.Clear();
                    txt_usuario.Focus();
                }
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Transition tran = new Transition(new TransitionType_EaseInEaseOut(500));

            gpb_datosUsuario_1.Enabled = true;
            gpb_datosUsuario_2.Enabled = false;
            button1.Text = "Aceptar";
            btn_regresar.Enabled = false;

            tran.add(gpb_datosUsuario_1, "Left", 1);
            tran.add(gpb_datosUsuario_2, "Left", 340);
            tran.add(btn_regresar, "Left", -145);
            tran.run();
        }

        private void frm_signIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_login formLG = new frm_login();
            formLG.Show();
        }
    }
}