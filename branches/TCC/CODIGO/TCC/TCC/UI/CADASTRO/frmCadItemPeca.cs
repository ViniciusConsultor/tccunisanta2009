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
        List<mPeca> _modelPeca;

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
            List<mItemPeca> ListaModel;
            rItemPeca regra = new rItemPeca();
            try
            {
                this.ValidaDadosNulos();
                ListaModel = this.PegaDadosTela();
                foreach (mItemPeca model in ListaModel)
                {
                    regra.ValidarInsere(model);
                }
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
                regra = null;
            }
        }

        private List<mItemPeca> PegaDadosTela()
        {
            List<mItemPeca> ListaModel = new List<mItemPeca>();
            mItemPeca model;
            rItemPeca regra = new rItemPeca();
            try
            {
                int idMaximo = regra.BuscaIdMaximo();
                for (int posicao = 0; posicao < this._modelPeca.Count; posicao++)
                {
                    model = new mItemPeca();
                    model.Flg_ativo = true;
                    model.Id_peca = this._modelPeca[posicao].IdPeca;
                    model.Nom_item_peca = this.txtDescItemPeca.Text;
                    model.Id_item_peca = idMaximo;
                    ListaModel.Add(model);
                }

                return ListaModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ListaModel = null;
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
        private void btnBuscaPeca_Click(object sender, EventArgs e)
        {
            this._modelPeca = new List<mPeca>();
            frmBuscaPeca frmTela = new frmBuscaPeca(this._modelPeca, true, false);
            try
            {
                DialogResult resultado = frmTela.ShowDialog();
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
                            this.txtCodigoPeca.Text = this._modelPeca[contador].Nom;
                        }
                        else
                        {
                            this.txtCodigoPeca.Text += ", " + this._modelPeca[contador].Nom;
                        }
                    }
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