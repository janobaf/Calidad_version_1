    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Alumno;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos.Inscripcion
{
    public class D_Crear_Inscripcion
    {

        #region Singleton
        private static readonly D_Crear_Inscripcion _instancia = new D_Crear_Inscripcion();
        public static D_Crear_Inscripcion Instancia
        {
            get { return D_Crear_Inscripcion._instancia; }
        }
        #endregion
        #region metodos


        public bool  Modificar_Alumnos_Inscripcion(E_Alumno ea)
        {
            SqlCommand cmd = null;
            bool validar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

             
                cmd = new SqlCommand("Modificar_Alumnos_Inscripcion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@correo", ea.Alum_Correo);
                cmd.Parameters.AddWithValue("@Direccion", ea.Alumn_Direccion);
                cmd.Parameters.AddWithValue("@telefono", ea.Alum_Telefono);
                cmd.Parameters.AddWithValue("@DNI", ea.Alumn_dni);
                
                
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) validar = true;
            } catch (Exception e) { throw e; }
             finally { cmd.Connection.Close(); }

            return validar;
           
        }
        public bool Crear_Alumnos_Inscripcion (E_Alumno ea)
        {
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            bool verificar = false;
            try
            {
                cmd = new SqlCommand("Alumno_Crear", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Alum_id", ea.Alum_ID);

                cmd.Parameters.AddWithValue("@Alum_Nombre", ea.Alumn_nombre);
                cmd.Parameters.AddWithValue("@Alum_ApellidoPaterno", ea.Alumn_ApellidoPaterno);
                cmd.Parameters.AddWithValue("@Alum_ApellidoMaterno", ea.Alumn_ApellidoMaterno);
                cmd.Parameters.AddWithValue("@Alum_Direccion", ea.Alumn_Direccion);
                cmd.Parameters.AddWithValue("@Alum_FechNaci", ea.Alumn_Fechnaci);
                cmd.Parameters.AddWithValue("@Alum_Tipo", ea.Alumn_Tipo);
                cmd.Parameters.AddWithValue("@Alum_FechInscripcion", ea.Alumn_fechInscripcion);
                cmd.Parameters.AddWithValue("@Alum_DNI", ea.Alumn_dni);
                cmd.Parameters.AddWithValue("@Alum_ApoderadoNombre", ea.Alumn_ApoderadoNombre);
                cmd.Parameters.AddWithValue("@Alum_ApoderadoApePaterno", ea.Alumn_ApoderadoApellido);
                cmd.Parameters.AddWithValue("@Alum_ApoderadoApeMaterno", ea.Alumn_ApoderadoMaterno);
                cmd.Parameters.AddWithValue("@Alum_Estado", ea.Alumn_Estado);
                cmd.Parameters.AddWithValue("@id", ea.Alum_ID);
                cmd.Parameters.AddWithValue("@Alum_Correo",ea.Alum_Correo);
                cmd.Parameters.AddWithValue("@Alum_Telefono", ea.Alum_Telefono);

                cn.Open();
                int i =cmd.ExecuteNonQuery();
                if(i>0) { verificar = true; }
            }

            catch (Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return verificar;
        }
        public List<E_Alumno> Listar_alumnos_Inscripcion()
        {
            List<E_Alumno> aux = new List<E_Alumno>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("select * from Alumno", cn);

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
            catch(Exception e) { throw e; }
            finally
            {
                cmd.Connection.Close();
            }


            return aux !=null ? aux:null;
        }


        public E_Alumno Listar_alumnos_DNI( string dni)
        {
            E_Alumno alumno = new E_Alumno();
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            string sql = "select* from Alumno where Alum_DNI =";
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
                alumno.Alum_Correo = dr["Alum_Correo"].ToString();
                alumno.Alum_Telefono = dr["Alum_Telefono"].ToString();


            }
            cmd.Connection.Close();

            return alumno != null ? alumno : null;
        }
        #endregion metodos
    }
}
