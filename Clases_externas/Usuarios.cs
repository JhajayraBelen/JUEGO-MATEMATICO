using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_externas
{
    public class Usuarios
    {
        public string Nombre;
        public string Contraseña;
        public int Edad;
        public int Puntaje;
        public bool cualco;
        public string[] ProgresoPorModulo;

        public string RutaArchivo => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Nombre + ".txt");

        public static Usuarios CargarDesdeArchivo(string nombre)
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombre + ".txt");
            if (!File.Exists(ruta)) return null;

            string[] lineas = File.ReadAllLines(ruta);
            Usuarios u = new Usuarios
            {
                Nombre = lineas[0],
                Contraseña = lineas[1],
                Edad = int.Parse(lineas[2]),
                Puntaje = int.Parse(lineas[3]),
                cualco = bool.Parse(lineas[4]),
                ProgresoPorModulo = new string[9]
            };

            for (int i = 0; i < 9; i++)
            {
                u.ProgresoPorModulo[i] = lineas[5 + i];
            }

            return u;
        }
        public void Guardar()
        {
            string[] lineas = new string[14];
            lineas[0] = Nombre;
            lineas[1] = Contraseña;
            lineas[2] = Edad.ToString();
            lineas[3] = Puntaje.ToString();
            lineas[4] = cualco.ToString();

            for (int i = 0; i < 9; i++)
            {
                lineas[5 + i] = ProgresoPorModulo[i] ?? "";
            }

            File.WriteAllLines(RutaArchivo, lineas);
        }

        public void ActualizarPuntaje()
        {
            Puntaje++;
           
        }
        public static bool VerificarUsuario(string usu, string con)
        {
            return true;
        }
        public void MostrarInfo()
        {

        }

    }
}
