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
    public partial class Resultados : Form
    {
        string path = "Votaciones.INE";
        string[] aa;
        int conde = 0;
        string morena = "  MORENA *";
        string pr = "  PRI *";
        string pn = "  PAN *";
        public Resultados()
        {
            InitializeComponent();

            string[] documento;
            File.AppendAllText(path, "");

            documento = File.ReadAllLines(path);

            for (int i = 0; i < documento.Length; i++)
            {
                aa = documento[i].Split(new char[] { '*' });
                for (int j = 0; j < aa.Length; j++)
                {
                    listBox1.Items.Add(aa[j] + "\n");
                }
                conde++;
            }
            int mor = 0;
            int pri = 0;
            int pan = 0;
            

            for (int i = 0; i < documento.Length; i++)
            {
                
                aa = documento[i].Split(new char[] { '|' });
                
                for (int j = 0; j < aa.Length; j++)
                {
                    string ss= aa[j];
                    if (aa[j] == morena)
                    {
                        mor++;
                    }

                    if (aa[j] == pr)
                    {
                        pri++;
                    }

                    if (aa[j] == pn)
                    {
                        pan++;
                    }
                }

               
                
            }
            int total = mor + pri + pan;
            listBox1.Items.Add("Votos para Morena: " + mor+ "\n");
            listBox1.Items.Add("Votos para PRI:" + pri + "\n");
            listBox1.Items.Add("Votos para PAN:" + pan + "\n");
            listBox1.Items.Add("Total de Votantes: " + total + "\n" );
            

            if (mor == pri)
            {
                listBox1.Items.Add("Empate MORENA y PRI\n");

                if (pan > pri)
                {
                    listBox1.Items.Add("Ganador PAN \n");
                }
                else
                {
                    listBox1.Items.Add("NO HAY GANADOR");
                }
                return;
            }
            if (mor == pan)
            {
                listBox1.Items.Add("Empate MORENA y PAN\n");
                if (pri > pan)
                {
                    listBox1.Items.Add("Ganador PRI \n");
                }
                else
                {
                    listBox1.Items.Add("NO HAY GANADOR");
                }
                return;
            }
            if (pan == pri)
            {
                listBox1.Items.Add("Empate PAN y PRI\n");
                if (mor > pri)
                {
                    listBox1.Items.Add("Ganador MORENA \n");
                }
                else
                {
                    listBox1.Items.Add("NO HAY GANADOR");
                }
                return;
            }
            if(pan== pri && pri== mor)
            {
                listBox1.Items.Add("EMPATE GENERAL");
                return;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
