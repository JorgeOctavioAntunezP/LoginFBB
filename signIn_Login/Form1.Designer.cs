namespace signIn_Login
{
    partial class frm_signIn
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellidoP = new System.Windows.Forms.Label();
            this.lbl_apellidoM = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_fechaNacimiento = new System.Windows.Forms.Label();
            this.lbl_numeroTelefono = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellidoP = new System.Windows.Forms.TextBox();
            this.txt_apellidoM = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.txt_numeroTelefono = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gpb_datosUsuario_1 = new System.Windows.Forms.GroupBox();
            this.gpb_datosUsuario_2 = new System.Windows.Forms.GroupBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_confirmarContraseña = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.gpb_datosUsuario_1.SuspendLayout();
            this.gpb_datosUsuario_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(113, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(87, 29);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Sing In";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(15, 30);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(79, 24);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellidoP
            // 
            this.lbl_apellidoP.AutoSize = true;
            this.lbl_apellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoP.Location = new System.Drawing.Point(15, 65);
            this.lbl_apellidoP.Name = "lbl_apellidoP";
            this.lbl_apellidoP.Size = new System.Drawing.Size(139, 24);
            this.lbl_apellidoP.TabIndex = 2;
            this.lbl_apellidoP.Text = "Primer Apellido";
            // 
            // lbl_apellidoM
            // 
            this.lbl_apellidoM.AutoSize = true;
            this.lbl_apellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidoM.Location = new System.Drawing.Point(15, 100);
            this.lbl_apellidoM.Name = "lbl_apellidoM";
            this.lbl_apellidoM.Size = new System.Drawing.Size(162, 24);
            this.lbl_apellidoM.TabIndex = 3;
            this.lbl_apellidoM.Text = "Segundo Apellido";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad.Location = new System.Drawing.Point(15, 132);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(55, 24);
            this.lbl_edad.TabIndex = 4;
            this.lbl_edad.Text = "Edad";
            // 
            // lbl_fechaNacimiento
            // 
            this.lbl_fechaNacimiento.AutoSize = true;
            this.lbl_fechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaNacimiento.Location = new System.Drawing.Point(15, 174);
            this.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento";
            this.lbl_fechaNacimiento.Size = new System.Drawing.Size(191, 24);
            this.lbl_fechaNacimiento.TabIndex = 5;
            this.lbl_fechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lbl_numeroTelefono
            // 
            this.lbl_numeroTelefono.AutoSize = true;
            this.lbl_numeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeroTelefono.Location = new System.Drawing.Point(15, 239);
            this.lbl_numeroTelefono.Name = "lbl_numeroTelefono";
            this.lbl_numeroTelefono.Size = new System.Drawing.Size(136, 24);
            this.lbl_numeroTelefono.TabIndex = 6;
            this.lbl_numeroTelefono.Text = "Num. Telefono";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(100, 27);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(221, 29);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_apellidoP
            // 
            this.txt_apellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidoP.Location = new System.Drawing.Point(160, 62);
            this.txt_apellidoP.MaxLength = 20;
            this.txt_apellidoP.Name = "txt_apellidoP";
            this.txt_apellidoP.Size = new System.Drawing.Size(161, 29);
            this.txt_apellidoP.TabIndex = 8;
            // 
            // txt_apellidoM
            // 
            this.txt_apellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidoM.Location = new System.Drawing.Point(183, 97);
            this.txt_apellidoM.MaxLength = 20;
            this.txt_apellidoM.Name = "txt_apellidoM";
            this.txt_apellidoM.Size = new System.Drawing.Size(138, 29);
            this.txt_apellidoM.TabIndex = 9;
            // 
            // txt_edad
            // 
            this.txt_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad.Location = new System.Drawing.Point(76, 132);
            this.txt_edad.MaxLength = 3;
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(245, 29);
            this.txt_edad.TabIndex = 10;
            // 
            // txt_numeroTelefono
            // 
            this.txt_numeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroTelefono.Location = new System.Drawing.Point(157, 236);
            this.txt_numeroTelefono.MaxLength = 10;
            this.txt_numeroTelefono.Name = "txt_numeroTelefono";
            this.txt_numeroTelefono.Size = new System.Drawing.Size(164, 29);
            this.txt_numeroTelefono.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(212, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpb_datosUsuario_1
            // 
            this.gpb_datosUsuario_1.Controls.Add(this.dtp_fechaNacimiento);
            this.gpb_datosUsuario_1.Controls.Add(this.lbl_nombre);
            this.gpb_datosUsuario_1.Controls.Add(this.lbl_apellidoP);
            this.gpb_datosUsuario_1.Controls.Add(this.txt_numeroTelefono);
            this.gpb_datosUsuario_1.Controls.Add(this.lbl_apellidoM);
            this.gpb_datosUsuario_1.Controls.Add(this.lbl_edad);
            this.gpb_datosUsuario_1.Controls.Add(this.txt_edad);
            this.gpb_datosUsuario_1.Controls.Add(this.lbl_fechaNacimiento);
            this.gpb_datosUsuario_1.Controls.Add(this.txt_apellidoM);
            this.gpb_datosUsuario_1.Controls.Add(this.lbl_numeroTelefono);
            this.gpb_datosUsuario_1.Controls.Add(this.txt_apellidoP);
            this.gpb_datosUsuario_1.Controls.Add(this.txt_nombre);
            this.gpb_datosUsuario_1.Location = new System.Drawing.Point(1, 41);
            this.gpb_datosUsuario_1.Name = "gpb_datosUsuario_1";
            this.gpb_datosUsuario_1.Size = new System.Drawing.Size(332, 301);
            this.gpb_datosUsuario_1.TabIndex = 14;
            this.gpb_datosUsuario_1.TabStop = false;
            // 
            // gpb_datosUsuario_2
            // 
            this.gpb_datosUsuario_2.Controls.Add(this.lbl_usuario);
            this.gpb_datosUsuario_2.Controls.Add(this.label2);
            this.gpb_datosUsuario_2.Controls.Add(this.label3);
            this.gpb_datosUsuario_2.Controls.Add(this.txt_confirmarContraseña);
            this.gpb_datosUsuario_2.Controls.Add(this.txt_contraseña);
            this.gpb_datosUsuario_2.Controls.Add(this.txt_usuario);
            this.gpb_datosUsuario_2.Enabled = false;
            this.gpb_datosUsuario_2.Location = new System.Drawing.Point(340, 41);
            this.gpb_datosUsuario_2.Name = "gpb_datosUsuario_2";
            this.gpb_datosUsuario_2.Size = new System.Drawing.Size(332, 301);
            this.gpb_datosUsuario_2.TabIndex = 15;
            this.gpb_datosUsuario_2.TabStop = false;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(15, 30);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(74, 24);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // txt_confirmarContraseña
            // 
            this.txt_confirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmarContraseña.Location = new System.Drawing.Point(213, 97);
            this.txt_confirmarContraseña.MaxLength = 20;
            this.txt_confirmarContraseña.Name = "txt_confirmarContraseña";
            this.txt_confirmarContraseña.Size = new System.Drawing.Size(108, 29);
            this.txt_confirmarContraseña.TabIndex = 9;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(127, 62);
            this.txt_contraseña.MaxLength = 20;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(194, 29);
            this.txt_contraseña.TabIndex = 8;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(100, 27);
            this.txt_usuario.MaxLength = 20;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(221, 29);
            this.txt_usuario.TabIndex = 7;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_regresar.Enabled = false;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(-145, 404);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(130, 45);
            this.btn_regresar.TabIndex = 16;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(19, 201);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(302, 29);
            this.dtp_fechaNacimiento.TabIndex = 17;
            // 
            // frm_signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.gpb_datosUsuario_2);
            this.Controls.Add(this.gpb_datosUsuario_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_signIn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sing In";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_signIn_FormClosed);
            this.gpb_datosUsuario_1.ResumeLayout(false);
            this.gpb_datosUsuario_1.PerformLayout();
            this.gpb_datosUsuario_2.ResumeLayout(false);
            this.gpb_datosUsuario_2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellidoP;
        private System.Windows.Forms.Label lbl_apellidoM;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label lbl_fechaNacimiento;
        private System.Windows.Forms.Label lbl_numeroTelefono;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellidoP;
        private System.Windows.Forms.TextBox txt_apellidoM;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.TextBox txt_numeroTelefono;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpb_datosUsuario_1;
        private System.Windows.Forms.GroupBox gpb_datosUsuario_2;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_confirmarContraseña;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.DateTimePicker dtp_fechaNacimiento;
    }
}

