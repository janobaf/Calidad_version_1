using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Alumno;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos.Pagos
{
    public class CD_Pagos
    {
        #region Singleton
        private static readonly CD_Pagos _instancia = new CD_Pagos();
        public static CD_Pagos Instancia
        {
            get { return CD_Pagos._instancia; }
        }
        #endregion
        #region metodos

        public bool modificar_pago (string dni)
        {
            SqlCommand cmd = null;
            bool validar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "update Alumno set Alumn_Estado='true' where Alumn_DNI =";
                sql += dni;
                cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { validar = true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }

            return validar; 
        }

        public List<E_Alumno> mostrar_alumnos (string tipo)
        {
            List<E_Alumno> aux = new List<E_Alumno>();
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            string sql = "select * from Alumno where Alumn_Estado=";
            sql += tipo;
            cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                E_Alumno alumno = new E_Alumno();
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
                alumno.Alumn_Grado = dr["Alumn_Grado"].ToString();
                aux.Add(alumno);


            }
            cmd.Connection.Close();
            if (aux != null)
                return aux;
            return null;
        }
        #endregion metodos

    }
}
