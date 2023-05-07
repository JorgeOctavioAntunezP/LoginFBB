using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topicos_Proyecto
{
    public partial class Proceso_Interno : Form
    {
        ServerConnection _connection = new ServerConnection();

        public Proceso_Interno()
        {
            InitializeComponent();

            _connection.Conexión();
        }

        private void Proceso_Interno_Load(object sender, EventArgs e)
        {
            _connection.IniciarConexión();

            txt_usuario.Text = UsuarioConectado.tag.Trim();
        }

        #region Boton Basura
        private void btn_basura_MouseDown(object sender, MouseEventArgs e)
        {
            btn_basura.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
        }

        private void btn_basura_MouseUp(object sender, MouseEventArgs e)
        {
            btn_basura.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
        }

        private void btn_basura_Click(object sender, EventArgs e) // EventoClick
        {
            
        }
        #endregion

        #region Boton abrirMsg
        private void btn_abrirMsg_MouseDown(object sender, MouseEventArgs e)
        {
            btn_abrirMsg.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
        }

        private void btn_abrirMsg_MouseUp(object sender, MouseEventArgs e)
        {
            btn_abrirMsg.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
        }

        private void btn_abrirMsg_Click(object sender, EventArgs e) // EventoClick
        {

        }
        #endregion

        #region Boton Descargar
        private void btn_descargar_MouseDown(object sender, MouseEventArgs e)
        {
            btn_descargar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
        }

        private void btn_descargar_MouseUp(object sender, MouseEventArgs e)
        {
            btn_descargar.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
        }

        private void btn_descargar_Click(object sender, EventArgs e) // EventoClick
        {

        }
        #endregion

        #region Boton Cajon de Entrada
        private void btn_cajonEntrada_MouseDown(object sender, MouseEventArgs e)
        {
            btn_cajonEntrada.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
        }

        private void btn_cajonEntrada_MouseUp(object sender, MouseEventArgs e)
        {
            btn_cajonEntrada.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
        }

        private void btn_cajonEntrada_Click(object sender, EventArgs e) // EventoClick
        {

        }
        #endregion
         
        #region Boton Correo
        private void btn_correo_MouseDown(object sender, MouseEventArgs e)
        {
            btn_correo.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
        }

        private void btn_correo_MouseUp(object sender, MouseEventArgs e)
        {
            btn_correo.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
        }

        private void btn_correo_Click(object sender, EventArgs e) // EventoClick
        {

        }
        #endregion

        #region Boton Documento
        private void btn_documento_MouseDown(object sender, MouseEventArgs e)
        {
            btn_documento.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
        }

        private void btn_documento_MouseUp(object sender, MouseEventArgs e)
        {
            btn_documento.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
        }

        private void btn_documento_Click(object sender, EventArgs e) // EventoClick
        {

        }
        #endregion

        #region Boton Mensaje
        private void btn_mensaje_MouseDown(object sender, MouseEventArgs e)
        {
            btn_mensaje.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
        }

        private void btn_mensaje_MouseUp(object sender, MouseEventArgs e)
        {
            btn_mensaje.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
        }

        private void btn_mensaje_Click(object sender, EventArgs e) // EventoClick
        {

        }
        #endregion

        #region Boton Opciones
        private void btn_opciones_MouseDown(object sender, MouseEventArgs e)
        {
            btn_opciones.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 228);
        }

        private void btn_opciones_MouseUp(object sender, MouseEventArgs e)
        {
            btn_opciones.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 112);
        }

        private void btn_opciones_Click(object sender, EventArgs e) // EventoClick
        {

        }
        #endregion

        #region Boton Configuracion
        private void btn_configuracion_MouseDown(object sender, MouseEventArgs e)
        {
            btn_configuracion.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 228);
        }

        private void btn_configuracion_MouseUp(object sender, MouseEventArgs e)
        {
            btn_configuracion.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 112);
        }

        private void btn_configuracion_Click(object sender, EventArgs e) // EventoClick
        {

        }
        #endregion

        #region Boton Buscar
        private void btn_buscar_MouseDown(object sender, MouseEventArgs e)
        {
            btn_buscar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 228);
        }

        private void btn_buscar_MouseUp(object sender, MouseEventArgs e)
        {
            btn_buscar.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 112);
        }

        private void btn_buscar_Click(object sender, EventArgs e) // EventoClick
        {

        }
        #endregion

        private void Proceso_Interno_FormClosed(object sender, FormClosedEventArgs e)
        {
            login _login = new login();

            this.Hide();
            _login.Show();
        }
    }
}