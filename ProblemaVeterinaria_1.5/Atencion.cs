using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaVeterinaria_1._5
{
    internal class Atencion
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public float Importe { get; set; }

        public Atencion(DateTime f, string descripcion, float imp)
        {
            Fecha = f;
            Descripcion = descripcion;
            Importe = imp;
        }
    }
}
