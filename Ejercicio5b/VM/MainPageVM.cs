﻿using Ejercicio5b.Models.DAL;
using Ejercicio5b.Models.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5b.VM
{
    public class MainPageVM
    {
        public static List<ClasePersona> obtenerListadoDePersonasVM()
        {
            List<ClasePersona> listaPeronas = ClaseListadoDePersonas.obtenerListadoDePersonasDAL();
            return listaPeronas;
        }
        public static ClasePersona obtenerPersonaVM(int id)
        {
            ClasePersona objetoPerona = ClaseListadoDePersonas.obtenerPersonaDAL(id);
            return objetoPerona;
        }
    }
}