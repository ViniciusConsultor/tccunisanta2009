using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmCadFornecedor : FormPai
    {
        public frmCadFornecedor()
        {
            InitializeComponent();
        }

        private void BuscaEstado()
        {
            rEstado regraEstado = new rEstado();
            try
            {
                this.cboUf.DisplayMember = "slg_est";
                this.cboUf.ValueMember = "Estado";
                this.cboUf.DataSource = regraEstado.BuscaEstado();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraEstado = null;
            }
        }

        private mFornecedor PegaDadosTela()
        {
            mFornecedor model = new mFornecedor();
            rFornecedor regra = new rFornecedor();

            try
            {
                model.Bairro = this.txtBairro.Text;
                string cep = this.txtCepFornecedor.Text.Replace("-", string.Empty).Replace(" ", string.Empty);
                if (string.IsNullOrEmpty(cep)==true)
                {
                    model.CepFornecedor = null;
                }
                else
                {
                    model.CepFornecedor = Convert.ToInt32(cep);
                }
                model.Cidade = this.txtCidade.Text;
                if (string.IsNullOrEmpty(this.txtCnpj.Text) == true)
                {
                    model.Cnpj = null;
                }
                else
                {
                    model.Cnpj = this.txtCnpj.Text;
                }
                model.Complemento = this.txtComplemento.Text;
                model.DatAtl = DateTime.Now;
                model.FlgAtivo = true;
                model.SlgEstado = this.cboUf.GetItemText(this.cboUf.SelectedItem);
                model.NomeFornecedor = this.txtNomeFornecedor.Text;
                if (string.IsNullOrEmpty(this.txtDDD.Text) == true)
                {
                    model.Ddd = null;
                }
                else
                {
                    model.Ddd = Convert.ToInt32(this.txtDDD.Text);
                }
                string tel = this.txtTelefone.Text.Replace("-", string.Empty).Replace(" ", string.Empty);
                if (string.IsNullOrEmpty(tel) == true)
                {
                    model.Telefone = null;
                }
                else
                {                    
                    model.Telefone = Convert.ToInt32(tel);
                }
                if (string.IsNullOrEmpty(this.txtEmail.Text) == true)
                {
                    model.Email = null;
                }
                else
                {
                    model.Email = this.txtEmail.Text;
                }
                if (string.IsNullOrEmpty(this.txtNumeroEndereco.Text) == true)
                {
                    model.NroFornecedor = null;
                }
                else
                {
                    model.NroFornecedor = Convert.ToInt32(this.txtNumeroEndereco.Text);
                }
                model.RuaFornecedor = this.txtRua.Text;
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                model = null;
            }
        }

        private void frmCadFornecedor_Load(object sender, EventArgs e)
        {
            this.BuscaEstado();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            rFornecedor regra = new rFornecedor();
            mFornecedor model;
            try
            {
                //this.ValidadadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
            }
            catch (BUSINESS.Exceptions.Fornecedor.FornecedorSemIdExecption)
            {
                MessageBox.Show("É Necessário o campo Codigo Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                regra = null;
                model = null;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }
        /*private void ValidadadosNulos()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtCodigoFornecedor.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Fornecedor.FornecedorSemIdExecption();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/

        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
    }
}
