using Ejercicio5.Models.DAL;
using Ejercicio5.Models.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.VM
{
    public class MainPageVM
    {
        public static List<ClasePersona> obtenerListadoDePersonasvm()
        {
            List<ClasePersona> listaPeronas = ClaseListadoDePersonas.obtenerListadoDePersonasDAL();
            return listaPeronas;
        }

    }
}
