using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_externas;

namespace Clases_Internas
{
    public class Arboles
    {
        public NodosArbol raiz_principal = null;
        public void Insertar(Preguntas pregunta)
        {
            insertar(ref raiz_principal, pregunta);
        }
        public void insertar(ref NodosArbol raiz, Preguntas pregunta)
        {
            if (raiz == null)
            {
                NodosArbol nuevo = new NodosArbol(pregunta);
                raiz = nuevo;
            }
            else
            {
                if (pregunta.Dificultad < raiz.Pregunta.Dificultad)
                {
                    insertar(ref raiz.Izquierda, pregunta);
                }
                else if (pregunta.Dificultad > raiz.Pregunta.Dificultad)
                {
                    insertar(ref raiz.Derecha, pregunta);
                }
                else
                {
                    Console.WriteLine("Dato duplicado");
                }
            }
        }
        public void MostrarMayor()
        {
            string nodomayor = BuscarMayor(raiz_principal).Pregunta.Enunciado;
            Console.WriteLine("La pregunta más difícil es : " + nodomayor);
        }
        public NodosArbol BuscarMayor(NodosArbol raiz)
        {
            if (raiz.Derecha == null)
            {
                return raiz;
            }
            else
            {
                return BuscarMayor(raiz.Derecha);
            }
        }
        public void MostrarMenor()
        {
            string nodomenor = BuscarMenor(raiz_principal).Pregunta.Enunciado;
            Console.WriteLine("La pregunta mas fáciles : " + nodomenor);
        }
        public NodosArbol BuscarMenor(NodosArbol raiz)
        {
            if (raiz.Izquierda == null)
            {
                return raiz;
            }
            else
            {
                return BuscarMenor(raiz.Izquierda);
            }

        }
        public void DibujarArbol()
        {
            dibujararbol(raiz_principal, 0);
        }
        public void dibujararbol(NodosArbol raiz, int espacios)
        {
            if (raiz != null)
            {
                dibujararbol(raiz.Derecha, espacios + 1);
                for (int i = 0; i < espacios; i++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(raiz.Pregunta.Enunciado);
                dibujararbol(raiz.Izquierda, espacios + 1);
            }
        }


        public void Inorden()
        {
            inorden(raiz_principal);
        }
        public void inorden(NodosArbol raiz)
        {
            if (raiz != null)
            {
                inorden(raiz.Izquierda);
                Console.WriteLine(raiz.Pregunta.Enunciado);
                inorden(raiz.Derecha);
            }
        }


    }
}
    