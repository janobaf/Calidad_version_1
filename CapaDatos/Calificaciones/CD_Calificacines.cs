using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad.Calificaciones;
using CapaDatos.Alumnos;
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
        /* TODO 
         * 1 -> Crear funcion para crear calificaciones  -> Sin funcionamiento (30%)   
         * 2 -> Crear calificaciones generales -> sin funcionamiento 
         * 3 -> crear calificaciones por dni -> funcionando
         * 4 -> Modificar calificaciones -> sin funcionamiento
         * 5 -> Eliminar calificaciones -> sin funcionamiento 
         *
         */

        /* ! PARA CREAR CALIFICACION DEVE EXISTIR EL ALUMNO -->>Capa Logica
         *  
         * E_Calificaciones
         */
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

                string Consulta_sql = "select max(Califi_ID) Califi_ID from Calificaciones ";
                cmd = new SqlCommand(Consulta_sql, cn);
                // ! Se abre la conexion

                cn.Open();
                // !Se ejecuta la consulta 

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["Califi_ID"].ToString() != "") validar = true;
                    if (validar == true)  id = int.Parse(dr["Califi_ID"].ToString());
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

        private void enlazar_curso(string dni,int id)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Enlazar_Curso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@id", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
            finally{cmd.Connection.Close(); }
        }
        public bool crear_calificaciones(string dni, E_Calificaciones e)
        {

            bool validar = false;
            SqlCommand cmd = null;
            try
            {
                int id = this.id_automatico();
                if (id != -1)
                {
                    e.Califi_ID = id;
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("Crear_Calificaciones", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Califi_ID", e.Califi_ID);
                    cmd.Parameters.AddWithValue("@Califi_Parcial1", e.Califi_Parcial1);
                    cmd.Parameters.AddWithValue("@Califi_Parcial2", e.Califi_Parcial2);
                    cmd.Parameters.AddWithValue("@Califi_final", e.Califi_Final);
                    cmd.Parameters.AddWithValue("@Califi_Trabajos", e.Califi_Trabajos);
                    cmd.Parameters.AddWithValue("@Califi_Promedio", e.Califi_Promedio);

                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        validar = true;
                        this.enlazar_curso(dni, e.Califi_ID);
                    }

                }

            }
            catch (Exception f) { throw f; }
            finally { cmd.Connection.Close(); }
            return validar;
        }


        public E_Calificaciones mostrar_calificaciones_dni(string dni)
        {
            E_Calificaciones aux = new E_Calificaciones();
            SqlCommand cmd = null;
            try
            {
                //!Se llama a la Conexion dentro de CapaDatos 
                //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                string Consulta_sql = "select ca.Califi_Promedio,ca.Califi_Parcial1,ca.Califi_Parcial2,ca.Califi_Final,ca.Califi_Trabajos from Alumno a inner join Curso c on c.Alum_ID = a.Alum_ID inner join Calificaciones ca on ca.Califi_ID = c.Califi_ID where a.Alum_DNI =";
                Consulta_sql += dni;
                cmd = new SqlCommand(Consulta_sql, cn);
                // ! Se abre la conexion

                cn.Open();
                // !Se ejecuta la consulta 

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    aux.Califi_Promedio = float.Parse(dr["Califi_Promedio"].ToString());
                    aux.Califi_Parcial1 = float.Parse(dr["Califi_Parcial1"].ToString());
                    aux.Califi_Parcial2 = float.Parse(dr["Califi_Parcial2"].ToString());
                    aux.Califi_Final = float.Parse(dr["Califi_Final"].ToString());
                    aux.Califi_Trabajos = float.Parse(dr["Califi_Trabajos"].ToString());

                    break;
                }
            }
            catch (Exception f) { throw f; }
            finally
            {
                cmd.Connection.Close();

            }

            return aux != null ? aux : null;
        }

        public bool modificar_calificacion_parcial1(E_Calificaciones calificaciones , string dni)
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

                    string sql = "update Calificaciones set ca.Califi_Parcial1=";
                    sql += calificaciones.Califi_Parcial1+" ";
                    sql += "from Alumno a inner join Curso c on  c.Alum_ID = a.Alum_ID inner join Calificaciones ca on ca.Curso_ID=c.Curso_ID where a.Alum_DNI=";
                    sql += dni;
                    cmd = new SqlCommand(sql, cn);
                    // ! Se abre la conexion

                    cn.Open();
                    // !Se ejecuta la consulta 
                    int i = cmd.ExecuteNonQuery();
                    //!Si se ejecuto con exito deve de devolver una valor entero mayor a 0
                    if (i > 0) { validar = true;  } //!Cambiamos el bool a true y llamamos a una funcion
                }
                catch (Exception e) { throw e; }
                finally { cmd.Connection.Close(); } //!Cerramos la conexion
            }
            //!Retornar el resultado final
            return validar;
        }

        public bool modificar_calificacion_parcial2(E_Calificaciones calificaciones, string dni)
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

                    string sql = "update Calificaciones set ca.Califi_Parcial2=";
                    sql += calificaciones.Califi_Parcial2 + " ";
                    sql += "from Alumno a inner join Curso c on  c.Alum_ID = a.Alum_ID inner join Calificaciones ca on ca.Curso_ID=c.Curso_ID where a.Alum_DNI=";
                    sql += dni;
                    cmd = new SqlCommand(sql, cn);
                    // ! Se abre la conexion

                    cn.Open();
                    // !Se ejecuta la consulta 
                    int i = cmd.ExecuteNonQuery();
                    //!Si se ejecuto con exito deve de devolver una valor entero mayor a 0
                    if (i > 0) { validar = true; } //!Cambiamos el bool a true y llamamos a una funcion
                }
                catch (Exception e) { throw e; }
                finally { cmd.Connection.Close(); } //!Cerramos la conexion
            }
            //!Retornar el resultado final
            return validar;
        }


        public bool modificar_calificacion_Trabajos(E_Calificaciones calificaciones, string dni)
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

                    string sql = "update Calificaciones set ca.Califi_Trabajos=";
                    sql += calificaciones.Califi_Trabajos + " ";
                    sql += "from Alumno a inner join Curso c on  c.Alum_ID = a.Alum_ID inner join Calificaciones ca on ca.Curso_ID=c.Curso_ID where a.Alum_DNI=";
                    sql += dni;
                    cmd = new SqlCommand(sql, cn);
                    // ! Se abre la conexion

                    cn.Open();
                    // !Se ejecuta la consulta 
                    int i = cmd.ExecuteNonQuery();
                    //!Si se ejecuto con exito deve de devolver una valor entero mayor a 0
                    if (i > 0) { validar = true; } //!Cambiamos el bool a true y llamamos a una funcion
                }
                catch (Exception e) { throw e; }
                finally { cmd.Connection.Close(); } //!Cerramos la conexion
            }
            //!Retornar el resultado final
            return validar;
        }


        public bool modificar_calificacion_Final(E_Calificaciones calificaciones, string dni)
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

                    string sql = "update Calificaciones set ca.Califi_Final=";
                    sql += calificaciones.Califi_Final + " ";
                    sql += "from Alumno a inner join Curso c on  c.Alum_ID = a.Alum_ID inner join Calificaciones ca on ca.Curso_ID=c.Curso_ID where a.Alum_DNI=";
                    sql += dni;
                    cmd = new SqlCommand(sql, cn);
                    // ! Se abre la conexion

                    cn.Open();
                    // !Se ejecuta la consulta 
                    int i = cmd.ExecuteNonQuery();
                    //!Si se ejecuto con exito deve de devolver una valor entero mayor a 0
                    if (i > 0) { validar = true; } //!Cambiamos el bool a true y llamamos a una funcion
                }
                catch (Exception e) { throw e; }
                finally { cmd.Connection.Close(); } //!Cerramos la conexion
            }
            //!Retornar el resultado final
            return validar;
        }



        public bool modificar_calificacion_Promedio(E_Calificaciones calificaciones, string dni)
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

                    string sql = "update Calificaciones set ca.Califi_Promedio=";
                    sql += calificaciones.Califi_Promedio + " ";
                    sql += "from Alumno a inner join Curso c on  c.Alum_ID = a.Alum_ID inner join Calificaciones ca on ca.Curso_ID=c.Curso_ID where a.Alum_DNI=";
                    sql += dni;
                    cmd = new SqlCommand(sql, cn);
                    // ! Se abre la conexion

                    cn.Open();
                    // !Se ejecuta la consulta 
                    int i = cmd.ExecuteNonQuery();
                    //!Si se ejecuto con exito deve de devolver una valor entero mayor a 0
                    if (i > 0) { validar = true; } //!Cambiamos el bool a true y llamamos a una funcion
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


