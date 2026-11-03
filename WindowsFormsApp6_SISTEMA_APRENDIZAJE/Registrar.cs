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
    public partial class Registrar : Form
    {
        Login login;

        public Registrar(Login login)
        {
            InitializeComponent();
            this.login = login;
        }


        private void Registrar_Load(object sender, EventArgs e)
        {
           
            txtContraseñaR.PasswordChar = '*';
            string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "CONTRASEÑA.gif");
            picBox1.Image = Image.FromFile(rutaImagen);
            picBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            txtUsuarioR.Focus();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtUsuarioR.Text;
            string contra = txtContraseñaR.Text;
           

            if (File.Exists(nombre + ".txt"))
            {
                MessageBox.Show("Este usuario ya existe.");
                return;
            }

            Usuarios nuevo = new Usuarios
            {
                Nombre = nombre,
                Contraseña = contra,
                Edad = 20,
                Puntaje = 0,
                cualco = true,
                ProgresoPorModulo = new string[9]
            };

            nuevo.Guardar();

            MessageBox.Show("Usuario registrado exitosamente.");
            txtUsuarioR.Clear();
            txtContraseñaR.Clear();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }
    }
}
