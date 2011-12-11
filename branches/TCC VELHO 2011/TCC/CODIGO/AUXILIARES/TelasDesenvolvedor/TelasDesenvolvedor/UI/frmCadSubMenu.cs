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
    public partial class frmCadSubMenu : Form
    {

        #region Atributos
        DAL.AcessoDados dal;
        #endregion Atributos

        public frmCadSubMenu()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
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

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            mSubMenu modelMenu = new mSubMenu();
            BUSINESS.rSubMenu regraMenu = new BUSINESS.rSubMenu();
            try
            {
                modelMenu = this.PegaDadosTela();
                regraMenu.CadastraSubMenu(modelMenu);
                MessageBox.Show("Cadastrado com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                modelMenu = null;
            }
        }

        /// <summary>
        /// Pega os dados que estão na tela e popula o model
        /// </summary>
        /// <returns>Model populado</returns>
        private mSubMenu PegaDadosTela()
        {
            mSubMenu model = new mSubMenu();
            model.IdSubMenu = Convert.ToInt32(txtIdSubMenu.Text);
            model.DscSubMenu = txtDescricaoSubMenu.Text;
            model.EndSubMenu = txtEnderecoSubMenu.Text;
            return model;
        }
    }
}
