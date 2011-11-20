using System;
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
    public partial class frmBuscaOrdemServico : Form
    {
        #region Atributos
        mOrdemServico _modelOrdemServico;
        bool _alteracao;
        #endregion Atributos

        #region Construtor
        public frmBuscaOrdemServico(mOrdemServico model)
        {
            InitializeComponent();
            _modelOrdemServico = model;
            _alteracao = false;
        }

        public frmBuscaOrdemServico(mOrdemServico model, bool Alteracao)
        {
            InitializeComponent();
            _modelOrdemServico = model;
            _alteracao = Alteracao;
        }
        #endregion Construtor

        #region Eventos
        
        #region btnBuscarOrdemServico Click
        private void btnBuscarOrdemServico_Click(object sender, EventArgs e)
        {
            this.populaGrid();
        }
        #endregion btnBuscarOrdemServico Click

        #region btnFechar Click
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion btnFechar Click

        #region btnOK Click
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.retornaModel();
        }
        #endregion btnOK Click

        #region btnAlterar Click
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                this.retornaModel();
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
        #endregion btnAlterar Click

        #region btnExclUIr Click
        private void btnExclUIr_Click(object sender, EventArgs e)
        {
            try
            {
                this.retornaModel();
                this.DeletaCadastro();
                this.populaGrid();
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
        #endregion btnExclUIr Click

        #endregion Eventos

        #region Metodos
        
        #region PopulaGrid
        private void populaGrid()
        {
            rOrdemServico regra = new rOrdemServico();
            DataTable dt = new DataTable();

            string ordem = this.txtFiltroOrdemServico.Text;
            try
            {
                dt = regra.buscaOrdemServico(ordem);
                dgOrdemServico.DataSource = dt;
                dgOrdemServico.Columns[0].Visible = true;
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
        #endregion PopulaGrid

        #region Retorna Model
        private void retornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgOrdemServico.DataSource;
                if (this.dgOrdemServico.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgOrdemServico.CurrentRow != null)
                        {
                            dvc = this.dgOrdemServico["hCodigoOrdemServ", this.dgOrdemServico.CurrentRow.Index];
                            this._modelOrdemServico.IdOrdemServ = Convert.ToInt32(dvc.Value);
                            //Outros campos, se houver

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("É necessário Selecionar uma linha!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("É necessário cadastrar uma Ordem de Serviço!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar uma Ordem de Serviço!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
        #endregion Retorna Model

        #region PopulaModelCompletoAlteracao
        private void PopulaModelCompletoAlteracao()
        {
            rOrdemServico regra = new rOrdemServico();
            DataTable dtRegistroOrdem = null;
            try
            {
                dtRegistroOrdem = regra.BuscaUmRegistro(this._modelOrdemServico);
                this._modelOrdemServico.Deserialize(dtRegistroOrdem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
                if (dtRegistroOrdem != null)
                {
                    dtRegistroOrdem.Dispose();
                    dtRegistroOrdem = null;
                }
            }
        }
        #endregion PopulaModelCompletoAlteracao

        #region HabiitaBotoes
        private void HabilitaBotoes()
        {
            this.btnAlterar.Visible = this._alteracao;
            this.btnExclUIr.Visible = this._alteracao;
            //Alteração negado!!
            //------------------
            this.btnOK.Visible = !this._alteracao;
        }
        #endregion HabiitaBotoes

        #region DeletaCadastro
        private void DeletaCadastro()
        {
            rOrdemServico regra = new rOrdemServico();
            try
            {
                regra.ValidarDeleta(this._modelOrdemServico);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
            }
        }
        #endregion DeletaCadastro

        #endregion Metodos
    }
}
