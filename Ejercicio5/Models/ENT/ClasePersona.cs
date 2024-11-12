
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models.ENT
{
    public class ClasePersona
    {

        private int id;
        private string nombre;
        private string apellidos;
        private string fechaDeNacimiento;
        private string foto;
        private string dirección;
        private int teléfono;

        public int Id { get => id; }
        public string Nombre { get => nombre; }
        public string Apellidos { get => apellidos; }
        public string FechaDeNacimiento { get => fechaDeNacimiento; }
        public string Foto { get => foto; }
        public string Dirección { get => dirección; }
        public int Teléfono { get => teléfono; }

        public ClasePersona()
        {
        }

        public ClasePersona(int id, string nombre, string apellidos, string fechaDeNacimiento, string foto, string dirección, int teléfono)
        {
            if (id > 0) { this.id = id; }
            if (nombre != null && nombre != "") { this.nombre = nombre; }
            if (apellidos != null && apellidos != "") { this.apellidos = apellidos; }
            if (fechaDeNacimiento != null && fechaDeNacimiento != "") { this.fechaDeNacimiento = fechaDeNacimiento; }
            if (foto != null && foto != "") { this.foto = foto; }
            if (dirección != null && dirección != "") { this.dirección = dirección; }
            if (teléfono >= 111111111 && teléfono <= 999999999) { this.teléfono = teléfono; }

        }
    }


}
