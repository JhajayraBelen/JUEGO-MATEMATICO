using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_externas;
using Clases_Internas;
using Microsoft.Win32;

namespace WindowsFormsApp6_SISTEMA_APRENDIZAJE
{
    public partial class Login : Form
    {
       private ListaDoble ListaUsuarios = new ListaDoble();
        public Login()
        {
            InitializeComponent();
           
        }

        private void buttonIngresarLogin_Click(object sender, EventArgs e)
        {
             
            string nombre = TextBoxUsuarioLogin.Text;
            string contra = TextBoxContraseñaLogin.Text;
            

            Usuarios usuario = Usuarios.CargarDesdeArchivo(nombre);
            if (usuario != null && usuario.Contraseña == contra)
            {
                PanelPrincipal panel = new PanelPrincipal(usuario, this);
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado o contraseña incorrecta.");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            string[] archivos = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.txt");
            foreach (var archivo in archivos)
            {
                string nombre = Path.GetFileNameWithoutExtension(archivo);
                Usuarios usuario = Usuarios.CargarDesdeArchivo(nombre);
                if (usuario != null)
                    ListaUsuarios.Insertar(usuario);
            }

            TextBoxContraseñaLogin.PasswordChar = '*';
            string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "INICIO.gif");
            pictureBox1.Image = Image.FromFile(rutaImagen);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            string rutaMusica = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Musica", "Música Clásica para niños 1 - ClavedeCelia.wav");
            axControl.URL = rutaMusica;
            axControl.Ctlcontrols.play();

            if (axControl.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axControl.Ctlcontrols.pause();
            }
            else
            {
                axControl.Ctlcontrols.play();
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            Registrar registro = new Registrar(this);
            registro.Show();
            this.Hide();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            VerUsuario verUsuario = new VerUsuario(this);
            verUsuario.Show();
            this.Hide();
        }
    }
}
