using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace INE
{
    public partial class LoginUI : Form
    {
        String Administrador = "Admin";
        String Clave = "admin";
        int intentos = 0;
        string path = "Votaciones.INE";

        public LoginUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.intentos = intentos + 1;
            if (this.intentos == 6)
            {
                MessageBox.Show("Demasiados intentos");
                this.Close();
            }

            if (txtUser.Text == "")
            {
                MessageBox.Show("Ingresar usuario");
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Ingresar Contraseña");
                return;
            }

            if (txtPass.Text == this.Clave && txtUser.Text == this.Administrador)
            {
                this.intentos = 0;
                NoVotantes Nueva = new NoVotantes();
                Nueva.Show();
                this.Hide();
            }
            else
            { 
                MessageBox.Show("Vuelva a intentarlo");
            }
         
        }

        private void txtNoCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.intentos = intentos + 1;
            if (this.intentos == 6)
            {
                MessageBox.Show("Demasiados intentos");
                this.Close();
            }

            if (txtUser.Text == "")
            {
                MessageBox.Show("Ingresar usuario");
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Ingresar Contraseña");
                return;
            }

            if (txtPass.Text == this.Clave && txtUser.Text == this.Administrador)
            { 
                if (!File.Exists(path))
                {
                    MessageBox.Show("Aún no se tienen registros");
                    return;
                }
                this.intentos = 0;
                Resultados Nueva = new Resultados();
                Nueva.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vuelva a intentarlo");
            }
        }
    }
}
