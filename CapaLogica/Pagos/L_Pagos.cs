﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Alumno;
using CapaDatos.Alumnos;
using CapaDatos.Pagos;
namespace CapaLogica.Pagos
{
    public class L_Pagos
    {
        public float pagos(int nota, float pension)
        {
            float pago_pension = 0;

            if (nota >=16)
            {
                pago_pension = (float)(pension * 0.5);
            }
            return pago_pension;
        }
        public bool pago_pension(E_Alumno ea)
        {
            bool validar = false;
            if (CD_Alumno.Instancia.mostrar_alumno_dni(ea.Alumn_dni) != null)
            {
                E_Alumno alumno = new E_Alumno();
                alumno = CD_Alumno.Instancia.mostrar_alumno_dni(ea.Alumn_dni);
                if (alumno.Alumn_Estado == "FALSO")
                {
                    if( CD_Pagos.Instancia.modificar_pago(ea.Alumn_dni))
                        validar = true;
                }
            }
            return validar;
        }
         public List<E_Alumno> mostrar_alumnos_pagaron()
        {
            List<E_Alumno> alumno = new List<E_Alumno>();
            if (CD_Pagos.Instancia.mostrar_alumnos("TRUE") != null)
            {
                alumno = CD_Pagos.Instancia.mostrar_alumnos("TRUE");

            }
            if (alumno != null) return alumno;
            return null;
        }
        public List<E_Alumno> mostrar_alumnos_NOpagaron()
        {
            List<E_Alumno> alumno = new List<E_Alumno>();
            if (CD_Pagos.Instancia.mostrar_alumnos("FALSE") != null)
            {
                alumno = CD_Pagos.Instancia.mostrar_alumnos("true");

            }
            if (alumno != null) return alumno;
            return null;
        }
    }
}
