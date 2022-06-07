using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Alumno;
using CapaEntidad.Becas;
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
        private int id_automatico()
        {
            // !se declara null el sqlcomand 
            int id = 0;
            bool validar = false;
            SqlCommand cmd = null;
            try
            {
                //!Se llama a la Conexion dentro de CapaDatos 
                //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                string Consulta_sql = "select max(BecaPorPromedio_id) BecaPorPromedio_id from BecaPorPromedio ";
                cmd = new SqlCommand(Consulta_sql, cn);
                // ! Se abre la conexion

                cn.Open();
                // !Se ejecuta la consulta 

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["BecaPorPromedio_id"].ToString() != "") validar = true;
                    if (validar == true) id = int.Parse(dr["BecaPorPromedio_id"].ToString());
                    break;
                }
            }
            catch (Exception f) { throw f; }
            finally
            {
                cmd.Connection.Close();

            }
            return validar == true ? id + 1 : -1;
        }

        private E_Alumno Beca_por_promedio(string dni)
        {
            E_Alumno alumno = new E_Alumno();
            SqlCommand cmd = null;
            try
            {
                //!Se llama a la Conexion dentro de CapaDatos 
                //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                string Consulta_sql = "select Alum_Nombre,Alum_ApellidoPaterno,Alum_ApellidoMaterno from Alumno where Alum_DNI =";
                Consulta_sql += dni;
                cmd = new SqlCommand(Consulta_sql, cn);
                // ! Se abre la conexion

                cn.Open();
                // !Se ejecuta la consulta 

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    alumno.Alumn_nombre = dr["Alum_Nombre"].ToString();
                    alumno.Alumn_ApellidoPaterno = dr["Alum_ApellidoPaterno"].ToString();
                    alumno.Alumn_ApellidoMaterno = dr["Alum_ApellidoMaterno"].ToString();

                    break;
                }
            }
            catch (Exception f) { throw f; }
            finally
            {
                cmd.Connection.Close();

            }

            return alumno != null ? alumno : null;

        }
        private void enlazar_beca(string dni)
        {

            SqlCommand cmd = null;

            try
            {
                //!Se llama a la Conexion dentro de CapaDatos 
                //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql


                int id = this.id_automatico();
                if (id != -1)
                {
                    E_Alumno alumno = this.Beca_por_promedio(dni);
                    if(alumno != null )
                    {
                        string consulta_sql = "SET IDENTITY_INSERT BecaPorPromedio on;";
                        consulta_sql += "insert into BecaPorPromedio (BecaPorPromedio_id,BecaPorPromedio_Nombre,BecaPorPromedio_ApellidoPaterno,BecaPorPromedio_ApellidoMaterno) values (";
                        consulta_sql += id + ",";
                        consulta_sql += "'"+alumno.Alumn_nombre + "',";
                        consulta_sql += "'"+alumno.Alumn_ApellidoPaterno + "', ";
                        consulta_sql += "'"+ alumno.Alumn_ApellidoMaterno + "' )";
                        consulta_sql += "SET IDENTITY_INSERT BecaPorPromedio Off;";

                        cmd = new SqlCommand(consulta_sql, cn);
                        // ! Se abre la conexion

                        cn.Open();
                        // !Se ejecuta la consulta 
                        cmd.ExecuteNonQuery();
                    }
                   
                }

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
            
                try
                {
                    //!Se llama a la Conexion dentro de CapaDatos 
                    //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                    SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                string sql = "SET IDENTITY_INSERT Alumno ON;";
                    sql +="update Alumno set Alum_Pension=Alum_Pension -(Alum_Pension *0.6) where Alum_DNI =";
                    sql += dni;
                sql += "SET IDENTITY_INSERT Alumno Off;";
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
            
            //!Retornar el resultado final
            return validar;


    
        }


        public E_Alumno Obtener_Alumno_Exelencia(string dni)
        {
            SqlCommand cmd = null;
            E_Alumno aux = new E_Alumno();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql_consulta = "select b.BecaPorPromedio_Nombre, b.BecaPorPromedio_ApellidoPaterno, b.BecaPorPromedio_ApellidoMaterno from Alumno a inner join BecaPorPromedio b on a.BeccaPorPromedio_id=b.BecaPorPromedio_id";
                sql_consulta += "where a.Alum_DNI=" + dni + ";";
                cmd = new SqlCommand(sql_consulta, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["b.BecaPorPromedio_Nombre"].ToString() != " " && dr["b.BecaPorPromedio_ApellidoPaterno"].ToString() != " " && dr["b.BecaPorPromedio_ApellidoMaterno"].ToString() != " ")
                    {
                        aux.Alumn_nombre = dr["b.BecaPorPromedio_Nombre"].ToString();
                        aux.Alumn_ApellidoPaterno = dr["b.BecaPorPromedio_ApellidoPaterno"].ToString();
                        aux.Alumn_ApellidoMaterno = dr["b.BecaPorPromedio_ApellidoMaterno"].ToString();
                        break;
                    }
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return aux != null ? aux : null;

        }

        public List<E_BecaPorPromedio> ListaDeBeca()
        {

            List<E_BecaPorPromedio> lista = new List<E_BecaPorPromedio>();
            SqlConnection connection = Conexion.Instancia.Conectar();
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT BecaPorPromedio_Id, BecaPorPromedio_Nombre, BecaPorPromedio_ApellidoPaterno, BecaPorPromedio_ApellidoMaterno FROM BecaPorPromedio";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    E_BecaPorPromedio alumn = new E_BecaPorPromedio();
                    alumn.BecaPorPromedio_id = reader.GetInt32(0);
                    alumn.BecaPorPromedioNombre = reader.GetString(1);
                    alumn.BecaPorPromedioApellido_Paterno = reader.GetString(2);
                    alumn.BecaPorPromedioApellido_Materno = reader.GetString(3);
                    lista.Add(alumn);
                }
                reader.Close();
            }
            return lista !=null ? lista:null;

        }

        #endregion metodos
    }
}
