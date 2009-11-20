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
                MessageBox.Show("Registro salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Produto.DescricaoProdutoVazioException)
            {
                MessageBox.Show("Informe uma descrição para o produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtDescProduto.Focus();
            }
            catch (BUSINESS.Exceptions.Produto.FamiliaOuKitVazioException)
            {
                MessageBox.Show("É necessário buscar uma Familia de Motores ou um Kit de Peças!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarProduto.Focus();
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
            if (string.IsNullOrEmpty(this.txtDescProduto.Text) == true)
            {
                throw new BUSINESS.Exceptions.Produto.DescricaoProdutoVazioException();
            }
            else if (this._modelFamMotor == null && this._modelKit == null)
            {
                throw new BUSINESS.Exceptions.Produto.FamiliaOuKitVazioException();
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
                    model.IdTipoProduto = 1;
                }
                else
                {
                    model.IdKit = this._modelKit.IdKit;
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
