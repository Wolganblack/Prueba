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
    public partial class Mantenimiento : Formbase
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}
