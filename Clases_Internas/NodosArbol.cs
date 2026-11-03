using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_externas;

namespace Clases_Internas
{
    public class NodosArbol
    {
        public Preguntas Pregunta;
        public NodosArbol Izquierda;   // más fácil
        public NodosArbol Derecha;    // más difícil

        public NodosArbol(Preguntas pregunta)
        {
            Pregunta = pregunta;
        }
    }
}
