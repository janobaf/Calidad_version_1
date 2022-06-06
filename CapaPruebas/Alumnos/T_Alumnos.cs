using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CapaLogica;
using System.Collections.Generic;

using CapaEntidad.Alumno;
namespace CapaPruebas.Alumnos
{
    [TestClass]
    public class T_Alumnos
    {
        [TestMethod]
        public void ListaAlumnos()
        {
           List<E_Alumno> lista = new List<E_Alumno>();
            lista = L_Alumno.Instancia.listar_alumnos();
            bool resultado_obtenido = false;
            bool resultado_esperado = true;
            if (lista != null) resultado_obtenido = true;

            Assert.AreEqual(resultado_esperado, resultado_obtenido);
        }

        [TestMethod]
        public void ListaAlumnos_DNI_1()
        {
            E_Alumno e_Alumno = new E_Alumno();
            string dni = "12341234";
            e_Alumno = L_Alumno.Instancia.listar_alumno_dni(dni);
            bool resultado_obtenido = false;
            bool resultado_esperado = true;
            if (e_Alumno != null) resultado_obtenido = true;

            Assert.AreEqual(resultado_esperado, resultado_obtenido);
        }
        [TestMethod]
        public void ListaAlumnos_DNI_2()
        {
            E_Alumno e_Alumno = new E_Alumno();
            string dni = "12345678";
            e_Alumno = L_Alumno.Instancia.listar_alumno_dni(dni);
            bool resultado_obtenido = false;
            bool resultado_esperado = true;
            if (e_Alumno != null) resultado_obtenido = true;

            Assert.AreEqual(resultado_esperado, resultado_obtenido);
        }

        [TestMethod]
        public void ListaAlumnos_DNI_3()
        {
            E_Alumno e_Alumno = new E_Alumno();
            string dni = "72717271";
            e_Alumno = L_Alumno.Instancia.listar_alumno_dni(dni);
            bool resultado_obtenido = false;
            bool resultado_esperado = true;
            if (e_Alumno != null) resultado_obtenido = true;

            Assert.AreEqual(resultado_esperado, resultado_obtenido);
        }

    }
}
