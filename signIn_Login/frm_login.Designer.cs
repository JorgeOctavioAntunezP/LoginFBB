namespace signIn_Login
{
    partial class frm_login
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
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_acceder = new System.Windows.Forms.Button();
            this.lkl_singIn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(200, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(73, 29);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Login";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(121, 60);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(74, 24);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(125, 87);
            this.txt_usuario.MaxLength = 20;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(250, 29);
            this.txt_usuario.TabIndex = 8;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(125, 157);
            this.txt_contraseña.MaxLength = 20;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(250, 29);
            this.txt_contraseña.TabIndex = 9;
            // 
            // btn_acceder
            // 
            this.btn_acceder.BackColor = System.Drawing.Color.Black;
            this.btn_acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acceder.ForeColor = System.Drawing.Color.White;
            this.btn_acceder.Location = new System.Drawing.Point(160, 192);
            this.btn_acceder.Name = "btn_acceder";
            this.btn_acceder.Size = new System.Drawing.Size(180, 45);
            this.btn_acceder.TabIndex = 14;
            this.btn_acceder.Text = "Acceder";
            this.btn_acceder.UseVisualStyleBackColor = false;
            this.btn_acceder.Click += new System.EventHandler(this.btn_acceder_Click);
            // 
            // lkl_singIn
            // 
            this.lkl_singIn.ActiveLinkColor = System.Drawing.Color.Navy;
            this.lkl_singIn.AutoSize = true;
            this.lkl_singIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkl_singIn.LinkColor = System.Drawing.Color.Gray;
            this.lkl_singIn.Location = new System.Drawing.Point(195, 250);
            this.lkl_singIn.Name = "lkl_singIn";
            this.lkl_singIn.Size = new System.Drawing.Size(118, 24);
            this.lkl_singIn.TabIndex = 15;
            this.lkl_singIn.TabStop = true;
            this.lkl_singIn.Text = "Crear cuenta";
            this.lkl_singIn.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lkl_singIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_singIn_LinkClicked);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.lkl_singIn);
            this.Controls.Add(this.btn_acceder);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_acceder;
        private System.Windows.Forms.LinkLabel lkl_singIn;
    }
}