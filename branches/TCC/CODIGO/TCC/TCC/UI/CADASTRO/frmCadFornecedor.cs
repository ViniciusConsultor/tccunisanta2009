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
                this.cboUf.DisplayMember = "slg_estado";
                this.cboUf.ValueMember = "id_estado";
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

        protected override void BuscaIdMaximo()
        {
            rFornecedor regra = new rFornecedor();
            try
            {
                this.txtCodigoFornecedor.Text = regra.BuscaIdMaximoFornecedor();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
            }
        }

        private mFornecedor PegaDadosTela()
        {
            mFornecedor model = new mFornecedor();
            try
            {
                model.Bairro = this.txtBairro.Text;
                if (string.IsNullOrEmpty(this.txtCep.Text) == true && string.IsNullOrEmpty(this.txtCep2.Text) == true)
                {
                    model.CepFornecedor = null;
                }
                else
                {
                    model.CepFornecedor = Convert.ToInt32(this.txtCep.Text + this.txtCep2.Text);
                }
                model.Cidade = this.txtCidade.Text;
                if (string.IsNullOrEmpty(this.txtCnpj.Text) == true)
                {
                    model.Cnpj = null;
                }
                else
                {
                    model.Cnpj = Convert.ToInt32(this.txtCnpj.Text);
                }
                model.Complemento = this.txtComplemento.Text;
                model.DatAtl = DateTime.Now;
                model.FlgAtivo = true;
                model.SlgEstado = this.cboUf.GetItemText(this.cboUf.SelectedItem);
                model.IdFornecedor = Convert.ToInt32(this.txtCodigoFornecedor.Text);
                model.NomeFornecedor = this.txtNomeFornecedor.Text;
                if (string.IsNullOrEmpty(this.txtDDD.Text) == true)
                {
                    model.Ddd = null;
                }
                else
                {
                    model.Ddd = Convert.ToInt32(this.txtDDD.Text);
                }
                if (string.IsNullOrEmpty(this.txtTelefone.Text) == true)
                {
                    model.Telefone = null;
                }
                else
                {
                    model.Telefone = Convert.ToInt32(this.txtTelefone.Text);
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
            this.BuscaIdMaximo();
            this.BuscaEstado();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            rFornecedor regra = new rFornecedor();
            mFornecedor model;
            try
            {
                this.ValidadadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
                this.BuscaIdMaximo();
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
            this.BuscaIdMaximo();
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCep.TextLength == 5)
            {
                this.txtCep2.Focus();
            }
        }

        private void txtCep2_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCep2.TextLength == 3)
            {
                this.cboUf.Focus();
            }
        }

        private void ValidadadosNulos()
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
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
    }
}
