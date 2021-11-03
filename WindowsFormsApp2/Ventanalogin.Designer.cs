namespace WindowsFormsApp2
{
    partial class Ventanalogin
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
            this.btninicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textaccount = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1salir
            // 
            this.button1salir.Location = new System.Drawing.Point(225, 246);
            this.button1salir.Size = new System.Drawing.Size(131, 33);
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(83, 246);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(121, 33);
            this.btninicio.TabIndex = 2;
            this.btninicio.Text = "Inicio";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave";
            // 
            // textaccount
            // 
            this.textaccount.Location = new System.Drawing.Point(115, 28);
            this.textaccount.Name = "textaccount";
            this.textaccount.Size = new System.Drawing.Size(194, 20);
            this.textaccount.TabIndex = 0;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(115, 126);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(194, 20);
            this.textpassword.TabIndex = 1;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.png_clipart_user_login_mobile_phones_password_user_miscellaneous_blue;
            this.pictureBox1.Location = new System.Drawing.Point(336, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Ventanalogin
            // 
            this.AcceptButton = this.btninicio;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 316);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textaccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btninicio);
            this.Name = "Ventanalogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventanalogin_FormClosed);
            this.Load += new System.EventHandler(this.Ventanalogin_Load);
            this.Controls.SetChildIndex(this.btninicio, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textaccount, 0);
            this.Controls.SetChildIndex(this.textpassword, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.button1salir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textaccount;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

