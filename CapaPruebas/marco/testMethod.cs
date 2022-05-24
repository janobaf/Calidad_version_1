using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CapaLogica.Pagos;
using CapaLogica.Becas;
using CapaEntidad.Alumno;

namespace CapaPruebas
{
    [TestClass]
    public class testMethod
    {
        E_Alumno a = new E_Alumno();

        /*
        [TestMethod]
        public void Test1_pagos()
        {
            int  promedio = 16;
            float pension = 200;
            L_Pagos pagos = new L_Pagos();
            float pago_esperado = 100;
            float pago_obtenido = pagos.pagos(promedio, pension);
            Assert.AreEqual(pago_esperado, pago_obtenido);
        }*/
        private E_Alumno seteoAlumn(E_Alumno a)
        {
            a.Alum_ID = 1;
            a.Alumn_nombre = "simon";
            a.Alumn_ApellidoPaterno = "";
            a.Alumn_ApellidoMaterno = "";
            a.Alumn_Direccion = "";

            DateTime fecha = new DateTime();
            fecha = Convert.ToDateTime("1999-04-01");
            a.Alumn_Fechnaci = fecha;

            a.Alumn_Tipo = "";

            DateTime fechaIns = new DateTime();
            fechaIns = Convert.ToDateTime("1999-04-01");
            a.Alumn_fechInscripcion = fechaIns;

            a.Alumn_dni = "";
            a.Alumn_ApoderadoNombre = "";
            a.Alumn_ApoderadoApellido = "";
            a.Alumn_ApoderadoMaterno = "";
            a.Alumn_Estado = "";
            a.Alumn_BecaSeleccionada = "";
            a.Alumn_Pension = 1;
            return a;
        }

        [TestMethod]
        public void aplicaOrfandad()
        {
            E_Alumno alumnValid = new E_Alumno();
            E_Alumno b = new E_Alumno();
            b = seteoAlumn(a);

            String dni = "";
            
            alumnValid = CL_BecaOrfandad.Instancia.retornarAlumno(dni);
            Assert.AreEqual(b, alumnValid);
        }
    }
}