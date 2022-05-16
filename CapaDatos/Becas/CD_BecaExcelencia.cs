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

        #region Singleton
        private static readonly CD_BecaExcelencia _instancia = new CD_BecaExcelencia();
        public static CD_BecaExcelencia Instancia
        {
            get { return CD_BecaExcelencia._instancia; }
        }

        #endregion
        #region metodos

        private void enlazar_Becas(string dni)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "update Alumno a , Alum_Beca ab set a.Alumn_BecaSeleccionada='BecaExelebcua' and ab.Alum_ID=a.Alum_ID  where a.Alumn_DNI =";
                sql += dni;
                cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception e) { throw e; }
            finally { cmd.Connection.Close(); }
        }
        public bool modificar_pension_aluno(string dni)
        {
            SqlCommand cmd = null;
            
            bool validar = false;

            if (CD_Alumno.Instancia.validar_dni(dni))
            {
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    string sql = "update Alumno set Alumno_Pension=Alumno_Pension -(Alumno_Pension *0.5) where Alumn_DNI =";
                    sql += dni;
                    cmd = new SqlCommand(sql, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    this.enlazar_Becas(dni);
                    if (i > 0) { validar = true; }
                }
                catch (Exception e) { throw e; }
                finally { cmd.Connection.Close(); }
            }
            
            return validar;
        }
        #endregion metodos
    }
}
