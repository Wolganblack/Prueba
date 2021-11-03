namespace WindowsFormsApp2
{
    partial class Mantenimientocliente
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
            this.SuspendLayout();
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(348, 155);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(348, 115);
            // 
            // buttonguardar
            // 
            this.buttonguardar.Location = new System.Drawing.Point(348, 66);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(348, 21);
            // 
            // button1salir
            // 
            this.button1salir.Location = new System.Drawing.Point(348, 199);
            this.button1salir.Size = new System.Drawing.Size(115, 24);
            // 
            // Mantenimientocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 309);
            this.Name = "Mantenimientocliente";
            this.Text = "Mantenimientocliente";
            this.Load += new System.EventHandler(this.Mantenimientocliente_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}