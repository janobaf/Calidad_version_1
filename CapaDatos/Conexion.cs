using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection conect = new SqlConnection();
            conect.ConnectionString = "Data Source=CAPRS-Proyecto.mssql.somee.com; Initial Catalog=CAPRS-Proyecto; User ID = tewci_SQLLogin_1;Password=hqa384cwt1;Integrated Security=true";
            return conect;
        }
    }
}
