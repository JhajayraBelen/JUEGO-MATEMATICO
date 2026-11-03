using Clases_externas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Internas
{
    public class NodosCola
    {
        public Usuarios dato { get; set; }
        public NodosCola sig { get; set; }  
       


        public NodosCola(Usuarios dato)
        {
            this.dato = dato;
        }
    }
}
