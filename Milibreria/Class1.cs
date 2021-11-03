using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Milibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            
            SqlConnection conectar = new SqlConnection("Data Source =.; Initial Catalog = Administracion; Integrated Security = True");
        conectar.Open();    
        DataSet Dsetprobando = new DataSet();
        SqlDataAdapter Consultadeprueba = new SqlDataAdapter(cmd, conectar);
        Consultadeprueba.Fill(Dsetprobando);
        conectar.Close();
         return Dsetprobando;


        }
    }
}
