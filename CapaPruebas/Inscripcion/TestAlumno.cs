using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CapaLogica;
using CapaEntidad.Alumno;
using System.Collections.Generic;

namespace CapaPruebas.Alumnos
{
    [TestClass]
    public class TestAlumno
    {



        private E_Alumno _alumno()
        {
            E_Alumno aux = new E_Alumno();

            aux.Alumn_dni = "12341234";
            aux.Alumn_Tipo = "Primaria";
            aux.Alumn_Direccion = "av pablo casalz mc prima lote 2";
            aux.Alumn_Estado = "true";
 
            aux.Alum_Correo = "juan21222@hotmail.com ";
            aux.Alum_Telefono = "965589456";
            return aux;

        }

        [TestMethod]
        public void Test_creacion_inscripcion()
        {
            E_Alumno ea = this._alumno();

            bool respuesta_esperada = true;
            bool respuesta_obtenida = L_Alumno.Instancia.modificar_alumno(ea);
            Assert.AreEqual(respuesta_esperada, respuesta_obtenida);
        }


            /*

            private E_Alumno _alumno()
            {
                E_Alumno aux = new E_Alumno();
                aux.Alum_ID = 2;
                aux.Alumn_nombre = "Alejandro";
                aux.Alumn_ApellidoMaterno = "baltodano";
                aux.Alumn_ApellidoPaterno = "flores";
                aux.Alumn_dni = "12345678";

                aux.Alumn_Tipo = "Secundaria";
                aux.Alumn_Fechnaci = DateTime.Parse("2021/05/20");
                aux.Alumn_fechInscripcion = DateTime.Parse("20/05/2022 11:12:12pm");
                aux.Alumn_Direccion = "av pablo casalz";
                aux.Alumn_Estado = "true";
                aux.Alumn_ApoderadoNombre = "Mirta";
                aux.Alumn_ApoderadoApellido = "Ezperansa";
                aux.Alumn_ApoderadoMaterno = "Flores";
                aux.Alum_Correo = "juan21@hotmail.com ";
                aux.Alum_Telefono = "965589456";
                return aux;

            }

            [TestMethod]
            public void Test_creacion_inscripcion()
            {
                E_Alumno ea = this._alumno();

                bool respuesta_esperada = true;
                bool respuesta_obtenida = L_Alumno.Instancia.crear_alumno(ea);
                Assert.AreEqual(respuesta_esperada, respuesta_obtenida);

            }
            */
            /*
            // !Segundo caso de prueba
            private E_Alumno _alumno1()
            {
                E_Alumno aux = new E_Alumno();
                aux.Alum_ID = 2;
                aux.Alumn_nombre = "Marietha";
                aux.Alumn_ApellidoMaterno = "Upiachigua";
                aux.Alumn_ApellidoPaterno = "Vilela ";
                aux.Alumn_dni = "19546829";

                aux.Alumn_Tipo = "Secundaria";
                aux.Alumn_Fechnaci = DateTime.Parse("2021/05/20");
                aux.Alumn_fechInscripcion = DateTime.Parse("20/05/2022 11:12:12pm");
                aux.Alumn_Direccion = "av pablo casalz";
                aux.Alumn_Estado = "true";
                aux.Alumn_ApoderadoNombre = "Mirta";
                aux.Alumn_ApoderadoApellido = "Ezperansa";
                aux.Alumn_ApoderadoMaterno = "Flores";
                aux.Alum_Correo = "hyu88@gmail.com";
                aux.Alum_Telefono = "982544568";
                return aux;

            }
            [TestMethod]
            public void Test_creacion_inscripcion1()
            {
                E_Alumno ea = this._alumno1();

                bool respuesta_esperada = true;
                bool respuesta_obtenida = L_Alumno.Instancia.crear_alumno(ea);
                Assert.AreEqual(respuesta_esperada, respuesta_obtenida);

            }

            */


            // TODO : Despues de creacion 
            /*
            [TestMethod]
            public void Test_Listar_alumno()
            {

                bool respuesta_esperada = false;
                bool respuesta_obtenida = false;
                List<E_Alumno> obtener = L_Alumno.Instancia.listar_alumnos();
                if (obtener != null) respuesta_obtenida = true;
                Assert.AreEqual(respuesta_esperada, respuesta_obtenida);

            } */
        }
    }
