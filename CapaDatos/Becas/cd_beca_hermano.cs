using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad.Alumno;

namespace CapaDatos.Becas
{
    public class cd_beca_hermano
    {

        #region Singleton
        private static readonly cd_beca_hermano _instancia = new cd_beca_hermano();
        public static cd_beca_hermano Instancia
        {
            get { return cd_beca_hermano._instancia; }
        }

        #endregion
        #region metodos
        private void enlazar_Becas(string dni)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "update Alumno a , Alum_Beca ab set a.Alumn_BecaSeleccionada='BecaHermano' and ab.Alum_ID=a.Alum_ID  where a.Alumn_DNI =";
                sql += dni;
                cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
        }
        public E_Alumno Mostrar(string DNI)
        {
            E_Alumno alumno = new E_Alumno();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "select Alumn_ApellidoPaterno , Alumn_ApellidoMaterno from Alumnos where Alumn_DNI=";
                sql += DNI;
                cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    alumno.Alumn_ApellidoPaterno = dr["Alumn_ApellidoPaterno"].ToString();
                    alumno.Alumn_ApellidoMaterno = dr["Alumn_ApellidoMaterno"].ToString();
               
                }
                this.enlazar_Becas(DNI);
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            if (alumno != null)
                return alumno;
            return null;
        }
        public bool modificar_alumno(string dni)
        {

            SqlCommand cmd = null;
            bool validar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "update Alumno set Alumno_Pension=Alumno_Pension -(Alumno_Pension *0.25) where Alumn_DNI =";
                sql += dni;
                cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { validar= true; }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close();}
            return validar; 
        }
        public bool Beca_hermanos(string dni)
        {
            SqlCommand cmd = null;
            E_Alumno aux = this.Mostrar(dni);
            string Alum_ApellidoMaterno = "";
            string Alum_ApellidoPaterno = "";
            try
            {
                
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "select a.Alum_ApellidoMaterno ,a.Alum_ApellidoPaterno from Alumno a where a.Alum_DNI =";
                sql += dni;
                cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Alum_ApellidoMaterno = dr["Alum_ApellidoMaterno"].ToString();
                    Alum_ApellidoPaterno = dr["Alum_ApellidoPaterno"].ToString();
                }
            } catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }

            if (aux != null)           
                if ( aux.Alumn_ApellidoMaterno==Alum_ApellidoMaterno && aux.Alumn_ApellidoPaterno == Alum_ApellidoPaterno)
                    return true;
            return false;
        }
        #endregion metodos  
    }
}
