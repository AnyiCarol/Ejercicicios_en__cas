using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicicios_en__cas
{
    public class Personas
    {
       private string nombre;
        private string apellidos;
        private Int32 edad;
       private  string correo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
