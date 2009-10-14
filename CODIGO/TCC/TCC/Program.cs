using System;
using TCC.DAL;
using System.Windows.Forms;

namespace TCC
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
            if (ConectaBanco.ConectaBancoDados() == true)
            {
                Application.Run(new UI.BUSCA.frmBuscaMotor(new TextBox()));
            }
            else
            {
                MessageBox.Show("Erro ao Abrir a conexão com o Banco de Dados", "Atenção", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}
