using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CapaEntidad.Alumno;
using CapaLogica.Becas;
namespace CapaPruebas.Alumnos
{
    [TestClass]
    public class TestBecas_Hermano
    {
        [TestMethod]
        public void Test_Beca_Hermano()
        {
            E_Alumno ea = new E_Alumno();
            ea.Alumn_dni = "1234567";
            bool respuesta_espérada = false;
            bool respuesta_recibida =CL_B_Hermano.Instancia.beca_hermano(ea);
            Assert.AreEqual(respuesta_espérada, respuesta_recibida);

        }
        [TestMethod]
        public void Test_existencia_persona()
        {

            string dni = "12345678";
            bool respuesta_esperada = false;
            bool respuesta_recibida = CL_B_Hermano.Instancia.existencia_persona(dni);
            Assert.AreEqual(respuesta_esperada, respuesta_recibida);
        }

    }
}
