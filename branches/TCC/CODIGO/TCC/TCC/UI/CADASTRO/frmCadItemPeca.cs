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
    public partial class frmCadItemPeca : FormPai
    {
        mPeca _modelPeca;

        public frmCadItemPeca()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void Insere()
        {
            mItemPeca model;
            rItemPeca regra = new rItemPeca();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.btnLimpa_Click(null, null);
            }
            catch (BUSINESS.Exceptions.CodigoPecaVazioExeception)
            {
                MessageBox.Show("É Necessário Buscar o código da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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

        private mItemPeca PegaDadosTela()
        {
            mItemPeca model = new mItemPeca();
            rItemPeca regra = new rItemPeca();

            try
            {
                model.Flg_ativo = true;
                model.Id_item_peca = Convert.ToInt32(regra.BuscaIdMaximo());
                model.Id_peca = this._modelPeca.IdPeca;
                model.Nom_item_peca = this.txtDescItemPeca.Text;

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

        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelPeca = null;
        }

        /*protected override void BuscaIdMaximo()
        {
            rItemPeca regra = new rItemPeca();
            try
            {
                this.txtCodItemPeca.Text = regra.BuscaIdMaximo();
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

        private void btnBuscaPeca_Click(object sender, EventArgs e)
        {
            this._modelPeca = new mPeca();
            frmBuscaPeca frmTela = new frmBuscaPeca(this._modelPeca);
            try
            {
                DialogResult resultado = frmTela.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelPeca = null;
                }
                else
                {
                    this.txtCodigoPeca.Text = this._modelPeca.Nom;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                frmTela = null;
            }
        }

        private void ValidaDadosNulos()
        {
            if (this._modelPeca == null)
            {
                throw new BUSINESS.Exceptions.CodigoPecaVazioExeception();
            }
        }

        private void frmCadItemPeca_Load(object sender, EventArgs e)
        {
        }
    }
} 