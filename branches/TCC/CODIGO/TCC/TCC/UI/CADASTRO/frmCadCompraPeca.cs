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
    public partial class frmCadCompraPeca : FormPai
    {
        mCompra _modelCompra;
        List<mPeca> _modelPeca;

        public frmCadCompraPeca()
        {
            InitializeComponent();
        }

        private void btnBuscaPeca_Click(object sender, EventArgs e)
        {
            this._modelPeca = new List<mPeca>();
            frmBuscaPeca objForm = new frmBuscaPeca(this._modelPeca, true);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelPeca = null;
                }
                else
                {
                    for (int contador = 0; contador < this._modelPeca.Count; contador++)
                    {
                        if (contador == 0)
                        {
                            this.txtCdPeca.Text = this._modelPeca[contador].Nom;
                        }
                        else
                        {
                            this.txtCdPeca.Text += this._modelPeca[contador].Nom;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void Insere()
        {
            mCompraPeca model;
            rCompraPeca regra = new rCompraPeca();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.btnLimpar_Click(null, null);
            }
            catch (BUSINESS.Exceptions.CodigoCompraVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código da Compra", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoPecaVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CompraPeca.UltimoPrecoVazioException)
            {
                MessageBox.Show("É Necessário preencher o campo Ultimo Preço", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                model = null;
                regra = null;
            }
        }

        private mCompraPeca PegaDadosTela()
        {
            mCompraPeca model = new mCompraPeca();
            try
            {
                model.IdCompra = this._modelCompra.IdCompra;
                model.IdPeca = Convert.ToInt32(this._modelPeca[0].IdPeca);
                model.UltimoPreco = Convert.ToDouble(this.txtUltimoPreco.Text);

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelCompra = null;
            this._modelPeca = null;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnBuscaCompra_Click(object sender, EventArgs e)
        {
            this._modelCompra = new mCompra();
            frmBuscaCompra objForm = new frmBuscaCompra(this._modelCompra);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelCompra = null;
                }
                else
                {
                    this.txtCdCompra.Text = this._modelCompra.IdCompra.ToString();
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


        private void ValidaDadosNulos()
        {
            if (this._modelCompra == null)
            {
                throw new BUSINESS.Exceptions.CodigoCompraVazioException();
            }
            else if (this._modelPeca == null)
            {
                throw new BUSINESS.Exceptions.CodigoPecaVazioExeception();
            }
            else if (string.IsNullOrEmpty(this.txtUltimoPreco.Text) == true)
            {
                throw new BUSINESS.Exceptions.CompraPeca.UltimoPrecoVazioException();
            }
        }
    }
}