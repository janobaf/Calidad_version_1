using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CapaEntidad.Calificaciones;
using CapaLogica.Calificaciones;
namespace CapaPruebas.Calificaciones
{
    [TestClass]
    public class T_Calificaciones
    {
        [TestMethod]
        public void T_crear_calificaciones()

        {
            //E_Calificaciones calificaciones, string dni
            
            E_Calificaciones calificacion = new E_Calificaciones();
            calificacion.Califi_Parcial1 = 12;
            calificacion.Califi_Parcial2 = 13;
            calificacion.Califi_Trabajos = 10;
            calificacion.Califi_Final = 14;
            string dni = "12341234";
            bool respuesta_esperada = true;
            bool respuesta_obtenida = CL_calificaciones.Instancia.crear_calificaciones(calificacion,dni);
            Assert.AreEqual(respuesta_esperada, respuesta_obtenida);


        }
    }
}
