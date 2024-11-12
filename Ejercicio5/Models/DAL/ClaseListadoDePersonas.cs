using Ejercicio5.Models.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models.DAL
{
    public class ClaseListadoDePersonas
    {
        private static List<ClasePersona> listaPeronas;
        public static List<ClasePersona> obtenerListadoDePersonasDAL()
        {
            listaPeronas = new List<ClasePersona>
            {
            new ClasePersona(1, "Juan", "Pérez", "1985-06-15", "Assets/splashSplashScreen.png", "Calle A, 123", 123456789),
            new ClasePersona(2, "María", "Gómez", "1990-09-22", "Assets/splashSplashScreen.png", "Avenida B, 456", 987654321),
            new ClasePersona(3, "Carlos", "López", "1978-01-03", "Assets/splashSplashScreen.png", "Plaza C, 789", 567890123),
            new ClasePersona(4, "Ana", "Martínez", "2000-11-30", "Assets/splashSplashScreen.png", "Calle D, 101", 345678901)
             };

            return listaPeronas;
        }

        public static ClasePersona obtenerPersonaDAL(int id)
        {
            ClasePersona objetoPersona = null;
            if (listaPeronas.Exists(x => x.Id == id))
            {
                foreach (var persona in listaPeronas)
                {
                    if (persona.Id == id)
                    {
                        objetoPersona = persona;
                    }
                }
            }
            return objetoPersona;
        }
    }
}

