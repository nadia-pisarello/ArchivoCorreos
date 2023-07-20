using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArchivoCorreos
{
       
    public partial class Form1 : Form
    {

        string lines = string.Empty;
        string[] trabajo = new string[] { "trabajo", "laburo", "empleo" };
        string[] familia = new string[] { " familia", "flia", "parientes" };
        string[] promos = new string[] { "promocíón", "oferta", "descuentos" };
        string[] texto = Array.Empty<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)| *.txt";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    lines = sr.ReadToEnd();
                    txtFile.Text = lines;
                }
            }
        }

        private void trabajoTSMItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFile.Text))
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

                MessageBox.Show("Open file first", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                GenerarTexto(lines);
                Categorizar(texto, trabajo);
            }

        }

        private void familiaTSMItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFile.Text))
            {
                MessageBox.Show("Open file first", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GenerarTexto(lines);
                Categorizar(texto, familia);
            }
            
        }

        private void promoTSMItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFile.Text))
            {
                MessageBox.Show("Open file first");
            }
            else
            {
                GenerarTexto(lines);
                Categorizar(texto, promos);
            }
            
        }

        private void Categorizar(string[] texto, string[] categoria)
        {
            categoriasBox.Clear();
            string[] palabras;
            foreach (string txt in texto)
            {
                palabras = txt.Split(' ');
                foreach (string c in categoria)
                {
                    if (txt.Contains(c))
                    {
                        categoriasBox.Text += txt + "\r\n";
                    }
                    else
                    {
                        foreach (string palabra in palabras)
                        {

                            if (String.Equals(c, palabra, StringComparison.InvariantCultureIgnoreCase))
                            {
                                categoriasBox.Text += txt + "\r\n";
                            }
                        }
                    }

                }

            }
        }

        private void GenerarTexto(string lines)
        {
            texto = lines.Split(new[] { "FROM: " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < texto.Length; i++)
            {
                texto[i] = "FROM: " + texto[i];
            }

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            bool option = false;
            string path;
            if(categoriasBox.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to append the information to an existing file?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (DialogResult.OK == result) option = true;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text file (*.txt)| *.txt";

                if (DialogResult.OK == saveFileDialog.ShowDialog())
                {
                    path = saveFileDialog.FileName;
                    using (StreamWriter sw = new StreamWriter(path, option))
                    {
                        sw.WriteLine(categoriasBox.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chosse category first", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
