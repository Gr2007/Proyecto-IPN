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
    public partial class Voto1 : Form
    {
        string Voto;
        DateTime Dia;
        string path = "Votaciones.INE";

        public Voto1()
        {
            InitializeComponent();
            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbMorena.Checked)
            {
                this.Voto = "MORENA *";
            }

            if (rdbPAN.Checked)
            {
                this.Voto = "PAN *";
            }

            if (rdbPRI.Checked)
            {
                this.Voto = "PRI *";
            }
            Dia = DateTime.Parse(dateTimePicker1.Text);
            int edad = 2018 - Dia.Year;
            File.AppendAllText(path, "|  "+txtUser.Text + "  |  " + "Edad: " +edad + "  |  " + Voto);
            this.Close();
        }

        private void Voto1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
