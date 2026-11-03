using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_externas;
using Clases_Internas;

namespace WindowsFormsApp6_SISTEMA_APRENDIZAJE
{
    public partial class Pregunta: Form
    {
        private string indicadormodulo = "";
        private string indicador = "";
        private Usuarios usuario;
        private Modulo modulo;

        private Arboles arbolpre = new Arboles();
        private NodosArbol actual;
        private int puntaje;
        private string progresoruta = "";


        public Pregunta(Usuarios usuario, Modulo modulo, string indicador, string indicadormodulo)
        {
            InitializeComponent();
            
            this.usuario = usuario;
            this.modulo = modulo;
            this.indicador = indicador;
            this.indicadormodulo = indicadormodulo;
        }
        private void Pregunta_Load(object sender, EventArgs e)
        {
            string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "DIFICULTAD.gif");
            pictureBox1.Image = Image.FromFile(rutaImagen);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lblEnunciado.MaximumSize = new Size(200, 0); 
            lblEnunciado.AutoEllipsis = false;     
            
            string archivo = "";

            if (indicador == "Matematica")
            {
                archivo = $"Arbol_Matematica_M{indicadormodulo}.txt";

            }
            else if(indicador == "Comunicación")
            {
                archivo = $"Arbol_Lectura_M{indicadormodulo}.txt";
            }
            else if (indicador == "Programacion")
            {
                archivo = $"Arbol_Programacion_M{indicadormodulo}.txt";
            }
            string rutapreguntas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PREGUNTA", archivo);
            CargarPreguntasDesdeArchivo(rutapreguntas);

            puntaje=usuario.Puntaje;

            
            string rutaUsuario = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, usuario.Nombre + ".txt");
            if (File.Exists(rutaUsuario))
            {
                int index = ObtenerIndiceProgreso(indicador, indicadormodulo);
                if (!string.IsNullOrEmpty(usuario.ProgresoPorModulo[index]))
                {
                    progresoruta = usuario.ProgresoPorModulo[index];
                    actual = CargarProgreso(arbolpre.raiz_principal, progresoruta);
                }
                else
                {
                    actual = arbolpre.raiz_principal;
                }

                puntaje = 0;
                foreach (char c in progresoruta)
                {
                    if (c == '1') puntaje += 10;
                }
            }
            else
            {
                MessageBox.Show("Archivo del usuario no encontrado.");
                this.Close();
                return;
            }

            MostrarPregunta(actual);
        }


        private void MostrarPregunta(NodosArbol nodo)
        {
            lblEnunciado.Text = nodo.Pregunta.Enunciado;    
            RdbtOp1Preguntas.Text = nodo.Pregunta.Opciones[0];
            RdbtOp2Preguntas.Text = nodo.Pregunta.Opciones[1];
            RdbtOp3Preguntas.Text = nodo.Pregunta.Opciones[2];
            lblDificultad.Text = nodo.Pregunta.Dificultad.ToString();

            RdbtOp1Preguntas.Checked = false;
            RdbtOp2Preguntas.Checked = false;
            RdbtOp3Preguntas.Checked = false;


        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            int seleccion = -1;

            if (RdbtOp1Preguntas.Checked) seleccion = 0;
            else if (RdbtOp2Preguntas.Checked) seleccion = 1;
            else if (RdbtOp3Preguntas.Checked) seleccion = 2;

            if (seleccion == -1)
            {
                MessageBox.Show("Por favor selecciona una opción.");
                return;
            }

            bool correcta = actual.Pregunta.EsCorrecta(seleccion);
            progresoruta += correcta ? "1" : "0";

            actual = correcta ? actual.Derecha : actual.Izquierda;
            if (correcta)
            {
                puntaje += 10;
                    
            }

            if (actual == null)
            {
                GuardarProgreso();
                MessageBox.Show($"Fin del módulo. Tu puntaje es: {puntaje}");

                modulo.Show();
                this.Hide();
            }
            else
            {
                MostrarPregunta(actual);
            }

        }
       
        public void CargarPreguntasDesdeArchivo(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("Archivo de preguntas no encontrado.");
                return;
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);
            for (int i = 0; i < lineas.Length; i += 6)
            {
                string enunciado = lineas[i]+ " " + lineas[i+1];
                string[] opciones =
                {
                    lineas[i + 2],
                    lineas[i + 3],
                    lineas[i + 4]
                };

                string[] datos = lineas[i + 5].Split(',');
                int respuesta = int.Parse(datos[0]);
                int dificultad = int.Parse(datos[1]);

                Preguntas pregunta = new Preguntas (enunciado, opciones, respuesta, dificultad);
                arbolpre.Insertar(pregunta);
            }

        }
        private int ObtenerIndiceProgreso(string tema, string modulo)
        {
            int baseLinea;

            switch (tema)
            {
                case "Matematica":
                    baseLinea = 0;
                    break;
                case "Comunicación":
                    baseLinea = 3;
                    break;
                case "Programacion":
                    baseLinea = 6;
                    break;
                default:
                    throw new ArgumentException("Tema no reconocido: " + tema);
            }
            return baseLinea + int.Parse(modulo) - 1;
        }
       
        private void GuardarProgreso()
        {
            int index = ObtenerIndiceProgreso(indicador, indicadormodulo);

            usuario.ProgresoPorModulo[index] = progresoruta;
            usuario.Puntaje = CalcularPuntajeTotalDesdeProgreso(usuario.ProgresoPorModulo);

            usuario.Guardar();

        }


        private NodosArbol CargarProgreso(NodosArbol raiz, string ruta)
        {
            NodosArbol actual = raiz;

            foreach (char paso in ruta)
            {
                if (paso == '1' && actual.Derecha != null)
                    actual = actual.Derecha;
                else if (paso == '0' && actual.Izquierda != null)
                    actual = actual.Izquierda;
                else
                    break;
            }

            return actual;
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            GuardarProgreso();
            modulo.Show();
            this.Hide();
        }
        private int CalcularPuntajeTotalDesdeProgreso(string[] progresos)
        {
            int total = 0;
            foreach (var progreso in progresos)
            {
                if (string.IsNullOrEmpty(progreso)) continue;
                foreach (char c in progreso)
                {
                    if (c == '1') total += 10;
                }
            }
            return total;
        }

        private void RdbtOp1Preguntas_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

