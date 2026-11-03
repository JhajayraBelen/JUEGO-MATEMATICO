using Clases_externas;  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases_Internas
{
    public class ListaDoble
    {
        public NodoLista primero = null;
        public NodoLista ultimo = null;

        public void Insertar(Usuarios c)
        {
            NodoLista nuevo = new NodoLista();
            nuevo.datos = c;
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.anterior = ultimo;
                ultimo = nuevo;

            }
            primero.anterior = ultimo;
            ultimo.siguiente = primero;
        }
        public void Mostrar(DataGridView dg)
        {
            dg.Rows.Clear();
            if (primero == null)
                return;

            NodoLista temp = primero;
            do
            {
                dg.Rows.Add(temp.datos.Nombre);
                temp = temp.siguiente;

            } while (temp != primero);
        }
        public void Eliminar(string NombreEliminar)
        {
            if (primero == null)
            {
                return;
            }

            NodoLista temp = primero;
            do
            {
                if (temp.datos.Nombre == NombreEliminar)
                {
                    if (temp == primero && temp == ultimo)
                    { 
                        primero = null;
                        ultimo = null;
                    }
                    else
                    {
                        temp.anterior.siguiente = temp.siguiente;
                        temp.siguiente.anterior = temp.anterior;
                        if (temp == primero)
                            primero = temp.siguiente;
                        if (temp == ultimo)
                            ultimo = temp.anterior;
                    }
                    return;
                }
                temp = temp.siguiente;
            } while (temp != primero);

            Console.WriteLine("Persona no encontrada");
        }
    }
    
}