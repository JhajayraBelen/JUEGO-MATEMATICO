using Clases_externas;
using Clases_Internas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6_SISTEMA_APRENDIZAJE
{
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal(Usuarios usuario)
        {
            InitializeComponent();
            
        }

        

        private string indicador = "";
        private Login login;
        private Usuarios usuario;
        public PanelPrincipal(Usuarios usuario, Login login)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.login = login;
            labelNombrePanelPrincipal.Text = usuario.Nombre;

            this.Activated += PanelPrincipal_Activated;

        }

        private void btnMatematica_Click(object sender, EventArgs e)
        {
            indicador = "Matematica";
            Modulo Modulo = new Modulo(usuario, this, indicador);
            Modulo.Show();
            this.Hide();

        }
        private void btnComunicacion_Click(object sender, EventArgs e)
        {
            indicador = "Comunicación";
            Modulo Modulo = new Modulo(usuario, this, indicador);
            Modulo.Show();
            this.Hide();
        }
       
        private void btnPro_Click(object sender, EventArgs e)
        {
            indicador = "Programacion";
            Modulo Modulo = new Modulo(usuario, this, indicador);
            Modulo.Show();
            this.Hide();
        }
        private void PanelPrincipal_Load(object sender, EventArgs e)
        {
            string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "CURSOS.gif");
            pictureBox1.Image = Image.FromFile(rutaImagen);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            DgTabPanPrin.BackgroundColor = Color.Brown;

            DgTabPanPrin.DefaultCellStyle.BackColor = Color.OrangeRed;
            DgTabPanPrin.DefaultCellStyle.ForeColor = Color.Beige;


            DgTabPanPrin.DefaultCellStyle.SelectionForeColor = Color.White;

            DgTabPanPrin.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            DgTabPanPrin.DefaultCellStyle.SelectionForeColor = Color.White;

            DgTabPanPrin.ColumnHeadersDefaultCellStyle.BackColor = Color.Brown;
            DgTabPanPrin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgTabPanPrin.EnableHeadersVisualStyles = false;

            CargarPuntajes();


        }

        private void ButtonRegresarPanelPrincipal_Click_1(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void CargarPuntajes()
        {
            Colas ColaPuntajes = new Colas();

            string carpetaBase = AppDomain.CurrentDomain.BaseDirectory;
            string[] archivosUsuarios = Directory.GetFiles(carpetaBase, "*.txt");

            foreach (string archivo in archivosUsuarios)
            {
                string nombreUsuario = Path.GetFileNameWithoutExtension(archivo);
                Usuarios usuarioCargado = Usuarios.CargarDesdeArchivo(nombreUsuario);
                if (usuarioCargado != null)
                {
                    ColaPuntajes.insertarPrioridad(usuarioCargado);
                }
            }

            ColaPuntajes.Mostrar(DgTabPanPrin);
        }
        private void PanelPrincipal_Activated(object sender, EventArgs e)
        {
            CargarPuntajes();
        }
    }
}
