using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmCadColaborador : FormPai
    {
        #region Atributos
        mUsuario _modelUsuario;
        mDepartamento _modelDepartamento;
        mColaborador _modelColaborador;
        #endregion Atributos

        #region Construtor
        public frmCadColaborador()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos
        
        #region Form Load
        private void frmCadColaborador_Load(object sender, EventArgs e)
        {
            this.PopulaComboEstados();
            CbSexo.SelectedIndex = 0;
        }
        #endregion Form Load

        #region btnConfirma Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnConfirma Click

        #region btnApaga Click
        private void btnApaga_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelDepartamento = null;
            this._modelUsuario = null;
            this._modelColaborador = null;
            base.Alteracao = false;
        }
        #endregion btnApaga Click

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region btnBuscaDepartamento Click
        private void btnBuscaDepartamento_Click(object sender, EventArgs e)
        {
            _modelDepartamento = new mDepartamento();
            frmBuscaDepartamento buscarDepartamento = new frmBuscaDepartamento(_modelDepartamento);
            try
            {
                DialogResult resultado = buscarDepartamento.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelDepartamento = null;
                }
                else
                {
                    this.txtCdDepartamento.Text = this._modelDepartamento.DscDepto;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                buscarDepartamento = null;
            }
        }
        #endregion btnBuscaDepartamento Click

        #region btnBuscaAlteracaoDelecao Click
        private void btnBuscaAlteracaoDelecao_Click(object sender, EventArgs e)
        {
            this.btnApaga_Click(null, null);
            this._modelColaborador = new mColaborador();
            frmBuscaColaborador objColaborador = new frmBuscaColaborador(this._modelColaborador, true);
            try
            {
                DialogResult resultado = objColaborador.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelColaborador = null;
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
                objColaborador = null;
            }
        }
        #endregion btnBuscaAlteracaoDelecao Click

        #region txtNome TextChanged
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.btnConfirma.Enabled = true;
        }
        #endregion  txtNome TextChanged

        #endregion Eventos

        #region Metodos

        #region Popula Combo Estados
        /// <summary>
        /// Popula o combo com os estados no banco
        /// </summary>
        private void PopulaComboEstados()
        {
            BUSINESS.rEstado estados = new rEstado();
            cbEstado.ValueMember = "slg_est";
            cbEstado.DisplayMember = "slg_est";
            cbEstado.DataSource = estados.BuscaEstado();
        }
        #endregion Popula Combo Estados

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados da tela e popula o model
        /// </summary>
        /// <returns>Model populado</returns>
        private mColaborador PegaDadosTela()
        {
            mColaborador model = new mColaborador();
            rColaborador regra = new rColaborador();

            try
            {
                model.IdColab = regra.BuscaIdMaximo();
                model.BairrEnd = txtBairro.Text;
                if (this.txtCep.Modified == false)
                {
                    string cep = txtCep.Text.Replace("-", string.Empty).Replace(" ", string.Empty);
                    model.Cep = Convert.ToInt32(cep);
                }
                else
                {
                    model.Cep = null;
                }
                model.Cidade = txtCidade.Text;
                model.ComplEnd = txtComplemento.Text;
                string cpf = this.txtCpf.Text.Replace(".", string.Empty);
                cpf = cpf.Replace("-", string.Empty);
                    model.Cpf = txtCpf.Text;
                    BUSINESS.UTIL.Validacoes.ValidaData(this.txtDataNasc.Text);
                    model.DatNasc = Convert.ToDateTime(this.txtDataNasc.Text);
                model.Estado = this.cbEstado.SelectedValue.ToString();
                model.IdDepto = Convert.ToInt32(this._modelDepartamento.IdDepto);
                if (this._modelUsuario != null)
                {
                    model.IdUsuario = Convert.ToInt32(this._modelUsuario.IdUsuario);
                }
                else
                {
                    model.IdUsuario = null;
                }
                model.NomeColab = txtNome.Text;
                model.NomeRua = txtRua.Text;
                if (string.IsNullOrEmpty(txtNumero.Text) == true)
                {
                    model.NroEnd = null;
                }
                else
                {
                    model.NroEnd = Convert.ToInt32(txtNumero.Text);
                }
                model.Sexo = CbSexo.Text;
                model.Rg = txtRg.Text;
                model.DatAtl = DateTime.Now;
                if (string.IsNullOrEmpty(this.txtDDD.Text) == true)
                {
                    model.Ddd = null;
                }
                else
                {
                    model.Ddd = Convert.ToInt32(this.txtDDD.Text);
                }

                string tel = this.txtTelefone.Text;
                tel = tel.Replace(" ", string.Empty).Replace("-", string.Empty);
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
                if (base.Alteracao == true)
                {
                    model.IdColab = this._modelColaborador.IdColab;
                }
                model.FlgAtivo = true;
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Pega Dados Tela

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados que estão na tela
        /// </summary>
        public void ValidaDadosNulos()
        {
            try
            {
                string cpf = this.txtCpf.Text.Replace(".", string.Empty);
                cpf = cpf.Replace("-", string.Empty);
                cpf = cpf.Replace(" ", string.Empty);
                string cep = this.txtCep.Text.Replace("-", string.Empty);
                cep = cep.Replace(" ", string.Empty);
                string telefone = this.txtTelefone.Text.Replace("-", string.Empty);
                telefone = telefone.Replace(" ", string.Empty);
                string data = this.txtDataNasc.Text.Replace("/", string.Empty);
                data = data.Replace(" ", string.Empty);
                if (this._modelDepartamento == null)
                {
                    throw new BUSINESS.Exceptions.CodigoDepartamentoVazioException();
                }
                else if (string.IsNullOrEmpty(data) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.DataNascimentoVazioException();
                }
                else if (string.IsNullOrEmpty(cep) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.CepVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtNome.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.NomeVazioExeption();
                }
                else if (string.IsNullOrEmpty(this.txtDDD.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.DDDVazioExeption();
                }
                else if (string.IsNullOrEmpty(telefone) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.TelefoneVazioExeption();
                }
                else if (string.IsNullOrEmpty(this.txtRua.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.RuaVazioExeption();
                }
                else if (string.IsNullOrEmpty(this.txtNumero.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.NumeroVazioExeption();
                }
                else if (string.IsNullOrEmpty(this.txtBairro.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.BairroVazioExeption();
                }
                else if (string.IsNullOrEmpty(this.txtCidade.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.CidadeVazioExeption();
                }
                else if (string.IsNullOrEmpty(this.txtRg.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.RgVazioExeption();
                }
                else if (string.IsNullOrEmpty(cpf) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.CpfVazioExeption();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Valida Dados Nulos

        #region Popula Tela Com Model Alteracao
        /// <summary>
        /// Popula a tela com o model buscado em alteração
        /// </summary>
        private void PopulaTelaComModelAlteracao()
        {
            if (this._modelColaborador != null)
            {
                this._modelUsuario = new mUsuario();
                this._modelUsuario.IdUsuario = this._modelColaborador.IdUsuario;
                this._modelDepartamento = new mDepartamento();
                this._modelDepartamento.IdDepto = this._modelColaborador.IdDepto;

                base.Alteracao = true;
                //this.txtCdUsuario.Text = this._modelColaborador.IdUsuario.ToString();
                this.txtCdDepartamento.Text = this._modelColaborador.IdDepto.ToString();
                this.txtNome.Text = this._modelColaborador.NomeColab;
                this.txtDataNasc.Text = this._modelColaborador.DatNasc.ToString("dd/MM/yyyy");
                this.CbSexo.SelectedIndex = this.CbSexo.FindString(this._modelColaborador.Sexo);
                this.txtDDD.Text = this._modelColaborador.Ddd.ToString();
                this.txtTelefone.Text = this._modelColaborador.Telefone.ToString();
                this.txtRua.Text = this._modelColaborador.NomeRua;
                this.txtNumero.Text = this._modelColaborador.NroEnd.ToString();
                this.txtComplemento.Text = this._modelColaborador.ComplEnd;
                this.txtBairro.Text = this._modelColaborador.BairrEnd;
                this.txtCep.Text = this._modelColaborador.Cep.ToString();
                this.txtCidade.Text = this._modelColaborador.Cidade;
                this.cbEstado.SelectedIndex = this.cbEstado.FindString(this._modelColaborador.Estado);
                this.txtRg.Text = this._modelColaborador.Rg;
                this.txtCpf.Text = this._modelColaborador.Cpf;
                this.txtEmail.Text = this._modelColaborador.Email;
            }
        }
        #endregion Popula Tela Com Model Alteracao

        #region Insere
        /// <summary>
        /// Insere os dados do model no banco
        /// </summary>
        private void Insere()
        {
            mColaborador modelColaborador = new mColaborador();
            rColaborador regraColaborador = new rColaborador();
            rUsuario regraUsuario = null;
            try
            {
                this.ValidaDadosNulos();
                if (base.Alteracao == false)
                {
                    //Verifica se existe usuario para associar
                    //----------------------------------------
                    if (this._modelUsuario != null)
                    {
                        regraUsuario = new rUsuario();
                        regraUsuario.ValidarInsere(this._modelUsuario);
                    }
                    modelColaborador = this.PegaDadosTela();
                    if (modelColaborador != null)
                    {
                        regraColaborador.ValidarInsere(modelColaborador);
                    }
                    DialogResult resultado = MessageBox.Show("Deseja associar este funcionário com um usuário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (resultado == DialogResult.Yes)
                    {
                        this.AbreTelaAssociaUsuario();
                    }
                    this.btnApaga_Click(null, null);
                }
                else
                {
                    modelColaborador = this.PegaDadosTela();
                    regraColaborador.ValidarAltera(modelColaborador);
                }
                this.btnApaga_Click(null, null);
                this.btnConfirma.Enabled = false;
                MessageBox.Show("Registro salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoDepartamentoVazioException)
            {
                MessageBox.Show("Buscar Codigo Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCdDepartamento.Focus();
            }
            catch (BUSINESS.Exceptions.Validacoes.DataInvalidaException ex)
            {
                MessageBox.Show("Erro no " + ex.TipoErro.ToString() + " da Data: " + ex.DataErrada, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDataNasc.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.CepVazioException)
            {
                MessageBox.Show("Preencher campo Cep", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCep.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.DataNascimentoVazioException)
            {
                MessageBox.Show("Preencher campo Data Nascimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDataNasc.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.NomeVazioExeption)
            {
                MessageBox.Show("Preencher campo Nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNome.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.DDDVazioExeption)
            {
                MessageBox.Show("Preencher campo DDD", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDDD.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.TelefoneVazioExeption)
            {
                MessageBox.Show("Preencher campo Telefone", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtTelefone.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.RuaVazioExeption)
            {
                MessageBox.Show("Preencher campo Rua", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtRua.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.NumeroVazioExeption)
            {
                MessageBox.Show("Preencher campo Numero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNumero.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.BairroVazioExeption)
            {
                MessageBox.Show("Preencher campo Bairro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtBairro.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.CidadeVazioExeption)
            {
                MessageBox.Show("Preencher campo Cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCidade.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.RgVazioExeption)
            {
                MessageBox.Show("Preencher campo RG", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtRg.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.CpfVazioExeption)
            {
                MessageBox.Show("Preencher campo CPF", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCpf.Focus();
            }
            catch (BUSINESS.Exceptions.Validacoes.MaskedInvalidaException ex)
            {
                MessageBox.Show(ex.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Colaborador.CpfExistenteException)
            {
                MessageBox.Show("CPF já Cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCpf.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                modelColaborador = null;
                regraColaborador = null;
                regraUsuario = null;
            }
        }
        #endregion Insere
        
        #region AbreTelaAssociaUsuario
        private void AbreTelaAssociaUsuario()
        {
            this._modelUsuario = new mUsuario();
            frmCadUsuario telaUsuario = new frmCadUsuario(this._modelUsuario);
            try
            {
                DialogResult resultado = telaUsuario.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelUsuario = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
        #endregion AbreTelaAssociaUsuario

        #endregion Metodos
    }
}
