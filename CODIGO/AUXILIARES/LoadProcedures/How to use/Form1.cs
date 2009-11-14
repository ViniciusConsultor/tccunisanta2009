using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            ConnectionStringSettings settConex = ConfigurationManager.ConnectionStrings["TCC.Properties.Settings.MegatechConnectionString"];
            FolderBrowserDialog busca = new FolderBrowserDialog();
            busca.ShowNewFolderButton = false;
            DialogResult resultado = busca.ShowDialog();
            Dispatcher dispatcher;
            if (resultado == DialogResult.OK)
            {
                dispatcher = new Dispatcher(settConex.ConnectionString, busca.SelectedPath);

                try
                {
                    dispatcher.Start();
                    MessageBox.Show("Procedures Executadas com sucesso!");
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
            else
            {
                Application.Exit();
            }
        }
    }
}