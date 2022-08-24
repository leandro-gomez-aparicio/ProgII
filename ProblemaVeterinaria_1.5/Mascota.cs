using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaVeterinaria_1._5
{
    internal class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Tipo { get; set; }
        public Atencion Atencion { get; set; }

        public Mascota(string nombre, int edad, int tipo, Atencion atencion)
        {
            Nombre = nombre;
            Edad = edad;
            Tipo = tipo;
            Atencion = atencion;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
