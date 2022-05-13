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

        public bool validar_dni(string dni )

        {

            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("select Alum_DNI from Alumno",cn);
             
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

        public void Modificar_Alumnos_Inscripcion(E_Alumno ea)
        {
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("Alumno_Editar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@N_Alum_ID", ea.Alum_ID);

            cmd.Parameters.AddWithValue("@Alum_Nombre", ea.Alumn_nombre);
            cmd.Parameters.AddWithValue("@Alum_ApellidoPaterno", ea.Alumn_ApellidoPaterno);
            cmd.Parameters.AddWithValue("@Alum_ApellidoMaterno", ea.Alumn_ApellidoMaterno);
            cmd.Parameters.AddWithValue("@Alum_Direccion", ea.Alumn_Direccion);
            cmd.Parameters.AddWithValue("@Alum_FechNaci", ea.Alumn_Fechnaci);
            cmd.Parameters.AddWithValue("@Alum_Tipo", ea.Alumn_Tipo);
            cmd.Parameters.AddWithValue("@@Alum_FechInscripcion", ea.Alumn_fechInscripcion);
            cmd.Parameters.AddWithValue("@Alum_DNI", ea.Alumn_dni);
            cmd.Parameters.AddWithValue("@Alum_ApoderadoNombre", ea.Alumn_ApoderadoNombre);
            cmd.Parameters.AddWithValue("@Alum_ApoderadoApePaterno", ea.Alumn_ApoderadoApellido);
            cmd.Parameters.AddWithValue("@Alum_ApoderadoApeMaterno", ea.Alumn_ApoderadoMaterno);
            cmd.Parameters.AddWithValue("@Alum_Estado", ea.Alumn_Estado);
            cn.Open();
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }
        public void Crear_Alumnos_Inscripcion (E_Alumno ea)
        {
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("Alumno_Crear",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Alum_Nombre", ea.Alumn_nombre);
            cmd.Parameters.AddWithValue("@Alum_ApellidoPaterno", ea.Alumn_ApellidoPaterno);
            cmd.Parameters.AddWithValue("@Alum_ApellidoMaterno", ea.Alumn_ApellidoMaterno);
            cmd.Parameters.AddWithValue("@Alum_Direccion", ea.Alumn_Direccion);
            cmd.Parameters.AddWithValue("@Alum_FechNaci", ea.Alumn_Fechnaci);
            cmd.Parameters.AddWithValue("@Alum_Tipo", ea.Alumn_Tipo);
            cmd.Parameters.AddWithValue("@@Alum_FechInscripcion", ea.Alumn_fechInscripcion);
            cmd.Parameters.AddWithValue("@Alum_DNI", ea.Alumn_dni);
            cmd.Parameters.AddWithValue("@Alum_ApoderadoNombre", ea.Alumn_ApoderadoNombre);
            cmd.Parameters.AddWithValue("@Alum_ApoderadoApePaterno", ea.Alumn_ApoderadoApellido);
            cmd.Parameters.AddWithValue("@Alum_ApoderadoApeMaterno", ea.Alumn_ApoderadoMaterno);
            cmd.Parameters.AddWithValue("@Alum_Estado", ea.Alumn_Estado);
            cmd.Parameters.AddWithValue("@Alum_Grado", ea.Alumn_Grado);
            cmd.Parameters.AddWithValue("@id", ea.Alum_ID);

            cn.Open();
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }
        public List<E_Alumno> Listar_alumnos_Inscripcion(string DNI)
        {
            List<E_Alumno> aux = new List<E_Alumno>();
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("Alumno_Mostrar" , cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Alum_Dni", DNI);
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

            return aux;
        }
        #endregion metodos
    }
}
