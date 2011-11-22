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
    public partial class frmBuscaColaborador : Form
    {
        #region Atributos
        mColaborador _model;
        bool _alteracao;
        #endregion

        #region Construtor
        public frmBuscaColaborador(mColaborador modelColaborador)
        {
            InitializeComponent();
            this._model = modelColaborador;
            this._alteracao = false;
        }

        public frmBuscaColaborador(mColaborador modelColaborador, bool alteracao)
        {
            InitializeComponent();
            this._model = modelColaborador;
            this._alteracao = alteracao;
        }
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void frmBuscaColaborador_Load(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.PopulaModelDadosGrid();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                this.PopulaModelDadosGrid();
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
                this.PopulaModelDadosGrid();
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
            rColaborador regraColaborador = new rColaborador();
            DataTable dt = new DataTable();
            try
            {
                dt = regraColaborador.BuscaColaborador(this.txtFiltro.Text);
                dgColaborador.DataSource = dt;
                dgColaborador.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraColaborador = null;
                dt = null;
            }
        }

        /// <summary>
        /// Pega os dados que estão populados Atravez do Grid e Completa o mapper
        /// </summary>
        private void PopulaModelCompletoAlteracao()
        {
            rColaborador regraColaborador = new rColaborador();
            DataTable dtRegistroColaborador = null;
            try
            {
                dtRegistroColaborador = regraColaborador.BuscaUmRegistro(this._model);
                this._model.Deserialize(dtRegistroColaborador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraColaborador = null;
                if (dtRegistroColaborador != null)
                {
                    dtRegistroColaborador.Dispose();
                    dtRegistroColaborador = null;
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
            rColaborador regraColaborador = new rColaborador();
            try
            {
                regraColaborador.ValidarDeleta(this._model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraColaborador = null;
            }
        }

        /// <summary>
        /// Popula o model com os dados que estão no DataSource do Grid
        /// </summary>
        private void PopulaModelDadosGrid()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgColaborador.DataSource;
                if (this.dgColaborador.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgColaborador.CurrentRow != null)
                        {
                            dvc = this.dgColaborador["hid_colab", this.dgColaborador.CurrentRow.Index];
                            this._model.IdColab = Convert.ToInt32(dvc.Value);
                            dvc = this.dgColaborador["hColaborador", this.dgColaborador.CurrentRow.Index];
                            this._model.NomeColab = dvc.Value.ToString();
                        }
                        else
                        {
                            throw new TCC.Regra.Exceptions.Busca.LinhaSemSelecionarException();
                        }
                    }
                    else
                    {
                        throw new TCC.Regra.Exceptions.Busca.CadastrarDadoException(this._model.getNomeTabela());
                    }
                }
                else
                {
                    throw new TCC.Regra.Exceptions.Busca.SemBuscaESelecionarException(this._model.getNomeTabela());
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

        #endregion
    }
}