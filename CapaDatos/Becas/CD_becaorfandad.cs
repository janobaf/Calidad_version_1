using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Alumno;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos.Becas
{
    public class CD_becaorfandad
    {

        #region Singleton
        private static readonly CD_becaorfandad _instancia = new CD_becaorfandad();
        public static CD_becaorfandad Instancia
        {
            get { return CD_becaorfandad._instancia; }
        }

        #endregion
        #region metodos

        public E_Alumno Mostrar(string DNI)
        {
            E_Alumno alumno = new E_Alumno();
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("GP_BecaOrfandad", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Alum_Dni", DNI);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                alumno.Alumn_nombre = dr["Alumn_Nombre"].ToString();
                alumno.Alumn_ApellidoPaterno = dr["Alumn_ApellidoPaterno"].ToString();
                alumno.Alumn_ApellidoMaterno = dr["Alumn_ApellidoMaterno"].ToString();
                alumno.Alumn_Direccion = dr["Alumn_Direccion"].ToString();
                alumno.Alumn_Fechnaci = DateTime.Parse(dr["Alum_FechNaci"].ToString());
                alumno.Alumn_Tipo = dr["Alumn_Tipo"].ToString();
                alumno.Alumn_fechInscripcion = DateTime.Parse(dr["Alum_FechInscripcion"].ToString());
                alumno.Alumn_dni = dr["Alumn_dni"].ToString();
                alumno.Alumn_ApoderadoNombre = dr["Alum_ApoderadoNombre"].ToString();
                alumno.Alumn_ApoderadoApellido = dr["Alum_ApoderadoApePaterno"].ToString();
                alumno.Alumn_ApoderadoMaterno = dr["Alum_ApoderadoApeMaterno"].ToString();
                alumno.Alumn_Estado = dr["Alumn_Estado"].ToString();
            }
            cmd.Connection.Close();
            return alumno;
        }
        #endregion metodos
    }
}
