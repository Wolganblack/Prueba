using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Milibreria;

namespace WindowsFormsApp2
{
    public partial class Ventanalogin : Formbase
    {
        public Ventanalogin()
        {
            InitializeComponent();
        }

        public static string codigo = "";
        private void btninicio_Click(object sender, EventArgs e)
        {

            try
            {

                string CMD = String.Format("Select * from Usuarios where Account = '{0}' and Password='{1}'",
                    textaccount.Text.Trim(), textpassword.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);

                codigo = Convert.ToString(ds.Tables[0].Rows[0]["Idusuario"]);
                string cuenta = ds.Tables[0].Rows[0]["Account"].ToString().Trim();
                string contraseña = ds.Tables[0].Rows[0]["Password"].ToString().Trim();

                if (cuenta == textaccount.Text.Trim() && contraseña == textpassword.Text.Trim())
                {
                    if(Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"])==true)
                    {
                        Ventanaadmin Ventad = new Ventanaadmin();
                        this.Hide();
                        Ventad.Show();
                    }

                    else
                    {
                        Ventanauser Ventuser = new Ventanauser();
                        this.Hide();
                        Ventuser.Show();
                    }
                }

                
            }


            catch (Exception error)
            {

                MessageBox.Show("Usuario y Contraseña Incorrectos" + error.Message);


            }


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ventanalogin_Load(object sender, EventArgs e)
        {

        }

        private void Ventanalogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
