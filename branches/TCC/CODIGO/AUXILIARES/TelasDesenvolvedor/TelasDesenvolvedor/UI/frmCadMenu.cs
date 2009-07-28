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
    public partial class frmCadMenu : Form
    {

        #region Atributos
        DAL.AcessoDados dal;
        #endregion Atributos

        public frmCadMenu()
        {
            InitializeComponent();
        }

        private void frmCadMenu_Load(object sender, EventArgs e)
        {
            /*dal = new TelasDesenvolvedor.DAL.AcessoDados();
            if (dal.ConectaBanco() == false)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados.");
            }*/
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
            mMenu modelMenu = new mMenu();
            BUSINESS.rMenu regraMenu = new BUSINESS.rMenu();
            try
            {
                modelMenu = this.PegaDadosTela();
                regraMenu.CadastraMenu(modelMenu);
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
        private mMenu PegaDadosTela()
        {
            mMenu model = new mMenu();
            model.IdMenu = Convert.ToInt32(txtIdMenu.Text);
            model.DscMenu = txtDescricaoMenu.Text;
            model.EndMenu = txtEnderecoMenu.Text;
            return model;
        }
    }
}
