using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaVeterinaria_1._5
{
    internal class Cliente 
    {
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Codigo { get; set; }
        //public Mascota Mascota { get; set; }

        public Cliente(string nom, string sexo, int codigo)
        {
            Nombre = nom;
            Sexo = sexo;
            Codigo = codigo;
            //Mascota = m;
        }
        public Cliente()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
