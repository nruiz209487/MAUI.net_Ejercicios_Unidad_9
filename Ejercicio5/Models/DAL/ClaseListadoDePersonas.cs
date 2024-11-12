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
        public static List<ClasePersona> obtenerListadoDePersonasDAL()
        {
            List<ClasePersona> listaPeronas = new List<ClasePersona> 
            {
            new ClasePersona(1, "Juan", "Pérez", "1985-06-15", "foto1.jpg", "Calle A, 123", 123456789),
            new ClasePersona(2, "María", "Gómez", "1990-09-22", "foto2.jpg", "Avenida B, 456", 987654321),
            new ClasePersona(3, "Carlos", "López", "1978-01-03", "foto3.jpg", "Plaza C, 789", 567890123),
            new ClasePersona(4, "Ana", "Martínez", "2000-11-30", "foto4.jpg", "Calle D, 101", 345678901)
             };

            return listaPeronas;
        }
    }
}
