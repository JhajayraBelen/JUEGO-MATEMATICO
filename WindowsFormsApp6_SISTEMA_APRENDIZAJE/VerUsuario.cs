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
using Clases_Internas;  

namespace WindowsFormsApp6_SISTEMA_APRENDIZAJE
{
    public partial class VerUsuario : Form
    {
        private Login login;
        private ListaDoble listaUsuarios = new ListaDoble();
        
        public VerUsuario(Login login)
        {
            InitializeComponent();
            this.login = login;
            MostrarUsuario();
        }

        private void MostrarUsuario()
        {
            listaUsuarios = new ListaDoble();

            string[] archivos = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.txt");
            foreach (string archivo in archivos)
            {
                string nombreUsuario = Path.GetFileNameWithoutExtension(archivo);
                Usuarios usuario = Usuarios.CargarDesdeArchivo(nombreUsuario);
                if (usuario != null)
                {
                    listaUsuarios.Insertar(usuario);
                }
            }

            listaUsuarios.Mostrar(dgvUsuarios);
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtEliminar.Text;

            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreUsuario + ".txt");

            if (File.Exists(rutaArchivo))
            {
                File.Delete(rutaArchivo);
                listaUsuarios.Eliminar(nombreUsuario);
                MostrarUsuario();
                MessageBox.Show("Usuario eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("El archivo del usuario no existe.");
            }
            txtEliminar.Clear();
        }

        private void VerUsuario_Load(object sender, EventArgs e)
        {
            txtEliminar.Focus();
            string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "USUARIO.gif");
            pictureBox1.Image = Image.FromFile(rutaImagen);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            dgvUsuarios.DefaultCellStyle.BackColor = Color.Black;
            dgvUsuarios.DefaultCellStyle.ForeColor = Color.Beige;

            
            dgvUsuarios.DefaultCellStyle.SelectionForeColor = Color.White;


            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvUsuarios.EnableHeadersVisualStyles = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }
    }
}


