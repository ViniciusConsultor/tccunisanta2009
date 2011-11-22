﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.Mapper;
using TCC.Regra;

namespace TCC.UI
{
    public partial class frmBuscaTipoProduto : Form
    {

        #region Atributos
        mTipoProduto _model;
        bool _alteracao;
        #endregion

        #region Construtor
        public frmBuscaTipoProduto(mTipoProduto modelParam)
        {
            InitializeComponent();
            this._model = modelParam;
            this._alteracao = false;
        }
        public frmBuscaTipoProduto(mTipoProduto modelParam, bool Alteracao)
        {
            InitializeComponent();
            this._model = modelParam;
            this._alteracao = Alteracao;
        }
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RetornaModel();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmBuscaTipoProduto_Load(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                this.RetornaModel();
                this.PopulaModelCompletoAlteracao();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (TCC.Regra.Exceptions.Busca.LinhaSemSelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (TCC.Regra.Exceptions.Busca.CadastrarDadoException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (TCC.Regra.Exceptions.Busca.SemBuscaESelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.RetornaModel();
                this.DeletaCadastro();
                this.PopulaGrid();
            }
            catch (TCC.Regra.Exceptions.Busca.LinhaSemSelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (TCC.Regra.Exceptions.Busca.CadastrarDadoException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (TCC.Regra.Exceptions.Busca.SemBuscaESelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Metodos
        private void PopulaGrid()
        {
            rTipoProduto regra = new rTipoProduto();
            DataTable dt = new DataTable();
            try
            {
                dt = regra.BuscaTipoProduto(this.txtFiltro.Text);
                this.dgTipoProduto.DataSource = dt;
                dgTipoProduto.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
                dt = null;
            }
        }

        private void RetornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgTipoProduto.DataSource;
                if (this.dgTipoProduto.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgTipoProduto.CurrentRow != null)
                        {
                            dvc = this.dgTipoProduto["id_tipo_prod", this.dgTipoProduto.CurrentRow.Index];
                            this._model.IdTipoProd = Convert.ToInt32(dvc.Value);
                            dvc = this.dgTipoProduto["Tipo Produto", this.dgTipoProduto.CurrentRow.Index];
                            this._model.Nom = dvc.Value.ToString();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("É necessário Selecionar uma linha", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("É necessário cadastrar um Tipo de Produto", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar um Tipo de Produto", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dvc != null)
                {
                    dvc.Dispose();
                    dvc = null;
                }
                if (dtSource != null)
                {
                    dtSource.Dispose();
                    dtSource = null;
                }
            }
        }

        private void PopulaModelCompletoAlteracao()
        {
            rTipoProduto regraTipoProduto = new rTipoProduto();
            DataTable dtRegistroTipoProduto = null;
            try
            {
                dtRegistroTipoProduto = regraTipoProduto.BuscaUmRegistro(this._model);
                this._model.Deserialize(dtRegistroTipoProduto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraTipoProduto = null;
                if (dtRegistroTipoProduto != null)
                {
                    dtRegistroTipoProduto.Dispose();
                    dtRegistroTipoProduto = null;
                }
            }
        }

        private void HabilitaBotoes()
        {
            this.btnAlterar.Visible = this._alteracao;
            this.btnExcluir.Visible = this._alteracao;
            //Alteração negado!!
            //------------------
            this.btnOK.Visible = !this._alteracao;
        }

        private void DeletaCadastro()
        {
            rTipoProduto regraTipoProduto = new rTipoProduto();
            try
            {
                regraTipoProduto.ValidarDeleta(this._model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraTipoProduto = null;
            }
        }
        #endregion

    }
}