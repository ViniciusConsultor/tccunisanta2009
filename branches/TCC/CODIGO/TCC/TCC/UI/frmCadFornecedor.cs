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
    public partial class frmCadFornecedor : Form
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

        private void BuscaIdMaximo()
        {
            rFornecedor regra = new rFornecedor();
            try
            {
                this.txtCodigoFornecedor.Text = regra.BuscaIdMaximoFornecedor().ToString();
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
                model.CepFornecedor = Convert.ToInt32(this.txtCep.Text + this.txtCep2.Text);
                model.Cidade = this.txtCidade.Text;
                model.Cnpj = Convert.ToInt32(this.txtCnpj.Text);
                model.Complemento = this.txtComplemento.Text;
                model.DatAtl = DateTime.Now;
                model.FlgAtivo = true;
                model.IdEstado = Convert.ToInt32(this.cboUf.SelectedValue);
                model.IdFornecedor = Convert.ToInt32(this.txtCodigoFornecedor.Text);
                model.NomeFornecedor = this.txtNomeFornecedor.Text;
                model.NroFornecedor = Convert.ToInt32(this.txtNumeroEndereco.Text);
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

        private void ApagaDadosTela()
        {
            foreach (Control controle in this.Controls)
            {
                if (controle.GetType().Equals(new TextBox().GetType()) == true)
                {
                    if (controle.Name.Equals("txtCodigoFornecedor") == false)
                    {
                        controle.Text = string.Empty;
                    }
                }
            }
            this.cboUf.SelectedIndex = 0;
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
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.ApagaDadosTela();
                this.BuscaIdMaximo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
                model = null;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            this.ApagaDadosTela();
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

    }
}
