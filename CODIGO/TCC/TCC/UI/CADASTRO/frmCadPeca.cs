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
    public partial class frmCadPeca : FormPai
    {
        mEstoque _modelEstoque;
        mTipoPeca _modelTipoPeca;
        public frmCadPeca()
        {
            InitializeComponent();
        }

        /*protected override void  BuscaIdMaximo()
        {
            rPeca regra = new rPeca();
            try
            {
                this.txtCdPeca.Text = regra.BuscaIdMaximoPeca();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
            }
        }*/

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnCdTipoPeca_Click(object sender, EventArgs e)
        {
            this._modelTipoPeca = new mTipoPeca();
            frmBuscaTipoPeca objTela = new frmBuscaTipoPeca(_modelTipoPeca);
            try
            {
                DialogResult resultado = objTela.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelTipoPeca = null;
                }
                else
                {
                    this.txtCdTipoPeca.Text = this._modelTipoPeca.DscTipoPeca;
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

        private void btnCdEstoque_Click(object sender, EventArgs e)
        {
            this._modelEstoque = new mEstoque();
            frmBuscaEstoque objTela = new frmBuscaEstoque(_modelEstoque);
            try
            {
                DialogResult resultado = objTela.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelEstoque = null;
                }
                else
                {
                    this.txtCdEstoque.Text = this._modelEstoque.Dsc_estoque;
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

        private void frmCadPeca_Load(object sender, EventArgs e)
        {
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelEstoque = null;
            this._modelTipoPeca = null;
        }

        private mPeca PegaDadosTela()
        {
            mPeca model = new mPeca();
            rPeca regra = new rPeca();

            try
            {
                model.DatAlt = DateTime.Now;
                model.DscPeca = this.txtDsPeca.Text;
                model.FlgAtivo = true;
                model.IdEstoque = this._modelEstoque.Id_estoque;
                model.IdPeca = Convert.ToInt32(regra.BuscaIdMaximoPeca());
                model.IdPecaReal = this.txtCodigoReal.Text;
                model.IdTipoPeca = this._modelTipoPeca.IdTipoPeca;
                model.Nom = this.txtNmPeca.Text;
                if (string.IsNullOrEmpty(this.txtPesoPeca.Text) == true)
                {
                    model.Peso = null;
                }
                else
                {
                    model.Peso = Convert.ToInt32(this.txtPesoPeca.Text);
                }
                if (string.IsNullOrEmpty(this.txtQtdPeca.Text) == true)
                {
                    model.QtdMin = null;
                }
                else
                {
                    model.QtdMin = Convert.ToInt32(this.txtQtdPeca.Text);
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

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void Insere()
        {
            mPeca model;
            rPeca regra = new rPeca();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
            }
            catch (BUSINESS.Exceptions.CodigoEstoqueVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Estoque", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoTipoPecaVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Tipo da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Peca.PecaJaExistenteException)
            {
                MessageBox.Show("Peça já existente favor cadastrar outro Código Real", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Peca.QtdMinimaNuloOuZeroException)
            {
                MessageBox.Show("Quantidade de Peça não Pode ser Vazia ou Zero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdPeca.Focus();
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

        private void ValidaDadosNulos()
        {
            if (this._modelEstoque == null)
            {
                throw new BUSINESS.Exceptions.CodigoEstoqueVazioException();
            }
            else if (this._modelTipoPeca == null)
            {
                throw new BUSINESS.Exceptions.CodigoTipoPecaVazioException();
            }
        }
    }
}
