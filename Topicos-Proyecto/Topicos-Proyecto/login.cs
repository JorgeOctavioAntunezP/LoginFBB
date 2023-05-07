using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Topicos_Proyecto
{
    public partial class login : Form
    {
        ServerConnection _connection = new ServerConnection();

        Proceso_Interno procesoI = new Proceso_Interno();

        //Transition tran = new Transition(new TransitionType_EaseInEaseOut(2000));

        #region Variables
        bool nombre = false;
        bool primerA = false;
        bool segundoA = false;
        bool edad = false;

        bool usuarioR = false;
        bool contraseñaR = false;
        bool confirmarC = false;

        bool usuarioI = false;
        bool contraseñaI = false;

        string usuario_nombre;
        string usuario_primerA;
        string usuario_segundoA;
        int usuario_edad;
        DateTime usuario_FechaN;

        string usuario_tag;
        string usuario_password;
        #endregion

        public login()
        {
            InitializeComponent();

            _connection.Conexión();
        }

        private void login_Load(object sender, EventArgs e)
        {
            _connection.IniciarConexión();

            #region Registrar Nueva Cuenta
            _connection._connHub.On<int>("Resultado_Registro", (result) =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (result == 1)
                    {
                        MessageBox.Show("Registro exitoso.", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UsuarioConectado.tag = usuario_tag;
                        UsuarioConectado.password = usuario_password;

                        this.Hide();
                        procesoI.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar tu cuenta.", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            });
            #endregion

            #region Ingresar a una Cuenta
            _connection._connHub.On<int>("Resultado_Ingreso", (result) =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (result == 1)
                    {
                        UsuarioConectado.tag = usuario_tag;
                        UsuarioConectado.password = usuario_password;

                        this.Hide();
                        procesoI.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo acceder a la cuenta.", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            });
            #endregion
        }

        #region Boton Registrar
        #region Diseño
        private void btn_registrarse_MouseDown(object sender, MouseEventArgs e)
        {
            btn_registrarse.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 255);
        }

        private void btn_registrarse_MouseUp(object sender, MouseEventArgs e)
        {
            btn_registrarse.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 112);
        }

        private void btn_regresar_Click(object sender, EventArgs e) // Bonto Secundario para Regresar
        {
            if (btn_registrarse.Text == "Registrarse")
            {
                gbx_registro2.Enabled = false;
                gbx_registro2.Visible = false;
                //tran.add(gbx_registro2, "Left", 385);
                //tran.add(gbx_registro1, "Left", 22);
                gbx_registro1.Enabled = true;
                gbx_registro1.Visible = true;

                //tran.run();

                btn_regresar.Enabled = false;
                btn_regresar.Visible = false;

                txt_nombre.Focus();

                btn_registrarse.Text = "Continuar";
            }
        }
        #endregion
        private async void btn_registrarse_Click(object sender, EventArgs e) // EventoClick [385]
        {
            if (btn_registrarse.Text == "Continuar")
            {
                #region Cambio de GrupBox
                gbx_registro1.Enabled = false;
                gbx_registro1.Visible = false;
                //tran.add(gbx_registro1, "Left", -340);
                //tran.add(gbx_registro2, "Left", 22);
                gbx_registro2.Enabled = true;
                gbx_registro2.Visible = true;

                //tran.run();

                btn_regresar.Enabled = true;
                btn_regresar.Visible = true;

                txt_usuarioR.Focus();

                btn_registrarse.Text = "Registrarse";
                #endregion
            }
            else
            {
                if (nombre && primerA && segundoA && edad && usuarioR && contraseñaR && confirmarC) // Todas la cajas de texto tienen valor
                {
                    if (txt_contraseñaR.Text == txt_confirmarContraseña.Text)
                    {
                        usuario_tag = txt_usuarioR.Text;
                        usuario_password = txt_contraseñaR.Text;

                        usuario_nombre = txt_nombre.Text.Trim();
                        usuario_primerA = txt_primerApellido.Text.Trim();
                        usuario_segundoA = txt_segundoApellido.Text.Trim();
                        usuario_edad = int.Parse(txt_edad.Text);
                        usuario_FechaN = dtp_fechaNacimiento.Value.Date;

                        await _connection._connHub.InvokeAsync("Registrarse", usuario_tag, usuario_password, usuario_nombre, usuario_primerA, usuario_segundoA, usuario_edad, usuario_FechaN);
                    }
                    else
                    {
                        MessageBox.Show("La contraseña con se confirmo correctamente.", "Error de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txt_contraseñaR.Clear();
                        txt_contraseñaR.Focus();

                        txt_confirmarContraseña.ForeColor = Color.Silver;
                        txt_confirmarContraseña.PasswordChar = '\0';
                        txt_confirmarContraseña.Text = "Confirmar contraseña";

                        confirmarC = false;
                    }
                }
                else
                {
                    MessageBox.Show("Necesitas llenar todos los datos.", "Error de Captura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region TextBox UsuarioR
        private void txt_usuarioR_Enter(object sender, EventArgs e)
        {
            string texto = "Nombre de usuario";

            if (txt_usuarioR.Text == texto)
            {
                txt_usuarioR.Clear();
                txt_usuarioR.ForeColor = Color.Black;

                usuarioR = true;
            }
        }

        private void txt_usuarioR_Leave(object sender, EventArgs e)
        {
            string texto = "Nombre de usuario";

            if (string.IsNullOrWhiteSpace(txt_usuarioR.Text) || txt_usuarioR.Text == texto)
            {
                txt_usuarioR.ForeColor = Color.Silver;
                txt_usuarioR.Text = texto;

                usuarioR = false;
            }
        }

        private void txt_usuarioR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsLetterOrDigit(caracter) && !char.IsControl(caracter) && caracter != ' ')
            {
                e.Handled = true;
            }
            else if (caracter == ' ')
            {
                TextBox textBox = (TextBox)sender;

                if (textBox.Text.EndsWith(" "))
                {
                    e.Handled = true;
                }
            }
        }

        #endregion

        #region TextBox ContraseñaR
        private void txt_contraseñaR_Enter(object sender, EventArgs e)
        {
            string texto = "Contraseña";

            if (txt_contraseñaR.Text == texto)
            {
                txt_contraseñaR.Clear();
                txt_contraseñaR.ForeColor = Color.Black;
                txt_contraseñaR.PasswordChar = '*';

                contraseñaR = true;
            }
        }

        private void txt_contraseñaR_Leave(object sender, EventArgs e)
        {
            string texto = "Contraseña";

            if (string.IsNullOrWhiteSpace(txt_contraseñaR.Text) || txt_contraseñaR.Text == texto)
            {
                txt_contraseñaR.ForeColor = Color.Silver;
                txt_contraseñaR.PasswordChar = '\0';
                txt_contraseñaR.Text = texto;

                contraseñaR = false;
            }
        }

        private void txt_contraseñaR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsLetterOrDigit(caracter) && !char.IsControl(caracter) && !char.IsPunctuation(caracter))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region TextBox Confirmar Contraseña
        private void txt_confirmarContraseña_Enter(object sender, EventArgs e)
        {
            string texto = "Confirmar contraseña";

            if (txt_confirmarContraseña.Text == texto)
            {
                txt_confirmarContraseña.Clear();
                txt_confirmarContraseña.ForeColor = Color.Black;
                txt_confirmarContraseña.PasswordChar = '*';

                confirmarC = true;
            }
        }

        private void txt_confirmarContraseña_Leave(object sender, EventArgs e)
        {
            string texto = "Confirmar contraseña";

            if (string.IsNullOrWhiteSpace(txt_confirmarContraseña.Text) || txt_confirmarContraseña.Text == texto)
            {
                txt_confirmarContraseña.ForeColor = Color.Silver;
                txt_confirmarContraseña.PasswordChar = '\0';
                txt_confirmarContraseña.Text = texto;

                confirmarC = false;
            }
        }

        private void txt_confirmarContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsLetterOrDigit(caracter) && !char.IsControl(caracter) && !char.IsPunctuation(caracter))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Botones de Ver Contraseña
        private void btn_verC_Click(object sender, EventArgs e)
        {
            if (txt_contraseñaR.PasswordChar != '*' && txt_contraseñaR.ForeColor != Color.Silver)
            {
                txt_contraseñaR.PasswordChar = '*';
            }
            else
            {
                txt_contraseñaR.PasswordChar = '\0';
            }
        }

        private void btn_verCC_Click(object sender, EventArgs e)
        {
            if (txt_confirmarContraseña.PasswordChar != '*' && txt_confirmarContraseña.ForeColor != Color.Silver)
            {
                txt_confirmarContraseña.PasswordChar = '*';
            }
            else
            {
                txt_confirmarContraseña.PasswordChar = '\0';
            }
        }
        #endregion

        #region TextBox Nombre
        private void txt_nombre_Enter(object sender, EventArgs e)
        {
            string texto = "Nombre";

            if (txt_nombre.Text == texto)
            {
                txt_nombre.Clear();
                txt_nombre.ForeColor = Color.Black;

                nombre = true;
            }
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            string texto = "Nombre";

            if (string.IsNullOrWhiteSpace(txt_nombre.Text) || txt_nombre.Text == texto)
            {
                txt_nombre.ForeColor = Color.Silver;
                txt_nombre.Text = texto;

                nombre = false;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsLetterOrDigit(caracter) && !char.IsControl(caracter) && caracter != ' ')
            {
                e.Handled = true;
            }
            else if (caracter == ' ')
            {
                TextBox textBox = (TextBox)sender;

                if (textBox.Text.EndsWith(" "))
                {
                    e.Handled = true;
                }
            }
        }

        #endregion

        #region TextBox Primer Apellido
        private void txt_primerApellido_Enter(object sender, EventArgs e)
        {
            string texto = "Primer apellido";

            if (txt_primerApellido.Text == texto)
            {
                txt_primerApellido.Clear();
                txt_primerApellido.ForeColor = Color.Black;

                primerA = true;
            }
        }

        private void txt_primerApellido_Leave(object sender, EventArgs e)
        {
            string texto = "Primer apellido";

            if (string.IsNullOrWhiteSpace(txt_primerApellido.Text) || txt_primerApellido.Text == texto)
            {
                txt_primerApellido.ForeColor = Color.Silver;
                txt_primerApellido.Text = texto;

                primerA = false;
            }
        }

        private void txt_primerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsLetterOrDigit(caracter) && !char.IsControl(caracter) && caracter != ' ')
            {
                e.Handled = true;
            }
            else if (caracter == ' ')
            {
                TextBox textBox = (TextBox)sender;

                if (textBox.Text.EndsWith(" "))
                {
                    e.Handled = true;
                }
            }
        }

        #endregion

        #region TextBox Segundo Apellido
        private void txt_segundoApellido_Enter(object sender, EventArgs e)
        {
            string texto = "Segundo apellido";

            if (txt_segundoApellido.Text == texto)
            {
                txt_segundoApellido.Clear();
                txt_segundoApellido.ForeColor = Color.Black;

                segundoA = true;
            }
        }

        private void txt_segundoApellido_Leave(object sender, EventArgs e)
        {
            string texto = "Segundo apellido";

            if (string.IsNullOrWhiteSpace(txt_segundoApellido.Text) || txt_segundoApellido.Text == texto)
            {
                txt_segundoApellido.ForeColor = Color.Silver;
                txt_segundoApellido.Text = texto;

                segundoA = false;
            }
        }

        private void txt_segundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsLetterOrDigit(caracter) && !char.IsControl(caracter) && caracter != ' ')
            {
                e.Handled = true;
            }
            else if (caracter == ' ')
            {
                TextBox textBox = (TextBox)sender;

                if (textBox.Text.EndsWith(" "))
                {
                    e.Handled = true;
                }
            }
        }

        #endregion

        #region TextBox Edad
        private void txt_edad_Enter(object sender, EventArgs e)
        {
            string texto = "Edad";

            if (txt_edad.Text == texto)
            {
                txt_edad.Clear();
                txt_edad.ForeColor = Color.Black;

                edad = true;
            }
        }

        private void txt_edad_Leave(object sender, EventArgs e)
        {
            string texto = "Edad";

            if (string.IsNullOrWhiteSpace(txt_edad.Text) || txt_edad.Text == texto)
            {
                txt_edad.ForeColor = Color.Silver;
                txt_edad.Text = texto;

                edad = false;
            }
            else
            {
                if (int.Parse(txt_edad.Text) > 150)
                {
                    txt_edad.Text = "150";
                }
            }
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Limpiar Registro
        void Resetear()
        {
            #region Boton Regresar
            gbx_registro2.Enabled = false;
            gbx_registro2.Visible = false;

            gbx_registro1.Enabled = true;
            gbx_registro1.Visible = true;

            btn_regresar.Enabled = false;
            btn_regresar.Visible = false;

            txt_nombre.Focus();

            btn_registrarse.Text = "Continuar";
            #endregion
            #region Cajas de Texto Registro
            txt_usuarioR.ForeColor = Color.Silver;
            txt_usuarioR.Text = "Nombre de usuario";
            usuarioR = false;

            txt_contraseñaR.ForeColor = Color.Silver;
            txt_contraseñaR.PasswordChar = '\0';
            txt_contraseñaR.Text = "Contraseña";
            contraseñaR = false;

            txt_confirmarContraseña.ForeColor = Color.Silver;
            txt_confirmarContraseña.PasswordChar = '\0';
            txt_confirmarContraseña.Text = "Confirmar contraseña";
            confirmarC = false;

            txt_nombre.ForeColor = Color.Silver;
            txt_nombre.Text = "Nombre";
            nombre = false;

            txt_primerApellido.ForeColor = Color.Silver;
            txt_primerApellido.Text = "Primer apellido";
            primerA = false;

            txt_segundoApellido.ForeColor = Color.Silver;
            txt_segundoApellido.Text = "Segundo apellido";
            segundoA = false;

            txt_edad.ForeColor = Color.Silver;
            txt_edad.Text = "Edad";
            edad = false;
            #endregion
        }
        #endregion



        #region Boton Ingresar
        #region Diseño
        private void btn_iniciarSesion_MouseDown(object sender, MouseEventArgs e)
        {
            btn_iniciarSesion.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 255);
        }

        private void btn_iniciarSesion_MouseUp(object sender, MouseEventArgs e)
        {
            btn_iniciarSesion.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 112);
        }
        #endregion

        private async void btn_iniciarSesion_Click(object sender, EventArgs e) // EventoClick
        {
            if (usuarioI && contraseñaI)
            {
                usuario_tag = txt_usuarioI.Text;
                usuario_password = txt_contraseñaI.Text;

                await _connection._connHub.InvokeAsync("Ingresar", usuario_tag, usuario_password);
            }
            else
            {
                MessageBox.Show("Necesitas llenar todos los datos.", "Error de Captura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region TextBox UsuarioI
        private void txt_usuarioI_Enter(object sender, EventArgs e)
        {
            string texto = "Nombre de usuario";

            if (txt_usuarioI.Text == texto)
            {
                txt_usuarioI.Clear();
                txt_usuarioI.ForeColor = Color.Black;

                usuarioI = true;
            }
        }

        private void txt_usuarioI_Leave(object sender, EventArgs e)
        {
            string texto = "Nombre de usuario";

            if (string.IsNullOrWhiteSpace(txt_usuarioI.Text) || txt_usuarioI.Text == texto)
            {
                txt_usuarioI.ForeColor = Color.Silver;
                txt_usuarioI.Text = texto;

                usuarioI = false;
            }
        }

        private void txt_usuarioI_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsLetterOrDigit(caracter) && !char.IsControl(caracter) && caracter != ' ')
            {
                e.Handled = true;
            }
            else if (caracter == ' ')
            {
                TextBox textBox = (TextBox)sender;

                if (textBox.Text.EndsWith(" "))
                {
                    e.Handled = true;
                }
            }
        }
        #endregion

        #region TextBox ContraseñaI
        private void txt_contraseñaI_Enter(object sender, EventArgs e)
        {
            string texto = "Contraseña";

            if (txt_contraseñaI.Text == texto)
            {
                txt_contraseñaI.Clear();
                txt_contraseñaI.ForeColor = Color.Black;
                txt_contraseñaI.PasswordChar = '*';

                contraseñaI = true;
            }
        }

        private void txt_contraseñaI_Leave(object sender, EventArgs e)
        {
            string texto = "Contraseña";

            if (string.IsNullOrWhiteSpace(txt_contraseñaI.Text) || txt_contraseñaI.Text == texto)
            {
                txt_contraseñaI.ForeColor = Color.Silver;
                txt_contraseñaI.PasswordChar = '\0';
                txt_contraseñaI.Text = texto;

                contraseñaI = false;
            }
        }

        private void txt_contraseñaI_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsLetterOrDigit(caracter) && !char.IsControl(caracter) && !char.IsPunctuation(caracter))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Cerrar por completo la aplicacion
        }
    }
}