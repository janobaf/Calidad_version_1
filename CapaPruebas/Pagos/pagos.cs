using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using CapaEntidad.Alumno;
using CapaLogica.Pagos;
namespace CapaPruebas
{
    [TestClass]
    public class pagos
    {
        [TestMethod]
        public void Test1_pagos()
        {
            E_Alumno ea = new E_Alumno();
            ea.Alumn_dni = "12345678";
            L_Pagos.Instancia.pago_pension(ea);
        }
        [TestMethod]
        public void Test1_mostrar_alumnos_pagaron()
        {
            List<E_Alumno> alumno = new List<E_Alumno>();
            alumno = L_Pagos.Instancia.mostrar_alumnos_pagaron();
            bool esperado = false;
            bool obtenido =  false;
            if (alumno !=null)
            {
                obtenido = true;

            }
           

            Assert.AreEqual(esperado,obtenido);

        }




    }
}
