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
                string sql = "update Alumno set Alumn_Estado='TRUE' where Alumn_DNI =";
                sql += dni;
                cmd = new SqlCommand(sql, cn);
                SqlDataReader registro = cmd.ExecuteReader();
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
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                
                cmd = new SqlCommand("mostrar_Alumnos_Pension", cn);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    E_Alumno alumno = new E_Alumno();
                    alumno.Alumn_nombre = dr["Alum_Nombre"].ToString();
                    alumno.Alumn_ApellidoPaterno = dr["Alum_ApellidoPaterno"].ToString();
                    alumno.Alumn_ApellidoMaterno = dr["Alum_ApellidoMaterno"].ToString();
                    alumno.Alumn_Direccion = dr["Alum_Direccion"].ToString();
                    alumno.Alumn_Fechnaci = DateTime.Parse(dr["Alum_FechNaci"].ToString());
                    alumno.Alumn_Tipo = dr["Alum_Tipo"].ToString();
                    alumno.Alumn_fechInscripcion = DateTime.Parse(dr["Alum_FechInscripcion"].ToString());
                    alumno.Alumn_dni = dr["Alum_DNI"].ToString();
                    alumno.Alumn_ApoderadoNombre = dr["Alum_ApoderadoNombre"].ToString();
                    alumno.Alumn_ApoderadoApellido = dr["Alum_ApoderadoApePaterno"].ToString();
                    alumno.Alumn_ApoderadoMaterno = dr["Alum_ApoderadoApeMaterno"].ToString();
                    alumno.Alumn_Pension = float.Parse(dr["Alum_Pension"].ToString());
                    alumno.Alumn_Estado = dr["Alum_Estado"].ToString();
                    alumno.Alum_Correo = dr["Alum_Correo"].ToString();
                    alumno.Alum_Telefono = dr["Alum_Telefono"].ToString();

                    aux.Add(alumno);


                }
            }
            catch (Exception e) { throw e; }
            finally
            {
                cmd.Connection.Close();

            }


            return aux !=null ? aux : null;
        }
        #endregion metodos

    }
}
