using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmCadEstoque : FormPai
    {
        #region Atributos
        mDepartamento _modelDepartamento;
        #endregion Atributos

        #region Construtor
        public frmCadEstoque()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region Form Load
        private void frmCadEstoque_Load(object sender, EventArgs e)
        {
        }
        #endregion Form Load

        #region btnInsere Click
        private void btnInsere_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnInsere Click

        #region btnBuscaDepartamento Click
        private void btnBuscaDepartamento_Click(object sender, EventArgs e)
        {
            this._modelDepartamento = new mDepartamento();
            frmBuscaDepartamento objFormBuscaDep = new frmBuscaDepartamento(this._modelDepartamento);
            try
            {
                DialogResult resultado = objFormBuscaDep.ShowDialog();
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
                objFormBuscaDep = null;
            }
        }
        #endregion btnBuscaDepartamento Click

        #region btnVolta Click
        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVolta Click

        #region btnLimpa Click
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelDepartamento = null;
        }
        #endregion btnLimpa Click

        #region txtNome TextChanged
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.btnInsere.Enabled = true;
        }
        #endregion txtNome TextChanged

        #endregion Eventos

        #region Metodos

        #region Insere
        /// <summary>
        /// Insere os dados do model
        /// </summary>
        private void Insere()
        {
            rEstoque regra = new rEstoque();
            mEstoque model;
            try
            {
                this.ValidaCamposNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.btnLimpa_Click(null, null);
            }
            catch (BUSINESS.Exceptions.Estoque.NomEstoqueExistenteException)
            {
                MessageBox.Show("Nome do Estoque já Cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaDepartamento.Focus();
            }
            catch (BUSINESS.Exceptions.CodigoDepartamentoVazioException)
            {
                MessageBox.Show("É necessário informar o Departamento do estoque", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaDepartamento.Focus();
            }
            catch (BUSINESS.Exceptions.Estoque.NomEstoqueVazioException)
            {
                MessageBox.Show("É Necessário cadastrar o nome do Estoque", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                regra = null;
                model = null;
            }
        }
        #endregion Insere

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados da tela e popula o model
        /// </summary>
        /// <returns>Model populado</returns>
        private mEstoque PegaDadosTela()
        {
            mEstoque model = new mEstoque();
            rEstoque regra = new rEstoque();

            try
            {
                model.Id_estoque = regra.BuscaIdMaximo();
                model.Id_depto = Convert.ToInt32(this._modelDepartamento.IdDepto);
                model.Dsc_estoque = this.txtNome.Text;
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
                model.Flg_negativo = rdbDefeitoSim.Checked;

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

        #region Valida Campos Nulos
        /// <summary>
        /// Valida os campos vazios na tela
        /// </summary>
        private void ValidaCamposNulos()
        {
            if (this._modelDepartamento == null)
            {
                throw new BUSINESS.Exceptions.CodigoDepartamentoVazioException();
            }
            else if (string.IsNullOrEmpty(this.txtNome.Text) == true)
            {
                throw new BUSINESS.Exceptions.Estoque.NomEstoqueVazioException();
            }
        }
        #endregion Valida Campos Nulos

        #endregion Metodos
    }
}
