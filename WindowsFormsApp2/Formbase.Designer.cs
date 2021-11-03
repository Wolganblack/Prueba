namespace WindowsFormsApp2
{
    partial class Formbase
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
            this.button1salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1salir
            // 
            this.button1salir.Location = new System.Drawing.Point(201, 138);
            this.button1salir.Name = "button1salir";
            this.button1salir.Size = new System.Drawing.Size(121, 38);
            this.button1salir.TabIndex = 0;
            this.button1salir.Text = "Salir";
            this.button1salir.UseVisualStyleBackColor = true;
            this.button1salir.Click += new System.EventHandler(this.button1salir_Click);
            // 
            // Formbase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 214);
            this.Controls.Add(this.button1salir);
            this.Name = "Formbase";
            this.Text = "Formbase";
            this.Load += new System.EventHandler(this.Formbase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1salir;
    }
}