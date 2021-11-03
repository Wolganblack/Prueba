using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Milibreria;

namespace WindowsFormsApp2
{
    public partial class Ventanaadmin : Formbase
    {
        public Ventanaadmin()
        {
            InitializeComponent();
        }

        private void Ventanaadmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Ventanaadmin_Load(object sender, EventArgs e)
        {
            string cmd = "select * from Usuarios where Idusuario=" + Ventanalogin.codigo;
            DataSet ds = Utilidades.Ejecutar(cmd);
            lblanomdmin.Text = ds.Tables[0].Rows[0]["Nomuser"].ToString();
            lblusadmin.Text = ds.Tables[0].Rows[0]["Account"].ToString();
            lbladmcodigo.Text = Convert.ToString(ds.Tables[0].Rows[0]["Idusuario"]);

            string url = ds.Tables[0].Rows[0]["Foto"].ToString();
            pictureBox1.Image = Image.FromFile(url);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contenedorprincipal Contenedor = new Contenedorprincipal();
            this.Hide();
            Contenedor.Show();

        }
    }
}
