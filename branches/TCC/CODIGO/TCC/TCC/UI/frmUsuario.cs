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
    public partial class frmUsuario : Form
    {

         #region Atributos
        DAL.AcessoDados dal;
        #endregion Atributos


        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
             mUsuario modelUsuario = new mUsuario();
            BUSINESS.rUsuario regraUsuario = new BUSINESS.rUsuario();
            try
            {
                modelUsuario = this.pegaDadosTela();
                regraUsuario.CadastraUsuario(modelUsuario);
                MessageBox.Show("Cadastrado com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                modelUsuario = null;
            }
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
        private mUsuario pegaDadosTela()
        {
            mUsuario model = new mUsuario();
            model.IdUsuario = Convert.ToInt32(txtId.Text);
            model.LoginUsuario1 = txtLoginUsuario.Text;
            model.DescUsuario1 = txtDescUsuario.Text;
            model.Senha1 = txtSenha.Text;
            model.TipoUsuario = Convert.ToChar(txtTipoUsuario.Text);
            model.DescTipoUsuario = txtDescTipoUsuario.Text;

            return model;
        }
    }
}
