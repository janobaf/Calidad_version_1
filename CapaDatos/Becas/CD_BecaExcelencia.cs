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
                        string consulta_sql = "insert into BecaPorPromedio values (";
                        consulta_sql += id.ToString() + ",";
                        consulta_sql += alumno.Alumn_nombre + ",";
                        consulta_sql += alumno.Alumn_ApellidoPaterno + ",";
                        consulta_sql += alumno.Alumn_ApellidoMaterno + ")";
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





        public List<E_ListadoBecados> ListaDeBeca()
        {
            E_ListadoBecados alumn = new E_ListadoBecados();
            List<E_ListadoBecados> lista = new List<E_ListadoBecados>();
            SqlConnection connection = Conexion.Instancia.Conectar();
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT BecaPorPromedio_Id, BecaPorPromedio_Nombre, BecaPorPromedio_ApellidoPaterno, BecaPorPromedio_ApellidoMaterno FROM BecaPorPromedio";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    alumn.BecaPorPromedio_Id = reader.GetInt32(0);
                    alumn.BecaPorPromedio_Nombre = reader.GetString(1);
                    alumn.BecaPorPromedio_ApellidoPaterno = reader.GetString(2);
                    alumn.BecaPorPromedio_ApellidoMaterno = reader.GetString(3);
                    lista.Add(alumn);
                }
                reader.Close();
                return lista;
            }
        }



















    }
}
