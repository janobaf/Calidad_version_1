using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Alumno;
using CapaDatos.Alumnos;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos.Becas
{
    public class CD_BecaHijoTrabajador
    {
        #region Singleton
        private static readonly CD_BecaHijoTrabajador _instancia = new CD_BecaHijoTrabajador();
        public static CD_BecaHijoTrabajador Instancia
        {
            get { return CD_BecaHijoTrabajador._instancia; }
        }

        #endregion
        #region metodos


        // !Creamos una funcion donde nos valide  que un usuario sea el hijo de un docente
        // ? Solo  se acepta el dni en string ,  deve de contener 8 numeros
        // !qparam  DNI  nos pasa el dni del usuario 
        // !@param returns nos retorna true o false 
        public bool Validar_hijo_docente(string DNI)
        {
            // ! Se crea una variable booleana para  validar 
            bool validar = false;
            // ! se crea una variable tipo int 
            int aux;
            // ! Se crea una variable  de tipo booleano que nos asegura si la cadena es 
            // ! numerico todo el string  devuelve true o false 
            bool resultado = Int32.TryParse(DNI, out aux);
            // ! si el resultado es true entra 
            if(resultado && DNI.Length==8)
            {
                // ! Se llama a la capaDatosAlumno y su funcion validar dni
                // @param DNI se le envia el dni a la funcion 
                // ? El dni deve de ser 8 digitos y numerico
                // !La funcion devuelve true o false 
                if (CD_Alumno.Instancia.validar_dni(DNI))
                {
                    // !se crea una variable auxiliar de la CapaEntidad.Alumno
                    // !Se llama A la CapaDatosAlumnos donde retorna todos los alumnos depende del dni
                    // @param dni pasamos el dni
                    E_Alumno alumno = CD_Alumno.Instancia.mostrar_alumno_dni(DNI);
                    // !se crea dos variables de tipo string y declarandose como vacios 
                    string apellido_paterno = "";
                    string apellido_materno = "";
                    // !se declara null el sqlcomand 
                    SqlCommand cmd = null;
                    try
                    {
                        //!Se llama a la Conexion dentro de CapaDatos 
                        //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn
                       
                        SqlConnection cn = Conexion.Instancia.Conectar();
                        // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                        string sql = "select Prof_ApellidoPaterno,Prof_ApellidoMaterno from profesor ";
                   
                        cmd = new SqlCommand(sql, cn);
                        // ! Se abre la conexion
                        cn.Open();
                        // !Se ejecuta la consulta 
                        SqlDataReader dr = cmd.ExecuteReader();
                        // !Se lee los datos que envia el sql 
                        while (dr.Read())
                        {
                            // !La informacion obtenida del sql se pasa a las variables locales 
                            apellido_paterno = dr["Prof_ApellidoPaterno"].ToString();
                            apellido_materno = dr["Prof_ApellidoMaterno"].ToString();
                        }
                    }
                    
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        //!Finalisa la conexion  y la cierra 
                        cmd.Connection.Close();

                    }
                    /*!
                     * Valida si el apellidomaterno del alumno es igual al apellidomaterno del profesor
                        *!O
                    * Valida si el apellidoPaterno del alumno es igual al apellidoPaterno del profesor

                    */
                    if (apellido_materno.Equals(alumno.Alumn_ApellidoMaterno) || apellido_paterno.Equals(alumno.Alumn_ApellidoPaterno))
                        // !Si entra cambia la variable validar a true 
                        validar = true;
                }

            }

            //!Retorna el resultado de validar 
            return validar;
        }

        private  bool relacionar_beca(string dni)
        {
            // ! Se crea una variable booleana para  validar 
            bool validar = false;
            // ! se crea una variable tipo int 
            int aux;
            // ! Se crea una variable  de tipo booleano que nos asegura si la cadena es 
            // ! numerico todo el string  devuelve true o false 
            bool resultado = Int32.TryParse(dni, out aux);
            // ! si el resultado es true entra 
            if (resultado && dni.Length == 8)
            {
                // !se declara null el sqlcomand 
                SqlCommand cmd = null;
                try
                {
                    //!Se llama a la Conexion dentro de CapaDatos 
                    //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                    SqlConnection cn = Conexion.Instancia.Conectar();
                    // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                    string sql = "update Alum_Beca ab set ab.Alum_ID=a.Alum_ID  from Alumno a where Alum_DNI=";
                    sql += dni;

                    cmd = new SqlCommand(sql, cn);
                    // ! Se abre la conexion
                    cn.Open();
                    // !Se ejecuta la consulta 
                    cmd.ExecuteNonQuery();
                    // !Se cambia el estado de false  a true
                    validar = true;

                }

                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    //!Finalisa la conexion  y la cierra 
                    cmd.Connection.Close();

                }
            }

            return validar;
        }

        // !Funcion booleana para modificar la pension del alumno  de beca por hijoTrabajador
        // @Param dni  se recive el dni
        // ? El parametro dni de tipo string debe de tener una longitud de 8 digitos  y deve de ser numerico
        public bool modificar_pension(string dni)
        {
            // ! Se crea una variable booleana para  validar 
            bool validar = false;
            // ! se crea una variable tipo int 
            int aux;
            // ! Se crea una variable  de tipo booleano que nos asegura si la cadena es 
            // ! numerico todo el string  devuelve true o false 
            bool resultado = Int32.TryParse(dni, out aux);
            // ! si el resultado es true entra 
            if (resultado && dni.Length == 8)
            {
                // ! Se llama a la capaDatosAlumno y su funcion validar dni
                // @param DNI se le envia el dni a la funcion 
                // ? El dni deve de ser 8 digitos y numerico
                // !La funcion devuelve true o false 
                if (CD_Alumno.Instancia.validar_dni(dni))
                {

                    // !se declara null el sqlcomand 
                    SqlCommand cmd = null;
                    try
                    {
                        //!Se llama a la Conexion dentro de CapaDatos 
                        //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                        SqlConnection cn = Conexion.Instancia.Conectar();
                        // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                        string sql = "update Alumno set Alum_Pension = Alum_Pension-(Alum_Pension-0.3) where Alum_DNI=";
                        sql += dni;

                        cmd = new SqlCommand(sql, cn);
                        // ! Se abre la conexion
                        cn.Open();
                        // !Se ejecuta la consulta 
                        cmd.ExecuteNonQuery();
                        // !Se cambia el estado de false  a true
                        validar = true;
                        this.relacionar_beca(dni);
                    }

                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        //!Finalisa la conexion  y la cierra 
                        cmd.Connection.Close();

                    }
                }
            }
                return validar; 
        }
        #endregion metodos
    }
}
