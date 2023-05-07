namespace Topicos_Proyecto
{
    partial class Proceso_Interno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proceso_Interno));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_mensaje = new System.Windows.Forms.Button();
            this.btn_documento = new System.Windows.Forms.Button();
            this.btn_correo = new System.Windows.Forms.Button();
            this.btn_basura = new System.Windows.Forms.Button();
            this.btn_abrirMsg = new System.Windows.Forms.Button();
            this.btn_descargar = new System.Windows.Forms.Button();
            this.btn_cajonEntrada = new System.Windows.Forms.Button();
            this.pbx_iconUser = new System.Windows.Forms.PictureBox();
            this.btn_opciones = new System.Windows.Forms.Button();
            this.btn_configuracion = new System.Windows.Forms.Button();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_titulo.Location = new System.Drawing.Point(259, 12);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(268, 35);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Message Studio";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.Silver;
            this.txt_buscar.Location = new System.Drawing.Point(139, 63);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(388, 26);
            this.txt_buscar.TabIndex = 1;
            this.txt_buscar.Text = "Buscar...";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_buscar.FlatAppearance.BorderSize = 3;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Image = global::Topicos_Proyecto.Properties.Resources.Buscar;
            this.btn_buscar.Location = new System.Drawing.Point(533, 56);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(60, 40);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_buscar_MouseDown);
            this.btn_buscar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_buscar_MouseUp);
            // 
            // btn_mensaje
            // 
            this.btn_mensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mensaje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_mensaje.FlatAppearance.BorderSize = 3;
            this.btn_mensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mensaje.Image = global::Topicos_Proyecto.Properties.Resources.Mensaje;
            this.btn_mensaje.Location = new System.Drawing.Point(728, 236);
            this.btn_mensaje.Name = "btn_mensaje";
            this.btn_mensaje.Size = new System.Drawing.Size(60, 40);
            this.btn_mensaje.TabIndex = 11;
            this.btn_mensaje.UseVisualStyleBackColor = true;
            this.btn_mensaje.Click += new System.EventHandler(this.btn_mensaje_Click);
            this.btn_mensaje.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_mensaje_MouseDown);
            this.btn_mensaje.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_mensaje_MouseUp);
            // 
            // btn_documento
            // 
            this.btn_documento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_documento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_documento.FlatAppearance.BorderSize = 3;
            this.btn_documento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_documento.Image = global::Topicos_Proyecto.Properties.Resources.Documento;
            this.btn_documento.Location = new System.Drawing.Point(728, 190);
            this.btn_documento.Name = "btn_documento";
            this.btn_documento.Size = new System.Drawing.Size(60, 40);
            this.btn_documento.TabIndex = 10;
            this.btn_documento.UseVisualStyleBackColor = true;
            this.btn_documento.Click += new System.EventHandler(this.btn_documento_Click);
            this.btn_documento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_documento_MouseDown);
            this.btn_documento.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_documento_MouseUp);
            // 
            // btn_correo
            // 
            this.btn_correo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_correo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_correo.FlatAppearance.BorderSize = 3;
            this.btn_correo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_correo.Image = global::Topicos_Proyecto.Properties.Resources.Correo;
            this.btn_correo.Location = new System.Drawing.Point(728, 144);
            this.btn_correo.Name = "btn_correo";
            this.btn_correo.Size = new System.Drawing.Size(60, 40);
            this.btn_correo.TabIndex = 9;
            this.btn_correo.UseVisualStyleBackColor = true;
            this.btn_correo.Click += new System.EventHandler(this.btn_correo_Click);
            this.btn_correo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_correo_MouseDown);
            this.btn_correo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_correo_MouseUp);
            // 
            // btn_basura
            // 
            this.btn_basura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_basura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_basura.FlatAppearance.BorderSize = 3;
            this.btn_basura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_basura.Image = global::Topicos_Proyecto.Properties.Resources.OtraBasura;
            this.btn_basura.Location = new System.Drawing.Point(12, 282);
            this.btn_basura.Name = "btn_basura";
            this.btn_basura.Size = new System.Drawing.Size(60, 40);
            this.btn_basura.TabIndex = 8;
            this.btn_basura.UseVisualStyleBackColor = true;
            this.btn_basura.Click += new System.EventHandler(this.btn_basura_Click);
            this.btn_basura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_basura_MouseDown);
            this.btn_basura.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_basura_MouseUp);
            // 
            // btn_abrirMsg
            // 
            this.btn_abrirMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_abrirMsg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_abrirMsg.FlatAppearance.BorderSize = 3;
            this.btn_abrirMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrirMsg.Image = global::Topicos_Proyecto.Properties.Resources._5;
            this.btn_abrirMsg.Location = new System.Drawing.Point(12, 236);
            this.btn_abrirMsg.Name = "btn_abrirMsg";
            this.btn_abrirMsg.Size = new System.Drawing.Size(60, 40);
            this.btn_abrirMsg.TabIndex = 7;
            this.btn_abrirMsg.UseVisualStyleBackColor = true;
            this.btn_abrirMsg.Click += new System.EventHandler(this.btn_abrirMsg_Click);
            this.btn_abrirMsg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_abrirMsg_MouseDown);
            this.btn_abrirMsg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_abrirMsg_MouseUp);
            // 
            // btn_descargar
            // 
            this.btn_descargar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_descargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_descargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_descargar.FlatAppearance.BorderSize = 3;
            this.btn_descargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_descargar.Image = global::Topicos_Proyecto.Properties.Resources._2;
            this.btn_descargar.Location = new System.Drawing.Point(12, 190);
            this.btn_descargar.Name = "btn_descargar";
            this.btn_descargar.Size = new System.Drawing.Size(60, 40);
            this.btn_descargar.TabIndex = 6;
            this.btn_descargar.UseVisualStyleBackColor = true;
            this.btn_descargar.Click += new System.EventHandler(this.btn_descargar_Click);
            this.btn_descargar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_descargar_MouseDown);
            this.btn_descargar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_descargar_MouseUp);
            // 
            // btn_cajonEntrada
            // 
            this.btn_cajonEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cajonEntrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cajonEntrada.FlatAppearance.BorderSize = 3;
            this.btn_cajonEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cajonEntrada.Image = global::Topicos_Proyecto.Properties.Resources._1;
            this.btn_cajonEntrada.Location = new System.Drawing.Point(12, 144);
            this.btn_cajonEntrada.Name = "btn_cajonEntrada";
            this.btn_cajonEntrada.Size = new System.Drawing.Size(60, 40);
            this.btn_cajonEntrada.TabIndex = 5;
            this.btn_cajonEntrada.UseVisualStyleBackColor = true;
            this.btn_cajonEntrada.Click += new System.EventHandler(this.btn_cajonEntrada_Click);
            this.btn_cajonEntrada.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cajonEntrada_MouseDown);
            this.btn_cajonEntrada.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cajonEntrada_MouseUp);
            // 
            // pbx_iconUser
            // 
            this.pbx_iconUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_iconUser.BackgroundImage = global::Topicos_Proyecto.Properties.Resources.Usuario;
            this.pbx_iconUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_iconUser.Image = global::Topicos_Proyecto.Properties.Resources.marcoColor;
            this.pbx_iconUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx_iconUser.InitialImage")));
            this.pbx_iconUser.Location = new System.Drawing.Point(688, 12);
            this.pbx_iconUser.Name = "pbx_iconUser";
            this.pbx_iconUser.Size = new System.Drawing.Size(100, 84);
            this.pbx_iconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_iconUser.TabIndex = 17;
            this.pbx_iconUser.TabStop = false;
            // 
            // btn_opciones
            // 
            this.btn_opciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_opciones.BackColor = System.Drawing.Color.White;
            this.btn_opciones.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_opciones.FlatAppearance.BorderSize = 3;
            this.btn_opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opciones.Image = global::Topicos_Proyecto.Properties.Resources.Opciones;
            this.btn_opciones.Location = new System.Drawing.Point(622, 56);
            this.btn_opciones.Name = "btn_opciones";
            this.btn_opciones.Size = new System.Drawing.Size(60, 40);
            this.btn_opciones.TabIndex = 4;
            this.btn_opciones.UseVisualStyleBackColor = false;
            this.btn_opciones.Click += new System.EventHandler(this.btn_opciones_Click);
            this.btn_opciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_opciones_MouseDown);
            this.btn_opciones.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_opciones_MouseUp);
            // 
            // btn_configuracion
            // 
            this.btn_configuracion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_configuracion.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_configuracion.FlatAppearance.BorderSize = 3;
            this.btn_configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configuracion.Image = global::Topicos_Proyecto.Properties.Resources.configuracion;
            this.btn_configuracion.Location = new System.Drawing.Point(622, 12);
            this.btn_configuracion.Name = "btn_configuracion";
            this.btn_configuracion.Size = new System.Drawing.Size(60, 40);
            this.btn_configuracion.TabIndex = 3;
            this.btn_configuracion.UseVisualStyleBackColor = true;
            this.btn_configuracion.Click += new System.EventHandler(this.btn_configuracion_Click);
            this.btn_configuracion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_configuracion_MouseDown);
            this.btn_configuracion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_configuracion_MouseUp);
            // 
            // pbx_logo
            // 
            this.pbx_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_logo.BackgroundImage = global::Topicos_Proyecto.Properties.Resources.Logo_MS_Icon;
            this.pbx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_logo.Image = global::Topicos_Proyecto.Properties.Resources.marcoColor;
            this.pbx_logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx_logo.InitialImage")));
            this.pbx_logo.Location = new System.Drawing.Point(12, 12);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(100, 84);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_logo.TabIndex = 13;
            this.pbx_logo.TabStop = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(49)))), ((int)(((byte)(76)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.White;
            this.txt_usuario.Location = new System.Drawing.Point(688, 102);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.ReadOnly = true;
            this.txt_usuario.Size = new System.Drawing.Size(100, 24);
            this.txt_usuario.TabIndex = 12;
            this.txt_usuario.Text = "Usuario";
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Proceso_Interno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Topicos_Proyecto.Properties.Resources.FondoMejorado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_mensaje);
            this.Controls.Add(this.btn_documento);
            this.Controls.Add(this.btn_correo);
            this.Controls.Add(this.btn_basura);
            this.Controls.Add(this.btn_abrirMsg);
            this.Controls.Add(this.btn_descargar);
            this.Controls.Add(this.btn_cajonEntrada);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.pbx_iconUser);
            this.Controls.Add(this.btn_opciones);
            this.Controls.Add(this.btn_configuracion);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.pbx_logo);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Proceso_Interno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso Interno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Proceso_Interno_FormClosed);
            this.Load += new System.EventHandler(this.Proceso_Interno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_configuracion;
        private System.Windows.Forms.Button btn_opciones;
        private System.Windows.Forms.PictureBox pbx_iconUser;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_cajonEntrada;
        private System.Windows.Forms.Button btn_descargar;
        private System.Windows.Forms.Button btn_abrirMsg;
        private System.Windows.Forms.Button btn_basura;
        private System.Windows.Forms.Button btn_correo;
        private System.Windows.Forms.Button btn_documento;
        private System.Windows.Forms.Button btn_mensaje;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_usuario;
    }
}