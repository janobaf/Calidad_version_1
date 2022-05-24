using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad.Calificaciones;
namespace CapaDatos.Calificaciones
{
    public class CD_Calificacines
    {
        #region Singleton

        private static readonly CD_Calificacines _instancia = new CD_Calificacines();
        public static CD_Calificacines Instancia
        {
            get { return CD_Calificacines._instancia; }
        }
        #endregion
        #region metodos

         public E_Calificaciones mostrar_calificaciones(string dni )
        {
            E_Calificaciones aux  = new E_Calificaciones();

            // !se declara null el sqlcomand 

            SqlCommand cmd = null;
            try
            {
                //!Se llama a la Conexion dentro de CapaDatos 
                //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                string Consulta_sql = "select c.* from Calificaciones c inner join Alumno a on a.Alum_ID = c.Califi_id where a.Alum_DNI=";
                Consulta_sql += dni;
                cmd = new SqlCommand(Consulta_sql, cn);
                // ! Se abre la conexion

                cn.Open();
                // !Se ejecuta la consulta 

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    aux.Califi_ID = Convert.ToInt32(dr["Califi_ID"].ToString());
                    aux.Califi_Promedio = float.Parse(dr["Califi_Promedio"].ToString());
                    aux.Curso_id = int.Parse(dr["Curso_id"].ToString());
                    aux.Califi_Parcial1 = float.Parse(dr["Califi_Parcial1"].ToString());
                    aux.Califi_Final = float.Parse(dr["Califi_Final"].ToString());
                    aux.Califi_Trabajos = float.Parse(dr["Califi_Trabajos"].ToString());
                    aux.Califi_Parcial2 = float.Parse(dr["Califi_Parcial2"].ToString());
                }
            }
            catch (Exception e) { throw e; }
            finally
            {
                cmd.Connection.Close();

            }

            return aux != null ? aux : null;

        }

        #endregion metodos
    }
}


