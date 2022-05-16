using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Alumno;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos.Alumnos
{
    public class CD_Alumno
    {
        #region Singleton
        private static readonly CD_Alumno _instancia = new CD_Alumno();
        public static CD_Alumno Instancia
        {
            get { return CD_Alumno._instancia; }
        }
        #endregion
        #region metodos

        public bool validar_dni(string dni)

        {

            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("select Alum_DNI from Alumno", cn);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dni == dr["Alum_DNI"].ToString())
                {
                    cmd.Connection.Close();
                    return true;
                }
            }
            cmd.Connection.Close();

            return false;
        }

        public List<E_Alumno> mostrar_alumnos ()
        {
            List<E_Alumno> aux = new List<E_Alumno>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "select * from Alumno";
                
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
                   // alumno.Alumn_BecaSeleccionada = dr["Alumn_BecaSeleccionada"].ToString();
                    alumno.Alumn_Pension = float.Parse(dr["Alumn_Pension"].ToString());
                    aux.Add(alumno);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            
            
            return aux;

        }


        public E_Alumno mostrar_alumno_dni (string dni)
        {

            if (this.validar_dni(dni))
            {
                E_Alumno alumno = new E_Alumno();

                SqlCommand cmd = null;
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    string sql = "select * from Alumno where Alumn_DNI=";
                    sql += dni;

                    cmd = new SqlCommand(sql, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
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
                        alumno.Alumn_Grado = dr["Alumn_Grado"].ToString();
                        // alumno.Alumn_BecaSeleccionada = dr["Alumn_BecaSeleccionada"].ToString();
                        alumno.Alumn_Pension = float.Parse(dr["Alumn_Pension"].ToString());
                    }
                }
                catch (Exception e) { throw e; }
                finally { cmd.Connection.Close(); }

                if (alumno != null) return alumno;
                return null;
            }
            return null;
            #endregion metodos
        }
}
