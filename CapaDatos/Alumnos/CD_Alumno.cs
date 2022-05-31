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
            bool validar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "select Alum_DNI from Alumno";

                cmd = new SqlCommand(sql, cn);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    if (dr["Alum_DNI"].ToString().Equals(dni))
                    {
                        validar = true;
                        break;
                    }

                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }



            return validar;
        }


        public List<E_Alumno> mostrar_alumnos()
        {
            List<E_Alumno> aux = new List<E_Alumno>();

            SqlCommand cmd = null;
            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "select * from Alumno";

                cmd = new SqlCommand(sql, cn);
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
                    alumno.Alumn_dni = dr["Alum_dni"].ToString();
                    alumno.Alumn_ApoderadoNombre = dr["Alum_ApoderadoNombre"].ToString();
                    alumno.Alumn_ApoderadoApellido = dr["Alum_ApoderadoApePaterno"].ToString();
                    alumno.Alumn_ApoderadoMaterno = dr["Alum_ApoderadoApeMaterno"].ToString();
                    alumno.Alumn_Estado = dr["Alum_Estado"].ToString();
                    alumno.Alum_Correo = dr["Alum_Correo"].ToString();
                    alumno.Alum_Telefono = dr["Alum_Telefono"].ToString();
                    aux.Add(alumno);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }


            return aux != null ? aux : null;

        }

        public E_Alumno mostrar_alumno_dni(string dni)
        {

            E_Alumno alumno = new E_Alumno();

            SqlCommand cmd = null;
            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "select * from Alumno where Alum_DNI=";
                sql += dni;

                cmd = new SqlCommand(sql, cn);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    alumno.Alumn_nombre = dr["Alum_Nombre"].ToString();
                    alumno.Alumn_ApellidoPaterno = dr["Alum_ApellidoPaterno"].ToString();
                    alumno.Alumn_ApellidoMaterno = dr["Alum_ApellidoMaterno"].ToString();
                    alumno.Alumn_Direccion = dr["Alum_Direccion"].ToString();
                    alumno.Alumn_Fechnaci = DateTime.Parse(dr["Alum_FechNaci"].ToString());
                    alumno.Alumn_Tipo = dr["Alum_Tipo"].ToString();
                    alumno.Alumn_fechInscripcion = DateTime.Parse(dr["Alum_FechInscripcion"].ToString());
                    alumno.Alumn_dni = dr["Alum_dni"].ToString();
                    alumno.Alumn_ApoderadoNombre = dr["Alum_ApoderadoNombre"].ToString();
                    alumno.Alumn_ApoderadoApellido = dr["Alum_ApoderadoApePaterno"].ToString();
                    alumno.Alumn_ApoderadoMaterno = dr["Alum_ApoderadoApeMaterno"].ToString();
                    alumno.Alumn_Estado = dr["Alum_Estado"].ToString();
                    //alumno.Alumn_Pension = float.Parse(dr["Alum_Pension"].ToString());
                    alumno.Alum_Correo = dr["Alum_Correo"].ToString();
                    alumno.Alum_Telefono = dr["Alum_Telefono"].ToString();
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }

            return alumno != null ? alumno : null;
        }


        public int id_automatico()
        {
            int id = 0;
           


            E_Alumno alumno = new E_Alumno();

            SqlCommand cmd = null;
            try
            {
                
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "select Max(Alum_ID) Alum_ID from Alumno ";

                cmd = new SqlCommand(sql, cn);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["Alum_ID"].ToString());
                    break;
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); } 


            return id > 0 ? id + 1 : 0;
        }
    }

            #endregion metodos
     
}
