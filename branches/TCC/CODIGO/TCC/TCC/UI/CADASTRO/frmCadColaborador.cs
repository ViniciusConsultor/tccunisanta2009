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
        mUsuario _modelUsuario;
        mDepartamento _modelDepartamento;

        public frmCadColaborador()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmCadColaborador_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
            this.PopulaComboEstados();
            CbSexo.SelectedIndex = 0;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            mColaborador modelColaborador = new mColaborador();
            BUSINESS.rCadColaborador regraMenu = new BUSINESS.rCadColaborador();
            try
            {
                this.ValidaDadosNulos();
                modelColaborador = this.PegaDadosTela();
                if (modelColaborador != null)
                {
                    regraMenu.ValidarInsere(modelColaborador);
                }
                base.LimpaDadosTela(this);
                this.BuscaIdMaximo();
            }
            catch (BUSINESS.Exceptions.Colaborador.CodigoUsuarioVazioExeception)
            {
                MessageBox.Show("Buscar Codigo Usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCdUsuario.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.CodigoDepartamentoVazioException)
            {
                MessageBox.Show("Buscar Codigo Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCdDepartamento.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.CepVazioException)
            {
                MessageBox.Show("Preencher campo Cep", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCEP.Focus();
            }
            catch (BUSINESS.Exceptions.Colaborador.DataNascimentoVazioException)
            {
                MessageBox.Show("Preencher campo Data Nascimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDataNasc.Focus();
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
            base.LimpaDadosTela(this);
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        private void btnBuscaUsuario_Click(object sender, EventArgs e)
        {
            _modelUsuario = new mUsuario();
            frmBuscaUsuario buscarUsuario = new frmBuscaUsuario(_modelUsuario);
            try
            {
                DialogResult resultado = buscarUsuario.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelUsuario = null;
                }
                else
                {
                    this.txtCdUsuario.Text = this._modelUsuario.Login;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                buscarUsuario = null;
            }
        }

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
        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCEP.TextLength == 5)
            {
                this.txtCep2.Focus();
            }
        }
        private void txtCep2_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCep2.TextLength == 3)
            {
                this.txtBairro.Focus();
            }
        }
        #endregion

        #region Metodos

        protected override void BuscaIdMaximo()
        {
            rCadColaborador regraColaborador = new rCadColaborador();
            try
            {
                this.txtCdColab.Text = regraColaborador.BuscaIDMaximoColaborador();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraColaborador = null;
            }
        }
        private void PopulaComboEstados()
        {
            BUSINESS.rEstado estados = new rEstado();
            cbEstado.ValueMember = "slg_est";
            cbEstado.DisplayMember = "Estado";
            cbEstado.DataSource = estados.BuscaEstado();
        }

        private mColaborador PegaDadosTela()
        {
            mColaborador model = null;
            try
            {
                model = new mColaborador();
                model.BairrEnd = txtBairro.Text;
                model.Cep = txtCEP.Text + txtCep2.Text;
                model.Cidade = txtCidade.Text;
                model.ComplEnd = txtComplemento.Text;
                if (string.IsNullOrEmpty(txtCpf.Text) == true)
                {
                    model.Cpf = null;
                }
                else
                {
                    model.Cpf = txtCpf.Text;
                }
                model.DatNasc = Convert.ToDateTime(this.txtDataNasc.Text);
                model.Estado = this.cbEstado.SelectedValue.ToString();
                model.IdColab = Convert.ToInt32(txtCdColab.Text);
                model.IdDepto = this._modelDepartamento.IdDepto;
                model.IdUsuario = this._modelUsuario.IdUsuario;
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
                model.Sexo = Convert.ToChar(CbSexo.Text);
                if (string.IsNullOrEmpty(this.txtRg.Text) == true)
                {
                    model.Rg = null;
                }
                else
                {
                    model.Rg = txtRg.Text;
                }
                model.DatAtl = DateTime.Now;
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
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ValidaDadosNulos()
        {
            try
            {
                if (this._modelUsuario == null)
                {
                    throw new BUSINESS.Exceptions.Colaborador.CodigoUsuarioVazioExeception();
                }
                else if (this._modelDepartamento == null)
                {
                    throw new BUSINESS.Exceptions.Colaborador.CodigoDepartamentoVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtDataNasc.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.DataNascimentoVazioException();
                }
                else if (string.IsNullOrEmpty(this.txtCEP.Text) == true)
                {
                    throw new BUSINESS.Exceptions.Colaborador.CepVazioException();
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

        #endregion
    }
}
