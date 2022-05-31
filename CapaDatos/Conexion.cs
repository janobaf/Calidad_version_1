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
            conect.ConnectionString = "Server=CAPRS-Proyecto.mssql.somee.com; Database=CAPRS-Proyecto; User ID =tewci_SQLLogin_1;Password=hqa384cwt1 ;Trusted_Connection=False;Packet Size=4096;";
            //conect.ConnectionString = "workstation id = Caprs-Proyecto.mssql.somee.com; packet size = 4096; user id = tewci_SQLLogin_1; pwd = hqa384cwt1; data source = CAPRS - Proyecto.mssql.somee.com; persist security info=False; initial catalog = CAPRS - Proyecto";

            return conect;
        }   
    }
}
