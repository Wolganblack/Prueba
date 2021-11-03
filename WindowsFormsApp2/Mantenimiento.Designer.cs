namespace WindowsFormsApp2
{
    partial class Mantenimiento
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
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1salir
            // 
            this.button1salir.Location = new System.Drawing.Point(399, 203);
            this.button1salir.Size = new System.Drawing.Size(115, 28);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(398, 155);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(115, 25);
            this.btnnuevo.TabIndex = 8;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(399, 111);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(115, 25);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // buttonguardar
            // 
            this.buttonguardar.Location = new System.Drawing.Point(398, 68);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(115, 25);
            this.buttonguardar.TabIndex = 6;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = true;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(398, 19);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(115, 25);
            this.buttonConsultar.TabIndex = 5;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 289);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.buttonConsultar);
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            this.Controls.SetChildIndex(this.button1salir, 0);
            this.Controls.SetChildIndex(this.buttonConsultar, 0);
            this.Controls.SetChildIndex(this.buttonguardar, 0);
            this.Controls.SetChildIndex(this.btneliminar, 0);
            this.Controls.SetChildIndex(this.btnnuevo, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnnuevo;
        public System.Windows.Forms.Button btneliminar;
        public System.Windows.Forms.Button buttonguardar;
        public System.Windows.Forms.Button buttonConsultar;
    }
}