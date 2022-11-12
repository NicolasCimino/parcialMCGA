using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCimino.Clases
{
    public class Venta
    {
        public string SO;
        public int edad;
        public float valor;
        public string tipo;

        public Venta(string so, int e, float v, string t)
        {
            SO = so;
            edad = e;
            valor = v;
            tipo = t;
        }

        public Venta()
        {
         
        }
    }
}
