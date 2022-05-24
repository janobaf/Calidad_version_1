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
        

        // !Funcion donde validamos la existencia de un dni en la tabla Alumno dentro del sql
        // @Param dni pasamos de tipo Dni
        // ?El dni deve de contener solo 8 digitos y deve de contener solo numeros 
        // @Param return Retorna true o false 
        public bool validar_dni(string dni)

        {
            // ! se crea una variable de tipo int 
            int aux;
            /* !
                * Se crea una variable  de tipo booleano que nos asegura si la cadena es 
                *   numerico todo el string  devuelve true o false 
              */
            bool resultado = Int32.TryParse(dni, out aux);
            // ! si el resultado es true entra 
            if (resultado && dni.Length == 8)
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
                    cmd = new SqlCommand("select Alum_DNI from Alumno", cn);
                    //!Se abre la conexion
                    cn.Open();
                    // !Se ejecuta la consulta
                    SqlDataReader dr = cmd.ExecuteReader();
                    // !Se lee los datos que envia el sql 

                    while (dr.Read())
                    {
                        /* !
                            * La informacion obtenida del sql se pasa a las variables locales 
                            * Si el dni que se obtuvo es igual a la  variable dni 
                            */
                        if (dni == dr["Alum_DNI"].ToString())
                        {
                            //!Se cierra la conexion
                            cmd.Connection.Close();
                            //!Retorna true 
                            return true;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {                            
                    //!Se cierra la conexion

                    cmd.Connection.Close();

                }
            }
            //!Retorna False

            return false;
        }
        //!Funcion para mostrar los alumnos 
        //!@param return retornar una variable aux
        //!Retorna una lista de alumnos
        public List<E_Alumno> mostrar_alumnos ()
        {
            //!se crea una variable de tipo auxiliar que es una lista 
            List<E_Alumno> aux = new List<E_Alumno>();
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
                string sql = "select * from Alumno";
                
                cmd = new SqlCommand(sql, cn);
                //Se abre la conexion
                cn.Open();
                // !Se ejecuta la consulta

                SqlDataReader dr = cmd.ExecuteReader();
                //!Se lee los datos obtenidos de la consulta
                while (dr.Read())
                {
                    //!Se crea una variable auxiliar de tipo alumno
                    E_Alumno alumno = new E_Alumno();
                    //!Se pasa cada variable obtenida y se guarda en una variable dependiente de la clase alumno
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
                   // ?alumno.Alumn_BecaSeleccionada = dr["Alumn_BecaSeleccionada"].ToString();
                    alumno.Alumn_Pension = float.Parse(dr["Alumn_Pension"].ToString());
                    alumno.Alum_Correo = dr["Alum_Correo"].ToString();
                    alumno.Alum_Telefono = dr["Alum_Telefono"].ToString();
                    //!Guarda en la lista 
                    aux.Add(alumno);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); } // !Se cierra la conexion
            
            
            //!Se valida si no es vacio la lista
            //!Si no esta vacio retorna la lista 
            //!Si esta vacio retorna null
            return aux !=null ? aux:null; 

        }

        // !Funcion donde mostramos al alumno por dni 
        // @Param dni variable de tipo string 
        // ?El dni deve de tener 8 digitos y deve de ser numerico
        // @Param return se retorna el alumno
        public E_Alumno mostrar_alumno_dni(string dni)
        {
            //!Llama a la funcion validar 
            //@param dni se pasa el parametro a la funcion
            //!devuelve true o false 
            if (this.validar_dni(dni))
            {
                /*!
                    * si es verdadero el alumno 
                    * Se crea una variable auxiliar de tipo E_alumno
                    */
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
                    string sql = "select * from Alumno where Alum_DNI=";
                    // @param sql+ se le agrega al final de la cadena una variable dni
                    sql += dni;

                    cmd = new SqlCommand(sql, cn);
                    //!Se abre la conexion

                    cn.Open();
                    //!Se ejecuta la consulta
                    SqlDataReader dr = cmd.ExecuteReader();
                    //!Se lee los datos obtenidos de la consulta

                    while (dr.Read())
                    {
                        //!Se pasa cada variable obtenida y se guarda en una variable dependiente de la clase alumno

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
                        //? alumno.Alumn_BecaSeleccionada = dr["Alumn_BecaSeleccionada"].ToString();
                        alumno.Alumn_Pension = float.Parse(dr["Alum_Pension"].ToString());
                        alumno.Alum_Correo = dr["Alum_Correo"].ToString();
                        alumno.Alum_Telefono = dr["Alum_Telefono"].ToString();
                    }
                }
                catch (Exception e) { throw e; }
                finally { cmd.Connection.Close(); } //!Finaliza la conexion

                // ! Condiciona que el alumno no este vacio si esta vacio retorna null si no retorna  el alumno
                return alumno != null ? alumno : null;
            }
            //!Si es falso retorna null
            return null;
        }

        public int id_automatico(string dni)
        {
            int id = 0;
            //!Llama a la funcion validar 
            //@param dni se pasa el parametro a la funcion
            //!devuelve true o false 
            if (this.validar_dni(dni))
            {
                /*!
                    * si es verdadero el alumno 
                    * Se crea una variable auxiliar de tipo E_alumno
                    */
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
                    string sql = "select Max(Alum_id) from Alumno where Alum_DNI=";
                    // @param sql+ se le agrega al final de la cadena una variable dni
                    sql += dni;

                    cmd = new SqlCommand(sql, cn);
                    //!Se abre la conexion

                    cn.Open();
                    //!Se ejecuta la consulta
                    SqlDataReader dr = cmd.ExecuteReader();
                    //!Se lee los datos obtenidos de la consulta

                    while (dr.Read())
                    {
                        //!Se pasa cada variable obtenida y se guarda en una variable dependiente de la clase alumno
                        id= Convert.ToInt32(dr["ID"].ToString());
                    }
                }
                catch (Exception e) { throw e; }
                finally { cmd.Connection.Close(); } //!Finaliza la conexion

                // ! Condiciona que el alumno no este vacio si esta vacio retorna null si no retorna  el alumno
            }
            //!Si es falso retorna null
            return id>0? id:0;
        }
            #endregion metodos
     }
}
