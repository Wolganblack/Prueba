using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Formbase : Form
    {
        public Formbase()
        {
            InitializeComponent();
        }

        private void Formbase_Load(object sender, EventArgs e)
        {

        }

        private void button1salir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desesa salir?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                this.Close();
            }

        }

        public virtual void Eliminar()
        {

        }
        public virtual void Nuevo()
        {

        }

        public virtual void Consultar()
        {

        }

        public virtual Boolean Guardar()
        {
            return false;
        }
    }
}
