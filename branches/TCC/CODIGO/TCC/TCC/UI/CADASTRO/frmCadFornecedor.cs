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
        #region Atributos
        mFornecedor _modelFornecedor;
        List<mFornecedorDepto> _listaModelFornecedorDepto;
        #endregion Atributos

        #region Construtor
        public frmCadFornecedor()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Metodos

        #region Busca Estado
        /// <summary>
        /// Busca o estado para popular o combo
        /// </summary>
        private void BuscaEstado()
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
        #endregion Busca Estado

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados da tela e popula o model
        /// </summary>
        /// <returns>Model populado</returns>
        private mFornecedor PegaDadosTela()
        {
            mFornecedor model = new mFornecedor();
            rFornecedor regra = new rFornecedor();

            try
            {
                model.IdFornecedor = regra.BuscaIdMaximo();
                model.NomeFornecedor = this.txtNomeFornecedor.Text;
                model.RuaFornecedor = this.txtRua.Text;
                if (string.IsNullOrEmpty(this.txtNumeroEndereco.Text) == true)
                {
                    model.NroFornecedor = null;
                }
                else
                {
                    model.NroFornecedor = Convert.ToInt32(this.txtNumeroEndereco.Text);
                }
                model.Complemento = this.txtComplemento.Text;

                if (this.txtCep.Visible == true)
                {
                    string cep = this.txtCep.Text.Replace("-", string.Empty);
                    cep = cep.Replace(" ", string.Empty);

                    if (string.IsNullOrEmpty(cep) == true)
                    {
                        model.CodPostal = null;
                    }
                    else
                    {
                        model.CodPostal = cep;
                    }
                }
                else
                {
                    string codPost = this.txtCodPostal.Text;
                    if (string.IsNullOrEmpty(codPost) == true)
                    {
                        model.CodPostal = null;
                    }
                    else
                    {
                        model.CodPostal = codPost;
                    }
                }

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
                    string tel = this.txtTelefone.Text.Replace("-", string.Empty).Replace(" ", string.Empty);
                    if (string.IsNullOrEmpty(tel) == true)
                    {
                        model.Telefone = null;
                    }
                    else
                    {
                        model.Telefone = Convert.ToInt32(tel);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(this.txtTelefoneInter.Text) == true)
                    {
                        model.Telefone = null;
                    }
                    else
                    {
                        model.Telefone = Convert.ToInt32(this.txtTelefoneInter.Text);
                    }
                }
                
                model.Bairro = this.txtBairro.Text;
                model.Cidade = this.txtCidade.Text;
                if (string.IsNullOrEmpty(this.txtEmail.Text) == true)
                {
                    model.Email = null;
                }
                else
                {
                    model.Email = this.txtEmail.Text;
                }

                string cnpj = this.txtCnpj.Text.Replace(".", string.Empty);
                cnpj = cnpj.Replace("/", string.Empty);
                cnpj = cnpj.Replace("-", string.Empty);
                cnpj = cnpj.Replace(" ", string.Empty);
                if (string.IsNullOrEmpty(cnpj) == true)
                {
                    model.Cnpj = null;
                }
                else
                {
                    model.Cnpj = cnpj;
                }
                model.DatAtl = DateTime.Now;
                model.FlgAtivo = true;

                if (this.cboEstado.Enabled == true)
                {
                    model.SlgEstado = this.cboEstado.GetItemText(this.cboEstado.SelectedItem);
                }
                else
                {
                    model.SlgEstado = null;
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
        /// Pega os dados do model e insere no banco
        /// </summary>
        private void Insere()
        {
            rFornecedor regra = new rFornecedor();
            rFornecedorDepto regraFornecedorDepto = new rFornecedorDepto();
            mFornecedor model;
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidaDados(model);
                regra.ValidarInsere(model);
                if (this._listaModelFornecedorDepto != null)
                {
                    if (this._listaModelFornecedorDepto.Count > 0)
                    {
                        this.PopulaListaFornecedorDeptoIdForn(Convert.ToInt32(model.IdFornecedor));
                        foreach (mFornecedorDepto modelFornecedorDepto in this._listaModelFornecedorDepto)
                        {
                            regraFornecedorDepto.ValidarInsere(modelFornecedorDepto);
                        }
                    }
                }

                base.LimpaDadosTela(this);
                this.btnInsere.Enabled = false;
                MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Fornecedor.NomeFornecedorVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Nome Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNomeFornecedor.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.paisVazioException)
            {
                MessageBox.Show("É Necessário Prencher o campo País", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtPais.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.EstadoVazioException)
            {
                MessageBox.Show("É Necessário Prencher o campo Província(Estado)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtEstado.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.CidadeVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCidade.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.CEPVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo CEP", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCep.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.CodigoPostalVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Código Postal", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodPostal.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.CnpjVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo CNPJ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCnpj.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.IdentidadeInterVazioException)
            {
                MessageBox.Show("É Necessário Preencher o código de Identificação Internacional", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtIdentInter.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.DadosComunicacaoVazioExeception)
            {
                MessageBox.Show("É Necessário Preencher os campos 'DDI, DDD e Telefone' ou 'E-mail'", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Fornecedor.DDIVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo DDI", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDDI.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.DddVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo DDD", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDDD.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.TelefoneVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Telefone", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                if (this.txtTelefone.Visible == true)
                {
                    this.txtTelefone.Focus();
                }
                else
                {
                    this.txtTelefoneInter.Focus();
                }
            }
            catch (BUSINESS.Exceptions.Fornecedor.FornecedorSemIdExecption)
            {
                MessageBox.Show("É Necessário o campo Codigo Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Fornecedor.CNPJFornecedorExistente)
            {
                MessageBox.Show("Código de CNPJ já existente. Favor Informar ou código.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCnpj.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.IdentInterExistenteException)
            {
                MessageBox.Show("Código de Identificação Internacional já existente. Favor Informar ou código.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtIdentInter.Focus();
            }
            catch (BUSINESS.Exceptions.Validacoes.EmailInvalidoException)
            {
                MessageBox.Show("Campo E-mail incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtIdentInter.Focus();
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
                regraFornecedorDepto = null;
            }
        }
        #endregion Insere

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados que não podem ser nulos na tela
        /// </summary>
        private void ValidaDadosNulos()
        {
            try
            {
                string cnpj = this.txtCnpj.Text.Replace("-", string.Empty);
                cnpj = cnpj.Replace(".", string.Empty);
                cnpj = cnpj.Replace("/", string.Empty);
                cnpj = cnpj.Replace(" ", string.Empty);

                string cep = this.txtCep.Text.Replace("-", string.Empty);
                cep = cep.Replace(" ", string.Empty);

                if (string.IsNullOrEmpty(this.txtNomeFornecedor.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Fornecedor.NomeFornecedorVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtPais.Text) == true && this.txtPais.Enabled == true)
                {
                    throw new BUSINESS.Exceptions.Fornecedor.paisVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtEstado.Text) == true && this.txtEstado.Enabled == true)
                {
                    throw new BUSINESS.Exceptions.Fornecedor.EstadoVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtCidade.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Fornecedor.CidadeVazioException();
                }
                else if (string.IsNullOrEmpty(cep) == true && this.txtCep.Visible == true)
                {
                    throw new BUSINESS.Exceptions.Fornecedor.CEPVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtCodPostal.Text) == true && this.txtCodPostal.Visible == true)
                {
                    throw new BUSINESS.Exceptions.Fornecedor.CodigoPostalVazioException();
                }
                else if (string.IsNullOrEmpty(cnpj) == true && this.txtCnpj.Visible == true)
                {
                    throw new BUSINESS.Exceptions.Fornecedor.CnpjVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtIdentInter.Text) && this.txtIdentInter.Visible == true)
                {
                    throw new BUSINESS.Exceptions.Fornecedor.IdentidadeInterVazioException();
                }
                else
                {
                    string telefone = this.txtTelefone.Text.Replace("-", string.Empty);
                    telefone = telefone.Replace(" ", string.Empty);
                    if (string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(this.txtDDI.Text) == true && string.IsNullOrEmpty(this.txtDDD.Text) == true && string.IsNullOrEmpty(telefone) == true)
                    {
                        throw new BUSINESS.Exceptions.Fornecedor.DadosComunicacaoVazioExeception();
                    }
                    else if (string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(this.txtDDI.Text) == true && this.txtDDI.Enabled == true)
                    {
                        throw new BUSINESS.Exceptions.Fornecedor.DDIVazioException();
                    }
                    else if (string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(this.txtDDD.Text) == true)
                    {
                        throw new BUSINESS.Exceptions.Fornecedor.DddVazioException();
                    }
                    else if (string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(telefone) == true && this.txtTelefone.Visible == true || string.IsNullOrEmpty(this.txtEmail.Text) == true && string.IsNullOrEmpty(this.txtTelefoneInter.Text) == true && this.txtTelefoneInter.Visible == true)
                    {
                        throw new BUSINESS.Exceptions.Fornecedor.TelefoneVazioException();
                    }
                    else if (string.IsNullOrEmpty(txtEmail.Text) == true && string.IsNullOrEmpty(txtDDD.Text) == true && string.IsNullOrEmpty(telefone) == true)
                    {
                        throw new BUSINESS.Exceptions.Fornecedor.EmailFornecedorVazioException();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Valida Dados Nulos 

        #region Abre Tela Releacionar Departamento
        /// <summary>
        /// Abre a tela de relacionar Fornecedor com departamento
        /// </summary>
        private void AbreTelaReleacionarDepartamento()
        {
            mFornecedor model = null;
            CADASTRO.frmCadfornecedorDepto telaFornecedorDepto = null;
            try
            {
                _listaModelFornecedorDepto = new List<mFornecedorDepto>();
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                telaFornecedorDepto = new TCC.UI.CADASTRO.frmCadfornecedorDepto(model, this._listaModelFornecedorDepto);
                DialogResult resultado = telaFornecedorDepto.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._listaModelFornecedorDepto = null;
                }
            }
            catch (BUSINESS.Exceptions.Fornecedor.NomeFornecedorVazioException)
            {
                MessageBox.Show("É Necessário preenchimento do campo Nome Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNomeFornecedor.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.paisVazioException)
            {
                MessageBox.Show("É Necessário Prencher o campo País", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtPais.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.EstadoVazioException)
            {
                MessageBox.Show("É Necessário Prencher o campo Província(Estado)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtEstado.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.CidadeVazioException)
            {
                MessageBox.Show("É Necessário preenchimento do campo Cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCidade.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.CEPVazioException)
            {
                MessageBox.Show("É Necessário preenchimento do campo CEP", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCep.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.CodigoPostalVazioException)
            {
                MessageBox.Show("É Necessário preenchimento do campo Código Postal", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodPostal.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.CnpjVazioException)
            {
                MessageBox.Show("É Necessário preenchimento do campo CNPJ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCnpj.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.IdentidadeInterVazioException)
            {
                MessageBox.Show("É Necessário preenchimento do código de identificação internacional", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtIdentInter.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.DadosComunicacaoVazioExeception)
            {
                MessageBox.Show("É Necessário preenchimento dos campos 'DDI, DDD e Telefone' ou 'E-mail'", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Fornecedor.DDIVazioException)
            {
                MessageBox.Show("É Necessário preenchimento do campo DDI", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDDI.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.DddVazioException)
            {
                MessageBox.Show("É Necessário preenchimento do campo DDD", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDDD.Focus();
            }
            catch (BUSINESS.Exceptions.Fornecedor.TelefoneVazioException)
            {
                MessageBox.Show("É Necessário preenchimento do campo Telefone", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                if (this.txtTelefone.Visible == true)
                {
                    this.txtTelefone.Focus();
                }
                else
                { 
                    this.txtTelefoneInter.Focus();
                }
            }
            catch (BUSINESS.Exceptions.Fornecedor.FornecedorSemIdExecption)
            {
                MessageBox.Show("É Necessário o campo Codigo Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Validacoes.MaskedInvalidaException ex)
            {
                MessageBox.Show(ex.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                model = null;
                telaFornecedorDepto = null;
            }
        }
        #endregion Abre Tela Releacionar Departamento

        #region Popula Lista Fornecedor Depto Id Forn
        /// <summary>
        /// Popula a lista de model de Fornecedor Departamento com o id do fornecedor que foi cadastrado
        /// </summary>
        /// <param name="idForn">id do fornecedor cadastrado</param>
        private void PopulaListaFornecedorDeptoIdForn(int idForn)
        {
            try
            {
                foreach (mFornecedorDepto modelFornecedorDepto in this._listaModelFornecedorDepto)
                {
                    modelFornecedorDepto.IdFornecedor = idForn;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Popula Lista Fornecedor Depto Id Forn

        #endregion Metodos

        #region Eventos

        #region Form Load
        private void frmCadFornecedor_Load(object sender, EventArgs e)
        {
            this.BuscaEstado();

            //Desabilita/Torna invisíveis campos estrangeiros ao iniciar a tela(padrão Brasil)
            //-------------------------------------------------------------------------------
            this.txtPais.Enabled = false;
            this.txtEstado.Enabled = false;

            this.lblCodPostal.Visible = false;
            this.txtCodPostal.Visible = false;

            this.lblIdentInter.Visible = false;
            this.txtIdentInter.Visible = false;

            this.txtDDI.Text = "55";
            this.txtDDI.Enabled = false;

            this.txtTelefoneInter.Visible = false;
        }
        #endregion Form Load

        #region btnInsere Click
        private void btnInsere_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnInsere Click

        #region btnlimpar Click
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.rdbBrasil.Checked = true;
            this._listaModelFornecedorDepto = null;
            this._modelFornecedor = null;
        }
        #endregion btnlimpar Click

        #region btnVolta Click
        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVolta Click 

        #region txtNomeFornecedor TextChanged
        private void txtNomeFornecedor_TextChanged(object sender, EventArgs e)
        {
            this.btnInsere.Enabled = true;
        }
        #endregion txtNomeFornecedor TextChanged

        #region btnRelacionarDepto Click
        private void btnRelacionarDepto_Click(object sender, EventArgs e)
        {
            this.AbreTelaReleacionarDepartamento();
        }
        #endregion btnRelacionarDepto Click

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

            this.lblCodPostal.Visible = false;
            this.txtCodPostal.Visible = false;
            this.txtCodPostal.Text = "";
            this.lblCep.Visible = true;
            this.txtCep.Visible = true;

            this.lblIdentInter.Visible = false;
            this.txtIdentInter.Visible = false;
            this.txtIdentInter.Text = "";
            this.lblcnpj.Visible = true;
            this.txtCnpj.Visible = true;

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
            //---------------------------------------------------------------------------------------
            this.cboEstado.Enabled = false;
            this.cboEstado.SelectedIndex = 0;

            this.txtPais.Enabled = true;
            this.txtEstado.Enabled = true;

            this.lblCodPostal.Visible = true;
            this.txtCodPostal.Visible = true;
            this.lblCep.Visible = false;
            this.txtCep.Visible = false;
            this.txtCep.Text = "";

            this.lblcnpj.Visible = false;
            this.txtCnpj.Visible = false;
            this.txtCnpj.Text = "";
            this.lblIdentInter.Visible = true;
            this.txtIdentInter.Visible = true;

            this.txtDDI.Text = "";
            this.txtDDI.Enabled = true;

            this.txtTelefone.Visible = false;
            this.txtTelefone.Text = "";
            this.txtTelefoneInter.Visible = true;
        }
        #endregion rdbOutros CheckedChanged

        #endregion Eventos
    }
}
