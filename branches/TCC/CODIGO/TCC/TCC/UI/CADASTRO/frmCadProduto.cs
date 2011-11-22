using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.Regra;
using TCC.Mapper;

namespace TCC.UI
{
    public partial class frmCadProduto : FormPai
    {
        #region Atributos
        mKitGrupoPeca _modelKit;
        mFamiliaMotor _modelFamMotor;
        #endregion Atributos

        #region Construtor
        public frmCadProduto()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelFamMotor = null;
            this._modelKit = null;
            this.rdbFamMotor.Checked = true;
        }
        #endregion btnLimpar Click

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region frmCadOrdemProducao Load
        private void frmCadOrdemProducao_Load(object sender, EventArgs e)
        {
        }
        #endregion frmCadOrdemProducao Load

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnAceitar Click

        #region btnBuscarProduto Click
        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            if (rdbFamMotor.Checked == true)
            {
                this._modelFamMotor = new mFamiliaMotor();
                frmBuscaFamiliaMotor objTela = new frmBuscaFamiliaMotor(_modelFamMotor);
                try
                {
                    DialogResult resultado = objTela.ShowDialog();
                    if (resultado == DialogResult.Cancel)
                    {
                        this._modelFamMotor = null;
                        this.txtFiltroBusca.Text = string.Empty;
                    }
                    else
                    {
                        this.txtFiltroBusca.Text = this._modelFamMotor.Id_fam_motor_real + " - " + this._modelFamMotor.DscFamiliaMotor;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    objTela = null;
                }
            }
            else
            {
                this._modelKit = new mKitGrupoPeca();
                frmBuscaKit objTela = new frmBuscaKit(_modelKit);
                try
                {
                    DialogResult resultado = objTela.ShowDialog();
                    if (resultado == DialogResult.Cancel)
                    {
                        this._modelKit = null;
                    }
                    else
                    {
                        this.txtFiltroBusca.Text = this._modelKit.IdKitReal + " - " + this._modelKit.Nom_grupo;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    objTela = null;
                }
            }
        }
        #endregion btnBuscarProduto Click

        #region txtFiltroBusca TextChanged
        private void txtFiltroBusca_TextChanged(object sender, EventArgs e)
        {
            this.btnAceitar.Enabled = true;
        }
        #endregion txtFiltroBusca TextChanged

        #region rdbKit CheckedChanged
        private void rdbKit_CheckedChanged(object sender, EventArgs e)
        {
            this.txtFiltroBusca.Text = "";
        }
        #endregion rdbKit CheckedChanged

        #region rdbFamMotor CheckedChanged
        private void rdbFamMotor_CheckedChanged(object sender, EventArgs e)
        {
            this.txtFiltroBusca.Text = "";
        }
        #endregion rdbFamMotor CheckedChanged

        #endregion Eventos

        #region Metodos

        #region Insere
        private void Insere()
        {
            mProduto model;
            rProduto regra = new rProduto();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.btnLimpar_Click(null, null);
                this.btnAceitar.Enabled = false;
                MessageBox.Show("Registro salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (TCC.Regra.Exceptions.Produto.FamiliaOuKitVazioException)
            {
                MessageBox.Show("É Necessário Buscar uma Familia de Motores ou um Kit de Peças!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarProduto.Focus();
            }
            catch (TCC.Regra.Exceptions.Produto.DescricaoProdutoVazioException)
            {
                MessageBox.Show("Informe uma Descrição para o Produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDescProduto.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                model = null;
                regra = null;
            }
        }
        #endregion Insere

        #region ValidaDadosNulos
        private void ValidaDadosNulos()
        {
            if (this._modelFamMotor == null && this._modelKit == null)
            {
                throw new TCC.Regra.Exceptions.Produto.FamiliaOuKitVazioException();
            }
            else if (string.IsNullOrEmpty(this.txtDescProduto.Text) == true)
            {
                throw new TCC.Regra.Exceptions.Produto.DescricaoProdutoVazioException();
            }
        }
        #endregion ValidaDadosNulos

        #region PegaDadosTela
        private mProduto PegaDadosTela()
        {
            mProduto model = new mProduto();
            rProduto regra = new rProduto();

            try
            {
                model.IdProduto = regra.BuscaIdMaximo();
                model.DescProduto = this.txtDescProduto.Text;

                if (this.rdbFamMotor.Checked == true)
                {
                    model.IdFamMotor = this._modelFamMotor.IdFamiliaMotor;
                    model.IdKit = null;
                    model.IdTipoProduto = 1;
                }
                else
                {
                    model.IdKit = this._modelKit.IdKit;
                    model.IdFamMotor = null;
                    model.IdTipoProduto = 2;
                }
                model.FlgAtivo = true;
                model.DatAlt = DateTime.Now;

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
        #endregion PegaDadosTela

        #endregion Metodos
    }
}
