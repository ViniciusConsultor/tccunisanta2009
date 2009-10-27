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
    public partial class frmCadPecaFornecedor : FormPai
    {
        mFornecedor _modelFornecedor;
        mPeca _modelPeca;

        public frmCadPecaFornecedor()
        {
            InitializeComponent();
        }

        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            _modelFornecedor = new mFornecedor();
            frmBuscaFornecedor objForm = new frmBuscaFornecedor(this._modelFornecedor);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelFornecedor = null;
                }
                else
                {
                    this.txtFornecedor.Text = this._modelFornecedor.NomeFornecedor;
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

        private void btnBuscaPeca_Click(object sender, EventArgs e)
        {
            this._modelPeca = new mPeca();
            frmBuscaPeca objForm = new frmBuscaPeca(this._modelPeca);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelPeca = null;
                }
                else
                {
                    this.txtPeca.Text = this._modelPeca.Nom;
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private mPecaFornecedor PegaDadosTela()
        {
            mPecaFornecedor model = new mPecaFornecedor();
            try
            {
                model.DatInc = DateTime.Now;
                model.FlgAtivo = true;
                model.Id_forn = this._modelFornecedor.IdFornecedor;
                model.Id_peca = this._modelPeca.IdPeca;

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
            mPecaFornecedor model;
            rPecaFornecedor regra = new rPecaFornecedor();
            try
            {
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.btnLimpar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                model = null;
                regra = null;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelPeca = null;
            this._modelFornecedor = null;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
    }
}
