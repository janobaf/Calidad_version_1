using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CapaEntidad.Alumno;
using CapaLogica.Becas;
namespace CapaPruebas.Becas
{
    [TestClass]
    public class TestBecas_Hexelencia
    {
        [TestMethod]
        public void Test_beca_exlencia()
        {
            E_Alumno ea = new E_Alumno();
            ea.Alumn_dni = "12345678";
            bool respuesta_esperada = false;
            bool respuesta_recibida =CL_BecaExcelencia.Instancia.Beca_exelencia(ea);
            Assert.AreEqual(respuesta_esperada, respuesta_recibida);
        }

        [TestMethod]
        public void Test_beca_exlencia_1()
        {
            E_Alumno ea = new E_Alumno();
            ea.Alumn_dni = "72717121";
            bool respuesta_esperada = true;
            bool respuesta_recibida = CL_BecaExcelencia.Instancia.Beca_exelencia(ea);
            Assert.AreEqual(respuesta_esperada, respuesta_recibida);
        }

        [TestMethod]
        public void Test_beca_exlencia_listar()
        {
            E_Alumno ea = new E_Alumno();
            string Alumn_dni = "72717121";
            bool respuesta_recibida = false;
            bool respuesta_esperada = true;
            ea = CL_BecaExcelencia.Instancia.Mostrar_Alumno_Exelencia(Alumn_dni);
            if (ea != null) respuesta_recibida = true;
            Assert.AreEqual(respuesta_esperada, respuesta_recibida);
        }
    }
}
  