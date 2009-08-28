using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmCadColaborador : Form
    {
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

        private mCadColaborador PegaDadosTela()
        {
            mCadColaborador model = new mCadColaborador();
            model.BairrEnd = txtBairro.Text;
            model.Cep = txtCEP.Text;
            model.Cidade = txtCidade.Text;
            model.ComplEnd = txtComplemento.Text;
            model.Cpf = txtCpf.Text;
            model.DatNasc = new DateTime(Convert.ToInt32(txtDataYyyy.Text),Convert.ToInt32(txtDataMm.Text),Convert.ToInt32(txtDataDd.Text));
            model.Estado = txtEstado.Text;
            model.IdColab = Convert.ToInt32(txtCdColab.Text);
            model.IdDepto = Convert.ToInt32(txtCdDepartamento.Text);
            model.IdUsuario = Convert.ToInt32(txtCdUsuario.Text);
            model.NomeColab = txtNome.Text;
            model.NomeRua = txtRua.Text;
            model.NroEnd = Convert.ToInt32(txtNumero.Text);
            model.Sexo = Convert.ToChar(CbSexo.Text);
            model.Rg = txtRg.Text;

            return model;
        }
   }
}
