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
        // !funcion privada para poder enlazar una tabla con otra 
        // @param dni ingresa el dni para validar 
        // ? El dni deve de tener 8 digitos y deve de ser numerico
        private void enlazar_Becas(string dni)
        {
            // !Se crea una variable tipo commandsql y se inicializa en null

            SqlCommand cmd = null;

            try
            {
                /*!
                      * Se llama a la Conexion dentro de CapaDatos 
                      *La clase Conexion nos devuelve una instancia y se guarda en la variable  cn
                     */
                SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql
                string sql = "update Alumno a , Alum_Beca ab set a.Alumn_BecaSeleccionada='BecaHermano' and ab.Alum_ID=a.Alum_ID  where a.Alumn_DNI =";
                // @param sql+ se le agrega al final de la cadena una variable dni
                sql += dni;
                cmd = new SqlCommand(sql, cn);
                //!Abre la conexion
                cn.Open();
                //!Se ejecuta la consulta
                cmd.ExecuteNonQuery();

            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); } // !Cierra la conexion
        }

        //!Funcion para mostrar un alumno especifico 
        //@param  DNI se pasa el dni 
        //?EL dni deve de tener 8 digitos y deve de ser numerico 
        //@param return retorna un alumno
        private E_Alumno Mostrar(string DNI)
        {
            //!Se crea una class auxiliar de la CLASEENTIDAD.Alumno
            E_Alumno alumno = new E_Alumno();
            // !Se crea una variable tipo commandsql y se inicializa en null
            SqlCommand cmd = null;
            try
            {
                /*!
                      * Se llama a la Conexion dentro de CapaDatos 
                      *La clase Conexion nos devuelve una instancia y se guarda en la variable  cn
                     */
                SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql
                string sql = "select Alumn_ApellidoPaterno , Alumn_ApellidoMaterno from Alumnos where Alumn_DNI=";
                // @param sql+ se le agrega al final de la cadena una variable dni
                sql += DNI;
                cmd = new SqlCommand(sql, cn);
                cn.Open();

                //!Ejecuta la consulta
                SqlDataReader dr = cmd.ExecuteReader();
                //!Se lee los datos obtenidos de la consulta

                while (dr.Read())
                {
                    //!Se pasa cada variable obtenida y se guarda en una variable dependiente de la clase alumno
                    alumno.Alumn_ApellidoPaterno = dr["Alumn_ApellidoPaterno"].ToString();
                    alumno.Alumn_ApellidoMaterno = dr["Alumn_ApellidoMaterno"].ToString();
               
                }
                //!Se llama a la funcion  y se pasa el parametro DNI
                this.enlazar_Becas(DNI);
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); } //!Finaliza la conexion
          // ! Condiciona que el alumno no este vacio si esta vacio retorna null si no retorna  el alumno

            return alumno !=null? alumno:null;
        }

        //!Funcion donde permite modificar el alumno dependiendo del dni
        // @param Dni parametro que recibe la funcion 
        // ?El dni deve ser un string deve de tener 8 digitos y deve de ser numerico
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
