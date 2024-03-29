﻿using System;
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
        #region Atributos
        mCliente _modelCliente;
        #endregion Atributos

        #region Construtor
        public frmCadCliente()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Metodos

        #region Busca Estados
        /// <summary>
        /// Busca os estados para popular o combo
        /// </summary>
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
        #endregion Busca Estados

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados que estão na tela e popula o model
        /// </summary>
        /// <returns>Model populado</returns>
        private mCliente PegaDadosTela()
        {
            mCliente model = new mCliente();
            rCliente regra = new rCliente();

            try
            {
                if (base.Alteracao == true)
                {
                    model.IdCliente = this._modelCliente.IdCliente;
                }
                else
                {
                    model.IdCliente = regra.BuscaIdMaximo();
                }
                model.NomeCliente = this.txtNome.Text;

                if (string.IsNullOrEmpty(this.txtDDI.Text) == true)
                {
                    model.Ddi = null;
                }
                else
                {
                    model.Ddi = this.txtDDI.Text;
                }
                if (string.IsNullOrEmpty(this.txtDDD.Text) == true)
                {
                    model.Ddd = null;
                }
                else
                {
                    model.Ddd = Convert.ToInt32(this.txtDDD.Text);
                }
                if (this.txtTelefone.Visible == true)
                {
                    string tel = this.txtTelefone.Text.Replace("-", string.Empty);
                    tel = tel.Replace(" ", string.Empty);
                    if (string.IsNullOrEmpty(tel) == true)
                    {
                        model.TelefoneCliente = null;
                    }
                    else
                    {
                        model.TelefoneCliente = Convert.ToInt32(tel);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(this.txtTelefoneInter.Text) == true)
                    {
                        model.TelefoneCliente = null;
                    }
                    else
                    {
                        model.TelefoneCliente = Convert.ToInt32(this.txtTelefoneInter.Text);
                    }
                }

                model.NomeRua = this.txtRua.Text;
                if (string.IsNullOrEmpty(this.txtNumero.Text) == true)
                {
                    model.NumeroEndereco = null;
                }
                else
                {
                    model.NumeroEndereco = Convert.ToInt32(this.txtNumero.Text);
                }
                model.ComplementoEndereco = this.txtComplemento.Text;

                string cep = txtCep.Text.Replace("-", string.Empty);
                cep = cep.Replace(" ", string.Empty);
                if (this.txtCep.Visible == true)
                {
                    model.CodPostal = cep;
                }
                else
                {
                    model.CodPostal = this.txtCodPostal.Text;
                }

                if (string.IsNullOrEmpty(this.txtBairro.Text) == true)
                {
                    model.Bairro = null;
                }
                else
                {
                    model.Bairro = this.txtBairro.Text;
                }
                model.Cidade = this.txtCidade.Text;

                string cpf = this.txtCPF.Text.Replace("-", string.Empty);
                cpf = cpf.Replace(".", string.Empty);
                cpf = cpf.Replace(" ", string.Empty);
                if (string.IsNullOrEmpty(cpf) == true)
                {
                    model.Cpf = null;
                }
                else
                {
                    model.Cpf = cpf;
                }

                string cnpj = this.txtCnpj.Text.Replace("-", string.Empty);
                cnpj = cnpj.Replace(".", string.Empty);
                cnpj = cnpj.Replace("/", string.Empty);
                cnpj = cnpj.Replace(" ", string.Empty);
                if (string.IsNullOrEmpty(cnpj) == true)
                {
                    model.Cnpj = null;
                }
                else
                {
                    model.Cnpj = Convert.ToDecimal(cnpj);
                }

                model.DatAtl = DateTime.Now;
                model.FlgAtivo = true;
                if (string.IsNullOrEmpty(this.txtEmail.Text) == true)
                {
                    model.Email = null;
                }
                else
                {
                    model.Email = this.txtEmail.Text;
                }

                if (this.rdbBrasil.Checked == true)
                {
                    model.Nom_pais = "Brasil";
                    model.Nom_est_inter = null;
                    model.IdentInter = null;
                }
                else
                {
                    model.Nom_pais = this.txtPais.Text;
                    model.Nom_est_inter = this.txtEstado.Text;
                    model.IdentInter = this.txtIdentInter.Text;
                }

                if (this.cboEstado.Enabled == true)
                {
                    model.SlgEstado = this.cboEstado.GetItemText(this.cboEstado.SelectedItem);
                }
                else
                {
                    model.SlgEstado = null;
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
        #endregion Pega Dados Tela

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere()
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
                    regra.ValidaDados(model);
                    regra.ValidarInsere(model);
                }
                this.btnLimpa_Click(null, null);
                this.btnInsere.Enabled = false;
                this.rdbBrasil.Checked = true;
                this.txtCPF.Text = "";
                this.txtCnpj.Text = "";
                MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Cliente.NomeClienteVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNome.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.paisVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo País", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtPais.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.EstadoVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Estado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtEstado.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.CidadeClienteVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCidade.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.RuaClieteVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Rua", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtRua.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.NroEnderecoClienteVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Número", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNumero.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.BairroClienteVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Bairro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtBairro.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.CEPVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo CEP", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCep.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.CodigoPostalVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Código Postal", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodPostal.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.DadosComunicacaoVazioException)
            {
                MessageBox.Show("É Necessário Preencher um dos campos para contato ('DDI, DDD e Telefone' ou 'E-mail')", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDDI.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.DDIClienteVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo DDI", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDDD.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.DDDClienteVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo DDD", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDDD.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.TelefoneClienteVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo telefone", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                if (this.txtTelefone.Visible == true)
                {
                    this.txtTelefone.Focus();
                }
                else
                {
                    this.txtTelefoneInter.Focus();
                }
            }
            catch (BUSINESS.Exceptions.Cliente.EmailClienteVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo E-mail", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtTelefone.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.CpfCnpjVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo CPF ou o CNPJ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.rdbPessoaFisica.Checked = true;
            }
            catch (BUSINESS.Exceptions.Cliente.IdentidadeInterVazioException)
            {
                MessageBox.Show("É Necessário Preencher o código de Identificação Internacional", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtIdentInter.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.CPFClienteExistente)
            {
                MessageBox.Show("Código de CPF já existente. Favor Informar ou código.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCPF.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.CNPJClienteExistente)
            {
                MessageBox.Show("Código de CNPJ já existente. Favor Informar ou código.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCnpj.Focus();
            }
            catch (BUSINESS.Exceptions.Cliente.IdentInterExistenteException)
            {
                MessageBox.Show("Código de Identificação Internacional já existente. Favor Informar ou código.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtIdentInter.Focus();
            }
            catch (BUSINESS.Exceptions.Validacoes.EmailInvalidoException)
            {
                MessageBox.Show("Campo E-mail incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtEmail.Focus();
            }
            catch (BUSINESS.Exceptions.Validacoes.MaskedInvalidaException ex)
            {
                MessageBox.Show(ex.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
        #endregion Insere

        #region Popula Tela Com Model Alteracao
        /// <summary>
        /// Popula a tela com o model construido pela tela de busca
        /// </summary>
        private void PopulaTelaComModelAlteracao()
        {
            if (this._modelCliente != null)
            {
                base.Alteracao = true;
                this.txtBairro.Text = this._modelCliente.Bairro;
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
        #endregion Popula Tela Com Model Alteracao

        #region Valida Dados Nulos
        /// <summary>
        /// Valida dados nulos
        /// </summary>
        public void validaDadosNulos()
        {
            string cnpj = this.txtCnpj.Text.Replace("-", string.Empty);
            cnpj = cnpj.Replace(" ", string.Empty);
            cnpj = cnpj.Replace("/", string.Empty);
            cnpj = cnpj.Replace(".", string.Empty);

            string cpf = this.txtCPF.Text.Replace("-", string.Empty);
            cpf = cpf.Replace(" ", string.Empty);
            cpf = cpf.Replace(".", string.Empty);

            string tel = this.txtTelefone.Text.Replace("-", string.Empty);
            tel = tel.Replace(" ", string.Empty);

            string cep = this.txtCep.Text.Replace("-", string.Empty);
            cep = cep.Replace(" ", string.Empty);

            try
            {
                if (string.IsNullOrEmpty(this.txtNome.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.NomeClienteVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtPais.Text) == true && this.txtPais.Enabled == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.paisVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtEstado.Text) == true && this.txtEstado.Enabled == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.EstadoVazioException();
                }
                else if (string.IsNullOrEmpty(txtCidade.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.CidadeClienteVazioException();
                }
                else if (string.IsNullOrEmpty(txtRua.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.RuaClieteVazioException();
                }
                else if (string.IsNullOrEmpty(txtNumero.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.NroEnderecoClienteVazioException();
                }
                else if (string.IsNullOrEmpty(txtBairro.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.BairroClienteVazioException();
                }
                else if (string.IsNullOrEmpty(cep) == true && this.txtCep.Visible == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.CEPVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtCodPostal.Text) == true && this.txtCodPostal.Visible == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.CodigoPostalVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(this.txtDDI.Text) == true && string.IsNullOrEmpty(this.txtDDD.Text) == true && string.IsNullOrEmpty(tel) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.DadosComunicacaoVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(this.txtDDI.Text) == true && this.txtDDI.Enabled == true)
                {
                    throw new BUSINESS.Exceptions.Fornecedor.DDIVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(this.txtDDD.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.DDDClienteVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(tel) == true && this.txtTelefone.Visible == true || string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(this.txtTelefoneInter.Text) == true && this.txtTelefoneInter.Visible == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.TelefoneClienteVazioException();
                }
                else if (string.IsNullOrEmpty(txtEmail.Text) == true && string.IsNullOrEmpty(txtDDD.Text) == true && string.IsNullOrEmpty(tel) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.EmailClienteVazioException();
                }
                else if (this.panelOutros.Visible == false && string.IsNullOrEmpty(cnpj) == true && string.IsNullOrEmpty(cpf) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.CpfCnpjVazioException();
                }
                else if (this.panelOutros.Visible == true && string.IsNullOrEmpty(this.txtIdentInter.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.IdentidadeInterVazioException();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Valida Dados Nulos

        #endregion Metodos

        #region Eventos

        #region Form Load
        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            this.BuscaEstados();

            //Desabilita/Torna invisíveis campos estrangeiros ao iniciar a tela(padrão Brasil)
            //-------------------------------------------------------------------------------
            this.txtPais.Enabled = false;
            this.txtEstado.Enabled = false;

            this.panelOutros.Visible = false;

            this.lblCodPostal.Visible = false;
            this.txtCodPostal.Visible = false;

            this.txtDDI.Text = "55";
            this.txtDDI.Enabled = false;

            this.txtCnpj.Enabled = false;

            this.txtTelefoneInter.Visible = false;
        }
        #endregion Form Load

        #region btnInsere Click
        private void btnInsere_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnInsere Click

        #region btnLimpa Click
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.rdbBrasil.Checked = true;
            this._modelCliente = null;
            base.Alteracao = false;
        }
        #endregion btnLimpa Click

        #region btnVolta Click
        void btnVolta_Click(object sender, System.EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVolta Click

        #region btnBuscaAlteracaoDelecao Click
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
        #endregion btnBuscaAlteracaoDelecao Click

        #region txtNome TextChanged
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            btnInsere.Enabled = true;
        }
        #endregion  txtNome TextChanged

        #region rdbBrasil CheckedChanged
        private void rdbBrasil_CheckedChanged(object sender, EventArgs e)
        {
            //Desabilita/Torna invisíveis campos estrangeiros ao iniciar a tela(padrão Brasil)
            //-------------------------------------------------------------------------------
            this.cboEstado.Enabled = true;

            this.txtPais.Enabled = false;
            this.txtPais.Text = "";
            this.txtEstado.Enabled = false;
            this.txtEstado.Text = "";

            this.panelOutros.Visible = false;
            this.txtIdentInter.Text = "";
            this.panelBrasil.Visible = true;
            this.rdbPessoaFisica.Enabled = true;
            this.rdbPessoaFisica.Checked = true;
            this.txtCPF.Enabled = true;
            this.txtCPF.Text = "";

            this.lblCodPostal.Visible = false;
            this.txtCodPostal.Visible = false;
            this.txtCodPostal.Text = "";
            this.lblCep.Visible = true;
            this.txtCep.Visible = true;

            this.txtDDI.Text = "55";
            this.txtDDI.Enabled = false;

            this.txtTelefone.Visible = true;
            this.txtTelefoneInter.Visible = false;
            this.txtTelefoneInter.Text = "";
        }
        #endregion rdbBrasil CheckedChanged

        #region rdbOutros CheckedChanged
        private void rdbOutros_CheckedChanged(object sender, EventArgs e)
        {
            //Desabilita/Torna invisíveis campos estrangeiros ao iniciar a tela(padrão Internacional)
            //-------------------------------------------------------------------------------
            this.cboEstado.Enabled = false;
            this.cboEstado.SelectedIndex = 0;

            this.txtPais.Enabled = true;
            this.txtEstado.Enabled = true;

            this.panelOutros.Visible = true;
            this.rdbPessoaFisica.Checked = true;
            this.rdbPessoaFisica.Enabled = false;
            this.txtCPF.Text = "";
            this.txtCPF.Enabled = false;

            this.lblCep.Visible = false;
            this.txtCep.Visible = false;
            this.txtCep.Text = "";
            this.lblCodPostal.Visible = true;
            this.txtCodPostal.Visible = true;

            this.txtDDI.Enabled = true;
            this.txtDDI.Text = "";

            this.txtTelefone.Visible = false;
            this.txtTelefone.Text = "";
            this.txtTelefoneInter.Visible = true;
        }
        #endregion rdbOutros CheckedChanged

        #region rdbPessoaFisica CheckedChanged
        private void rdbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCnpj.Enabled = false;
            this.txtCnpj.Text = "";
            this.txtCPF.Enabled = true;
            this.txtCPF.Focus();
        }
        #endregion rdbPessoaFisica CheckedChanged

        #region rdbPessoaJuridica CheckedChanged
        private void rdbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCPF.Enabled = false;
            this.txtCPF.Text = "";
            this.txtCnpj.Enabled = true;
            this.txtCnpj.Focus();
        }
        #endregion rdbPessoaJuridica CheckedChanged

        #endregion Eventos
    }
}
