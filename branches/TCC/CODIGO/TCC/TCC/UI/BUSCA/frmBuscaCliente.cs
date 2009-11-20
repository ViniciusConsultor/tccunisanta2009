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
    public partial class frmBuscaCliente : Form
    {
        #region Atributos
        mCliente _model;
        bool _alteracao;
        #endregion

        #region Construtor
        public frmBuscaCliente(mCliente modelCliente)
        {
            InitializeComponent();
            this._model = modelCliente;
            this._alteracao = false;
        }

        public frmBuscaCliente(mCliente modelCliente, bool alteracao)
        {
            InitializeComponent();
            this._model = modelCliente;
            this._alteracao = alteracao;
        }
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                this.PopulaModelDadosGrid();
                this.DialogResult = DialogResult.OK;
                base.Close();
            }
            catch (BUSINESS.Exceptions.Busca.LinhaSemSelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Busca.CadastrarDadoException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Busca.SemBuscaESelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            base.Close();
        }
        #endregion

        #region Metodos
        private void PopulaGrid()
        {
            rCliente regraCliente = new rCliente();
            DataTable dt = new DataTable();
            try
            {
                dt = regraCliente.BuscaClientes(this.txtFiltro.Text);
                dgCliente.DataSource = dt;
                dgCliente.Columns[0].Visible = false;
                //dgCliente.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraCliente = null;
                dt = null;
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
                dtSource = (DataTable)this.dgCliente.DataSource;
                if (this.dgCliente.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgCliente.CurrentRow != null)
                        {
                            dvc = this.dgCliente["hId", this.dgCliente.CurrentRow.Index];
                            this._model.IdCliente = Convert.ToInt32(dvc.Value);
                            dvc = this.dgCliente["hNome", this.dgCliente.CurrentRow.Index];
                            this._model.NomeCliente = dvc.Value.ToString();
                        }
                        else
                        {
                            throw new BUSINESS.Exceptions.Busca.LinhaSemSelecionarException();
                        }
                    }
                    else
                    {
                        throw new BUSINESS.Exceptions.Busca.CadastrarDadoException(this._model.getNomeTabela());
                    }
                }
                else
                {
                    throw new BUSINESS.Exceptions.Busca.SemBuscaESelecionarException(this._model.getNomeTabela());
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                this.PopulaModelDadosGrid();
                this.PopulaModelCompletoAlteracao();
                this.DialogResult = DialogResult.OK;
                base.Close();
            }
            catch (BUSINESS.Exceptions.Busca.LinhaSemSelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Busca.CadastrarDadoException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Busca.SemBuscaESelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Pega os dados que estão populados Atravez do Grid e Completa o mapper
        /// </summary>
        private void PopulaModelCompletoAlteracao()
        {
            rCliente regraCliente = new rCliente();
            DataTable dtRegistroUsuario = null;
            try
            {
                dtRegistroUsuario = regraCliente.BuscaUmRegistro(this._model);
                this._model.Deserialize(dtRegistroUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraCliente = null;
                if (dtRegistroUsuario != null)
                {
                    dtRegistroUsuario.Dispose();
                    dtRegistroUsuario = null;
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.PopulaModelDadosGrid();
                this.DeletaCadastro();
                this.PopulaGrid();
            }
            catch (BUSINESS.Exceptions.Busca.LinhaSemSelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Busca.CadastrarDadoException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.Busca.SemBuscaESelecionarException ex)
            {
                MessageBox.Show(ex.Mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DeletaCadastro()
        {
            rCliente regraCliente = new rCliente();
            try
            {
                regraCliente.ValidarDeleta(this._model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraCliente = null;
            }
        }

        private void frmBuscaCliente_Load(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
        }
    }
}
