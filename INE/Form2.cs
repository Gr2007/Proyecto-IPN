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
    public partial class NoVotantes : Form
    {
        int NVotos = 0;
        string path = "Votaciones.INE";
        

        public NoVotantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NVotos = Convert.ToInt32(txtNoUser.Text);
            this.Hide();
            File.Delete(path);

            for (int i = 0; i < NVotos; i++)
            {
                Voto1 nueva = new Voto1();
                nueva.Show();
            }
            
        }

        private void NoVotantes_Load(object sender, EventArgs e)
        {

        }
    }
}
