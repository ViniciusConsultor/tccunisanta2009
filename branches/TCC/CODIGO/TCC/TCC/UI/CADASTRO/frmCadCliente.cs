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
    public partial class frmCadCliente : FormPai
    {
        mCliente _modelCliente;

        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void BuscaEstados()
        {
            rEstado regraEstado = new rEstado();
            try
            {
                this.cboEstado.DisplayMember = "slg_est";
                this.cboEstado.ValueMember = "Estado";
                this.cboEstado.DataSource = regraEstado.BuscaEstado();
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

        private mCliente PegaDadosTela()
        {
            mCliente model = new mCliente();
            rCliente regra = new rCliente();

            try
            {
                if (string.IsNullOrEmpty(this.txtBairro.Text) == true)
                {
                    model.Bairro = null;
                }
                else
                {
                    model.Bairro = this.txtBairro.Text;
                }
                if (this.txtCep.Modified == true)
                {
                    model.Cep = null;
                }
                else
                {
                    model.Cep = Convert.ToInt32(this.txtCep.Text.Replace("-",String.Empty));
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
                model.ComplementoEndereco = this.txtComplemento.Text;
                model.DatAtl = DateTime.Now;
                model.FlgAtivo = true;
                model.SlgEstado = this.cboEstado.GetItemText(this.cboEstado.SelectedItem);
                model.NomeCliente = this.txtNome.Text;
                model.NomeRua = this.txtRua.Text;
                if (string.IsNullOrEmpty(this.txtNumero.Text) == true)
                {
                    model.NumeroEndereco = null;
                }
                else
                {
                    model.NumeroEndereco = Convert.ToInt32(this.txtNumero.Text);
                }
                model.TelefoneCliente = Convert.ToInt32(this.txtTelefone.Text);
                if (string.IsNullOrEmpty(this.txtDDD.Text) == true)
                {
                    model.Ddd = null;
                }
                else
                {
                    model.Ddd = Convert.ToInt32(this.txtDDD.Text);
                }
                if (string.IsNullOrEmpty(this.txtEmail.Text) == true)
                {
                    model.Email = null;
                }
                else
                {
                    model.Email = this.txtEmail.Text;
                }
                if (base.Alteracao == true)
                {
                    model.IdCliente = this._modelCliente.IdCliente;
                }
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

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            this.BuscaEstados();
            this.AtribuiTipoTextBox();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            rCliente regra = new rCliente();
            mCliente model;
            try
            {
                this.validaDadosNulos();
                model = this.PegaDadosTela();
                if (base.Alteracao == true)
                {
                    regra.ValidarAltera(model);
                }
                else
                {
                    regra.ValidarInsere(model);
                }
                this.btnLimpa_Click(null, null);
            }
            catch (BUSINESS.Exceptions.Cliente.NomeClienteVazioException)
            {
                MessageBox.Show("Preencher o campo nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNome.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.CpfCnpjVazioException)
            {
                MessageBox.Show("Preencher o CPF ou o CNPJ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCPF.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.DadosComunicacaoVazioException)
            {
                MessageBox.Show("Preencher algum campo para contato(DDD e Telefone ou E-mail)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDDD.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.DDDClienteVazioException)
            {
                MessageBox.Show("Preencher o campo DDD", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDDD.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.TelefoneClienteVazioException)
            {
                MessageBox.Show("Preencher o campo telefone", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtTelefone.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.EmailClienteVazioException)
            {
                MessageBox.Show("Preencher o campo e-mail", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtTelefone.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.CidadeClienteVazioException)
            {
                MessageBox.Show("Preencher o campo cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCidade.Focus();
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

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelCliente = null;
            base.Alteracao = false;
        }

        void btnVolta_Click(object sender, System.EventArgs e)
        {
            base.FechaTela(this);
        }

        private void AtribuiTipoTextBox()
        {
            txtDDD._tipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            txtNumero._tipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
        }

        private void btnBuscaAlteracaoDelecao_Click(object sender, EventArgs e)
        {
            this.btnLimpa_Click(null, null);
            this._modelCliente = new mCliente();
            frmBuscaCliente objCliente = new frmBuscaCliente(this._modelCliente, true);
            try
            {
                DialogResult resultado = objCliente.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelCliente = null;
                }
                else
                {
                    this.PopulaTelaComModelAlteracao();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objCliente = null;
            }
        }

        private void PopulaTelaComModelAlteracao()
        {
            if (this._modelCliente != null)
            {
                base.Alteracao = true;
                this.txtBairro.Text = this._modelCliente.Bairro;
                this.txtCep.Text = this._modelCliente.Cep.ToString();
                this.txtCidade.Text = this._modelCliente.Cidade;
                this.txtCnpj.Text = this._modelCliente.Cnpj.ToString();
                this.txtCPF.Text = this._modelCliente.Cpf;
                this.txtComplemento.Text = this._modelCliente.ComplementoEndereco;
                this.txtDDD.Text = this._modelCliente.Ddd.ToString();
                this.txtEmail.Text = this._modelCliente.Email;
                this.txtNome.Text = this._modelCliente.NomeCliente;
                this.txtNumero.Text = this._modelCliente.NumeroEndereco.ToString();
                this.txtRua.Text = this._modelCliente.NomeRua;
                this.txtTelefone.Text = this._modelCliente.TelefoneCliente.ToString();
                this.cboEstado.SelectedIndex = this.cboEstado.FindString(this._modelCliente.SlgEstado);
            }
        }

        public void validaDadosNulos()
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtNome.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.NomeClienteVazioException();
                }
                else if (this.txtCnpj.Modified == true && this.txtCPF.Modified == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.CpfCnpjVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(this.txtDDD.Text) == true && this.txtTelefone.Modified == false)
                {
                    throw new BUSINESS.Exceptions.Cliente.DadosComunicacaoVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(this.txtDDD.Text) == true && string.IsNullOrEmpty(this.txtTelefone.Text) == false)
                {
                    throw new BUSINESS.Exceptions.Cliente.DDDClienteVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(this.txtDDD.Text) == false && string.IsNullOrEmpty(this.txtTelefone.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.TelefoneClienteVazioException();
                }
                else if (string.IsNullOrEmpty(txtEmail.Text) == true && string.IsNullOrEmpty(txtDDD.Text) == true && string.IsNullOrEmpty(txtTelefone.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.EmailClienteVazioException();
                }
                else if (string.IsNullOrEmpty(txtCidade.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.CidadeClienteVazioException();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
