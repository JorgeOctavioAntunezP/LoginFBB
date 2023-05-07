namespace Topicos_Proyecto
{
    partial class Reporte
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnimagen = new System.Windows.Forms.Button();
            this.btnlink = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message Studio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre del Reporte:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 5;
            // 
            // rtxt
            // 
            this.rtxt.Location = new System.Drawing.Point(34, 157);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(492, 224);
            this.rtxt.TabIndex = 7;
            this.rtxt.Text = "Redactar Reporte";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Topicos_Proyecto.Properties.Resources.logo_Message_Studio;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(665, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.DarkRed;
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnenviar.Image = global::Topicos_Proyecto.Properties.Resources.ENVIAR;
            this.btnenviar.Location = new System.Drawing.Point(279, 398);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 11;
            this.btnenviar.UseVisualStyleBackColor = false;
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.DarkRed;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnborrar.Image = global::Topicos_Proyecto.Properties.Resources.BASURA;
            this.btnborrar.Location = new System.Drawing.Point(575, 309);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 10;
            this.btnborrar.UseVisualStyleBackColor = false;
            // 
            // btnimagen
            // 
            this.btnimagen.BackColor = System.Drawing.Color.DarkRed;
            this.btnimagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnimagen.Image = global::Topicos_Proyecto.Properties.Resources.IMAGEN;
            this.btnimagen.Location = new System.Drawing.Point(575, 242);
            this.btnimagen.Name = "btnimagen";
            this.btnimagen.Size = new System.Drawing.Size(75, 23);
            this.btnimagen.TabIndex = 9;
            this.btnimagen.UseVisualStyleBackColor = false;
            // 
            // btnlink
            // 
            this.btnlink.BackColor = System.Drawing.Color.DarkRed;
            this.btnlink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlink.Image = global::Topicos_Proyecto.Properties.Resources.LINK;
            this.btnlink.Location = new System.Drawing.Point(575, 182);
            this.btnlink.Name = "btnlink";
            this.btnlink.Size = new System.Drawing.Size(75, 23);
            this.btnlink.TabIndex = 8;
            this.btnlink.UseVisualStyleBackColor = false;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.DarkRed;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefresh.Image = global::Topicos_Proyecto.Properties.Resources.REFRESH;
            this.btnrefresh.Location = new System.Drawing.Point(151, 36);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 1;
            this.btnrefresh.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.DarkRed;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Image = global::Topicos_Proyecto.Properties.Resources.SALIDA;
            this.btnsalir.Location = new System.Drawing.Point(45, 36);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 0;
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Topicos_Proyecto.Properties.Resources.WhatsApp_Image_2023_05_03_at_10_59_10_PM;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnimagen);
            this.Controls.Add(this.btnlink);
            this.Controls.Add(this.rtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnsalir);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.Button btnlink;
        private System.Windows.Forms.Button btnimagen;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

