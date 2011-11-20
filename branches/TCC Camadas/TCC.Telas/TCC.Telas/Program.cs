﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TCC.Regra;

namespace TCC.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (rInicio.ConectarBanco())
            {
                Application.Run(new frmLogin());
            }
            else
            {
                MessageBox.Show("Erro ao Abrir a conexão com o Banco de Dados", "Atenção", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}
