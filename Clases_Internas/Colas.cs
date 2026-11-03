using Clases_externas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases_Internas
{
    public class Colas
    {
        public NodosCola p;
        public NodosCola q;
        public Colas()
        {
            p = null;
            q = null;
        } 
        
        public void insertarPrioridad(Usuarios a)
        {
            NodosCola nuevo = new NodosCola(a);

            if (p == null)
            {
                p = q = nuevo;
                return;
            }

            if (a.Puntaje > p.dato.Puntaje)
            {
                nuevo.sig = p;
                p = nuevo; 
                return;
            }

            
            NodosCola actual = p;
            while (actual.sig != null && actual.sig.dato.Puntaje >= a.Puntaje)
            {
                actual = actual.sig;
            }

           
            nuevo.sig = actual.sig;
            actual.sig = nuevo;

            
            if (nuevo.sig == null)
            {
                q = nuevo;
            }

        }
        public void Mostrar(DataGridView dg)
        {
            dg.Rows.Clear();

            NodosCola x = p;
            while (x != null)
            {
                dg.Rows.Add(x.dato.Nombre,x.dato.Puntaje);
                x = x.sig;
            }

           
        }
    }
}
