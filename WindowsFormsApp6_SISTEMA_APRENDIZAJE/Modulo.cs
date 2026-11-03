using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_externas;

namespace WindowsFormsApp6_SISTEMA_APRENDIZAJE
{
    public partial class Modulo : Form
    {
        public Modulo()
        {
            InitializeComponent();
        }
        string indicadormodulo = "";
        string indicador = "";
        PanelPrincipal panelprincipal;
        Usuarios usuario;

        public Modulo(Usuarios usuario, PanelPrincipal panelprincipal, string indicador)
        {
            InitializeComponent();
            this.panelprincipal = panelprincipal;
            this.usuario = usuario;
            this.indicador = indicador;
            LabelTituloModulos.Text = indicador;

        }
        private bool ModuloCompletado(string tema,string modulo)
        {
            int indice = ObtenerIndiceProgreso(tema, modulo);
            return usuario.ProgresoPorModulo[indice].Length == 3;
        }
        
        private void btnModulo1_Click(object sender, EventArgs e)
        {
            indicadormodulo = "1";

            if (ModuloCompletado(indicador, indicadormodulo))
            {
                MessageBox.Show("Este módulo ya fue completado.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Pregunta pregunta = new Pregunta(usuario, this, indicador, indicadormodulo);
            pregunta.Show();
            this.Hide();
        }
        private void btnModulo2_Click(object sender, EventArgs e)
        {
            indicadormodulo = "2";

            if (ModuloCompletado(indicador, indicadormodulo))
            {
                MessageBox.Show("Este módulo ya fue completado.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            Pregunta pregunta = new Pregunta(usuario, this, indicador, indicadormodulo);
            pregunta.Show();
            this.Hide();

        }
        private void btnModulo3_Click(object sender, EventArgs e)
        {
            indicadormodulo = "3";

            if (ModuloCompletado(indicador, indicadormodulo))
            {
                MessageBox.Show("Este módulo ya fue completado.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Pregunta pregunta = new Pregunta(usuario, this, indicador, indicadormodulo);
            pregunta.Show();
            this.Hide();
        }

        private void Modulo_Load(object sender, EventArgs e)
        {
            string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "MODULO.gif");
            pictureBox1.Image = Image.FromFile(rutaImagen);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;



            Usuarios usuarioActualizado = Usuarios.CargarDesdeArchivo(usuario.Nombre);
            if (usuarioActualizado != null)
            {
                usuario = usuarioActualizado;
            }


        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            panelprincipal.Show();
            this.Hide();
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

    }
}
