using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CapaLogica.Pagos;
namespace CapaPruebas
{
    [TestClass]
    public class pagos
    {
        [TestMethod]
        public void Test1_pagos()
        {
            int  promedio = 16;
            float pension = 200;
            L_Pagos pagos = new L_Pagos();
            float pago_esperado = 100;
            float pago_obtenido = pagos.pagos(promedio, pension);
            Assert.AreEqual(pago_esperado, pago_obtenido);
        }


       
    }
}
