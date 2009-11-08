using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            FolderBrowserDialog busca = new FolderBrowserDialog();
            busca.ShowNewFolderButton = false;
            DialogResult resultado = busca.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Dispatcher dispatcher = new Dispatcher(@"Provider=SQLNCLI.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Megatechdatabase;Data Source=KAUE-PC\SQLEXPRESS", busca.SelectedPath);

                try
                {
                    dispatcher.Start();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
                Console.Read();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}