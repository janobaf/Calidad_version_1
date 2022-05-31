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
    public class CD_BecaExcelencia
    {
        //!SEGUNDO CASO DE USO 
        #region Singleton
        private static readonly CD_BecaExcelencia _instancia = new CD_BecaExcelencia();
        public static CD_BecaExcelencia Instancia
        {
            get { return CD_BecaExcelencia._instancia; }
        }

        #endregion
        #region metodos


        //!Funcion para modificar la pension del alumno de la beca por excelencia 
        //@param dni de tipo string recibida por la funcion
        // ?El dnni deve de ser string con unos 8 digitos y deve ser numerico
        private void enlazar_beca(string dni)
        {

            SqlCommand cmd = null;

            try
            {
                //!Se llama a la Conexion dentro de CapaDatos 
                //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                string sql = "update Alumno set Nombre_beca=";
                sql += "Exelencia";
                sql+=" where Alumn_DNI =";
                sql += dni;
                cmd = new SqlCommand(sql, cn);
                // ! Se abre la conexion

                cn.Open();
                // !Se ejecuta la consulta 
                int i = cmd.ExecuteNonQuery();
                //!Si se ejecuto con exito deve de devolver una valor entero mayor a 0
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); } //!Cerramos la conexion
        }

    
        public bool modificar_pension_alumno(string dni)
        {
            // !se declara null el sqlcomand 

            SqlCommand cmd = null;
            // !Declaramos una variable bool por defecto en false 
            bool validar = false;

            /* !
             * Se llama a la funcion dentro de la capaDatos.Alumno
             * La funcion nos retorna si es true o false
             * Si es true entra en el if
            */
            if (CD_Alumno.Instancia.validar_dni(dni))
            {
                try
                {
                    //!Se llama a la Conexion dentro de CapaDatos 
                    //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                    SqlConnection cn = Conexion.Instancia.Conectar();
                    // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                    string sql = "update Alumno set Alumno_Pension=Alumno_Pension -(Alumno_Pension *0.5) where Alumn_DNI =";
                    sql += dni;
                    cmd = new SqlCommand(sql, cn);
                    // ! Se abre la conexion

                    cn.Open();
                    // !Se ejecuta la consulta 
                    int i = cmd.ExecuteNonQuery();
                    //!Si se ejecuto con exito deve de devolver una valor entero mayor a 0
                    if (i > 0) { validar = true; this.enlazar_beca(dni); } //!Cambiamos el bool a true 
                }
                catch (Exception e) { throw e; }
                finally { cmd.Connection.Close(); } //!Cerramos la conexion
            }
            //!Retornar el resultado final
            return validar;
        }
        #endregion metodos
    }
}
