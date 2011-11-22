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
    public partial class frmBuscaCompra : Form
    {
        #region Atributos
        mCompra _model;
        bool _alteracao;
        #endregion

        #region Construtor
        public frmBuscaCompra(mCompra modelCompra)
        {
            InitializeComponent();
            this._model = modelCompra;
            this._alteracao = false;
        }

        public frmBuscaCompra(mCompra modelCompra, bool alteracao)
        {
            InitializeComponent();
            this._model = modelCompra;
            this._alteracao = alteracao;
        }
        #endregion

        #region Eventos
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RetornaModel();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
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
                this.RetornaModel();
                this.PopulaGrid();
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

        private void frmBuscaCompra_Load(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
        }
        #endregion

        #region Metodos
        private void PopulaGrid()
        {
            rCompra regra = new rCompra();
            DataTable dt = new DataTable();
            try
            {
                dt = regra.BuscaCompra(this.txtFiltro.Text);
                dgCompra.DataSource = dt;
                dgCompra.Columns[0].Visible = false;
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
                dtSource = (DataTable)this.dgCompra.DataSource;
                if (this.dgCompra.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgCompra.CurrentRow != null)
                        {
                            dvc = this.dgCompra["id_compra", this.dgCompra.CurrentRow.Index];
                            this._model.IdCompra = Convert.ToInt32(dvc.Value);
                            dvc = this.dgCompra["obs", this.dgCompra.CurrentRow.Index];
                            this._model.Obs = dvc.Value.ToString();
                            dvc = this.dgCompra["dat", this.dgCompra.CurrentRow.Index];
                            this._model.Dat = Convert.ToDateTime(dvc.Value);
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
                        MessageBox.Show("É necessário cadastrar um Cliente", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar um Cliente!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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

        #endregion
    }
}