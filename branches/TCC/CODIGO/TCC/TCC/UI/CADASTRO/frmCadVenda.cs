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
    public partial class frmCadVenda : FormPai
    {
        mCliente _modelCliente;
        mMotor _modelMotor;
        mOrdemProducao _modelOrdemProd;
        mTipoProduto _modelTipoProd;
        mKitGrupoPeca _modelKit;

        public frmCadVenda()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
            this._modelCliente = null;
            this._modelKit = null;
            this._modelMotor = null;
            this._modelOrdemProd = null;
            this._modelTipoProd = null;
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void frmCadVenda_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private mVenda PegaDadosTela()
        {
            mVenda model = new mVenda();
            rVenda regra = new rVenda();

            try
            {
                if (string.IsNullOrEmpty(this.txtDataVenda.Text) == true || this.txtDataVenda.Modified == false)
                {
                    model.DatVenda = null;
                }
                else
                {
                    model.DatVenda = Convert.ToDateTime(this.txtDataVenda.Text);
                }
                model.DatSaida = DateTime.Now;
                model.IdCli = this._modelCliente.IdCliente;
                model.IdGrupo = this._modelKit.Id_grupo;
                model.IdMotor = this._modelMotor.IdMotor;
                model.IdOrdem = this._modelOrdemProd.Id_ordem;
                model.IdTipoProduto = this._modelTipoProd.IdTipoProd;
                model.IdVenda = Convert.ToInt32(regra.BuscaidMaximo());
                model.NotaFisc = this.txtNotaFiscal.Text;
                if (string.IsNullOrEmpty(this.txtQtdVenda.Text) == true)
                {
                    model.Qtd = null;
                }
                else
                {
                    model.Qtd = Convert.ToInt32(this.txtQtdVenda.Text);
                }
                if (string.IsNullOrEmpty(this.txtValorVenda.Text) == true)
                {
                    model.Valor = null;
                }
                else
                {
                    model.Valor = Convert.ToDouble(this.txtValorVenda.Text);
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

        private void Insere()
        {
            mVenda model = new mVenda();
            rVenda regra = new rVenda();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.btnLimpa_Click(null, null);
                this.BuscaIdMaximo();
            }
            catch (BUSINESS.Exceptions.CodigoClienteVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoKitGrupoPecaVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Kit Grupo Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Venda.VendaMotorGrupoVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Motor ou do Grupo de Peças", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoTipoProdutoVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código do Tipo Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Venda.QuantidadeVendaZeroOuNuloException)
            {
                MessageBox.Show("O campo Quantidade Venda não pode se Zero ou Vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdVenda.Focus();
            }
            catch (BUSINESS.Exceptions.Venda.ValorVendaZeroOuNuloException)
            {
                MessageBox.Show("O campo Valor não pode se Zero ou Vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtValorVenda.Focus();
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
            if (this._modelCliente == null)
            {
                throw new BUSINESS.Exceptions.CodigoClienteVazioException();
            }
            else if (this._modelOrdemProd == null)
            {
                throw new BUSINESS.Exceptions.CodigoOrdemProducaoVazioException();
            }
            else if (this._modelTipoProd == null)
            {
                throw new BUSINESS.Exceptions.CodigoTipoProdutoVazioExeception();
            }
            else if (this._modelKit == null && this._modelMotor == null)
            {
                throw new BUSINESS.Exceptions.Venda.VendaMotorGrupoVazioException();
            }
        }

        private void btnCdCliente_Click(object sender, EventArgs e)
        {
            this._modelCliente = new mCliente();
            frmBuscaCliente objFrmCliente = new frmBuscaCliente(this._modelCliente);
            try
            {
                DialogResult resultado = objFrmCliente.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelCliente = null;
                }
                else
                {
                    this.txtCdCliente.Text = this._modelCliente.NomeCliente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmCliente = null;
            }
        }

        private void btnCdMotor_Click(object sender, EventArgs e)
        {
            this._modelMotor = new mMotor();
            frmBuscaMotor objFrmBuscaMotor = new frmBuscaMotor(this._modelMotor);
            try
            {
                DialogResult resultado = objFrmBuscaMotor.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelMotor = null;
                }
                else
                {
                    this.txtCdMotor.Text = this._modelMotor.DscMotor;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmBuscaMotor = null;
            }
        }

        private void btnCdOrdemMotor_Click(object sender, EventArgs e)
        {
            this._modelOrdemProd = new mOrdemProducao();
            frmBuscaOrdemMotor objFrmOrdemMotor = new frmBuscaOrdemMotor(this._modelOrdemProd);
            try
            {
                DialogResult resultado = objFrmOrdemMotor.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelOrdemProd = null;
                }
                else
                {
                    this.txtCdOrdemMotor.Text = this._modelOrdemProd.Dsc_ordem;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFrmOrdemMotor = null;
            }
        }

        private void btnCdKit_Click(object sender, EventArgs e)
        {
            this._modelKit = new mKitGrupoPeca();
            frmBuscaKit frmForm = new frmBuscaKit(this._modelKit);
            try
            {
                DialogResult resultado = frmForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelKit = null;
                }
                else
                {
                    this.txtCdKit.Text = this._modelKit.Nom_grupo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                frmForm = null;
            }
        }

        private void CdTipoProduto_Click(object sender, EventArgs e)
        {
            this._modelTipoProd = new mTipoProduto();
            frmBuscaTipoProduto objForm = new frmBuscaTipoProduto(this._modelTipoProd);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelTipoProd = null;
                }
                else
                {
                    this.txtCdTipoProduto.Text = this._modelTipoProd.Nom;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objForm = null;
            }
        }


    }
}