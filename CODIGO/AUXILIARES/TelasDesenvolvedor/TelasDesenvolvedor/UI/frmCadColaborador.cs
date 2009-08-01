using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TelasDesenvolvedor.MODEL;

namespace TelasDesenvolvedor.UI
{
    public partial class frmCadColaborador : Form
    {

          #region Atributos
        DAL.AcessoDados dal;
        #endregion Atributos

        public frmCadColaborador()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            mCadColaborador modelColaborador = new mCadColaborador();
            BUSINESS.rCadColaborador regraMenu = new BUSINESS.rCadColaborador();
            try
            {
                modelColaborador = this.PegaDadosTela();
                regraMenu.cadastraColaborador(modelColaborador);
                MessageBox.Show("Cadastrado com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                modelColaborador = null;
            }
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
             //Varre todos os controles da tela.
            //---------------------------------
            foreach (Control controles in this.Controls)
            {
                //Verifica se é TextBox
                //---------------------
                if (controles.GetType().Equals(new TextBox().GetType()) == true)
                {
                    //Caso seja apaga seu conteudo
                    //----------------------------
                    controles.Text = string.Empty;
                }
            }
        }
   }
}
