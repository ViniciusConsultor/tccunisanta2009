using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AlteraScriptCriacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text.Trim()) == true)
            {
                MessageBox.Show("Falta o caminho do arquivo");
                return;
            }
            AlteraNomes(textBox1.Text.Trim());

            MessageBox.Show("Script alterado com sucesso.");
        }

        private void AlteraNomes(string caminhoArquivo)
        {
            string NovoArquivo = caminhoArquivo + "novo";
            if (File.Exists(caminhoArquivo + "novo") == true)
            {
                File.Delete(caminhoArquivo + "novo");
            }

            AlterarScript(caminhoArquivo, NovoArquivo);
            
            if (File.Exists(caminhoArquivo + "tmp") == true)
            {
                File.Delete(caminhoArquivo + "tmp");
            }
            File.Copy(caminhoArquivo, caminhoArquivo + "tmp");

            if (File.Exists(caminhoArquivo) == true)
            {
                File.Delete(caminhoArquivo);
            } 
            File.Delete(caminhoArquivo);
            
            File.Copy(NovoArquivo, caminhoArquivo);
            if (File.Exists(caminhoArquivo + "tmp") == true)
            {
                File.Delete(caminhoArquivo + "tmp");
            }

            if (File.Exists(caminhoArquivo + "novo") == true)
            {
                File.Delete(caminhoArquivo + "novo");
            }
        }

        private void AlterarScript(string caminhoArquivo, string NovoArquivo)
        {
            StreamReader sr = null;
            StreamWriter sw = null;
            const string DropTable = "DROP TABLE ";
            const string ifExist = "IF EXISTS (SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='";
            try
            {
                sr = new StreamReader(caminhoArquivo);
                sw = new StreamWriter(NovoArquivo);
                string linha, nomeTabela;

                while (sr.EndOfStream == false)
                {
                    linha = sr.ReadLine();
                    int pos = linha.IndexOf(DropTable);
                    if (pos == 0)
                    {
                        // existe um drop sem if exist
                        nomeTabela = linha.Substring(DropTable.Length, linha.Length - DropTable.Length);
                        sw.WriteLine(ifExist + nomeTabela + "')");
                        sw.WriteLine(linha);
                    }
                    else
                    {
                        sw.WriteLine(linha);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.Message);    
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                }
                if (sw != null)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            OpenFileDialog oJanela = new OpenFileDialog();
            oJanela.Multiselect = false;
            oJanela.ShowDialog();

            textBox1.Text = oJanela.FileName;
        }
    }
}
