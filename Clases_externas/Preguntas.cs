using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_externas
{
    public class Preguntas
    {
        public string Enunciado { get; set; }
        public string[] Opciones  { get; set; }
        public int RespuestaCorrecta { get; set; }
        public int Dificultad { get; set; }

        public Preguntas(string enunciado, string[] opciones, int correcta, int dificultad)
        {
            Enunciado = enunciado;
            Opciones = opciones;
            RespuestaCorrecta = correcta;
            Dificultad = dificultad;
        }
        public bool EsCorrecta(int seleccion)
        {
            return seleccion == RespuestaCorrecta;
        }
    }
}
