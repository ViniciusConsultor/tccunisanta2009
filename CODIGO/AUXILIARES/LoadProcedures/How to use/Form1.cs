using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

using LoadProcedures;

namespace How_to_use
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings settConex = ConfigurationManager.ConnectionStrings["How_to_use.Properties.Settings.MegatechdatabaseConnectionString"];
            OpenFileDialog busca = new OpenFileDialog();
            if (String.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                busca.InitialDirectory = textBox1.Text;
            }
            DialogResult resultado = busca.ShowDialog();
            if (resultado == DialogResult.Cancel)
            {
                return;
            }
            string diretorio = busca.FileName;
            diretorio = diretorio.Substring(0, diretorio.LastIndexOf("\\"));
            textBox1.Text = diretorio;
            Dispatcher dispatcher;
            dispatcher = new Dispatcher(settConex.ConnectionString, diretorio);
            try
            {
                dispatcher.Start();
                MessageBox.Show("Procedures Executadas com sucesso!");
                Application.Exit();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                settConex = null;
                busca.Dispose();
                busca = null;
                dispatcher = null;
            }
        }
    }
}