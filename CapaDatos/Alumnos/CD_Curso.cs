using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad.Curso;
namespace CapaDatos.Alumnos
{
    public class CD_Curso
    {
        /* TODO : CAPA DATOS CURSO
         *  @PARAM DEFECTO : E_Curso
         *  1 PASO : CREAR CURSO   
         *  
         */
        #region Singleton
        private static readonly CD_Curso _instancia = new CD_Curso();
        public static CD_Curso Instancia
        {
            get { return CD_Curso._instancia; }
        }
        #endregion
        #region metodos

        private int id_automatico()
        {
            int id = 0;
            SqlCommand cmd = null;
            bool validar = false;
            try
            {
                //!Se llama a la Conexion dentro de CapaDatos 
                //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                string Consulta_sql = "select max(Curso_ID) Curso_ID from Curso ";
                cmd = new SqlCommand(Consulta_sql, cn);
                // ! Se abre la conexion

                cn.Open();
                // !Se ejecuta la consulta 

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["Curso_ID"].ToString() != "") validar = true;
                    if (validar == true) id = int.Parse(dr["Curso_ID"].ToString());
                    break;
                }
            }

            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
            return validar == true ? id+1:-1 ;
        }
        public bool Crear_curso (E_Curso curso )
        {
            bool validar = false;
            SqlCommand cmd = null;
            try
            {
                int id = this.id_automatico();
                if (id != -1)
                {
                    curso.Curso_ID = id;
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("Crear_Curso", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Curso_ID", curso.Curso_ID);
                    cmd.Parameters.AddWithValue("@Curso_Nombre", curso.Curso_Nombre);
                    cmd.Parameters.AddWithValue("@Curso_Estado", curso.Curso_Estado);
                    cmd.Parameters.AddWithValue("@Curso_FechInscrip", curso.Curso_FecInscripcion);
                    cmd.Parameters.AddWithValue("@Curso_Descripcion", curso.Curso_Descripcion);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) validar = true;
                }

            }
            catch (Exception e) { throw e; }
            finally{ cmd.Connection.Close(); }
            return validar;
        }

        public List <E_Curso> listar_cursos()
        {
            List<E_Curso> listar_c = new List<E_Curso>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "select Curso_ID , Curso_Nombre , Curso_Estado , Curso_FecInscrip,Curso_Descripcion from Curso";
                cmd = new SqlCommand(sql, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    E_Curso curso = new E_Curso();
                    curso.Curso_ID = int.Parse(dr["Curso_ID"].ToString());
                    curso.Curso_Nombre = dr["Curso_Nombre"].ToString();
                    curso.Curso_Estado = dr["Curso_Estado"].ToString();
                    curso.Curso_FecInscripcion = DateTime.Parse(dr["FecIncripcion"].ToString());
                    curso.Curso_Descripcion = dr["Curso_Descripcion"].ToString();
                    listar_c.Add(curso);

                     
                }
            }
            catch (Exception e) { throw e; }
            finally
            {
                cmd.Connection.Close();

            }
            return listar_c != null ? listar_c : null;
        }
        #endregion metodos
    }
}
