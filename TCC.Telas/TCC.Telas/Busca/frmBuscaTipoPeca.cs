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
    public partial class frmBuscaTipoPeca : Form
    {
        #region Atributos
        mTipoPeca _model;
        bool _alteracao;
        #endregion

        #region Construtor
        public frmBuscaTipoPeca(mTipoPeca modelTipoPeca)
        {
            InitializeComponent();
            this._model = modelTipoPeca;
            this._alteracao = false;
        }

        public frmBuscaTipoPeca(mTipoPeca modelTipoPeca, bool Alteracao)
        {
            InitializeComponent();
            this._model = modelTipoPeca;
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

        private void frmBuscaTipoPeca_Load(object sender, EventArgs e)
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

        private void btnExclUIr_Click(object sender, EventArgs e)
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
            rTipoPeca regra = new rTipoPeca();
            try
            {
                this.dgTipoPeca.DataSource = regra.BuscaTipoPeca(this.txtFiltro.Text);
                this.dgTipoPeca.Columns[0].Visible = false;
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

        private void RetornaModel()
        {
            DataGridViewCell dvC = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgTipoPeca.DataSource;
                if (this.dgTipoPeca.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgTipoPeca.CurrentRow != null)
                        {
                            //AtribUI a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                            //------------------------------------------------------------------------------------
                            dvC = this.dgTipoPeca["hIdTipoPeca", this.dgTipoPeca.CurrentRow.Index];
                            this._model.IdTipoPeca = Convert.ToInt32(dvC.Value);
                            dvC = this.dgTipoPeca["hDescricao", this.dgTipoPeca.CurrentRow.Index];
                            this._model.DscTipoPeca = dvC.Value.ToString();
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
                        MessageBox.Show("É necessário Cadastrar um Tipo de Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Tipo de Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dvC != null)
                {
                    dvC.Dispose();
                    dvC = null;
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
            rTipoPeca regraTipoPeca = new rTipoPeca();
            DataTable dtRegistroTipoPeca = null;
            try
            {
                dtRegistroTipoPeca = regraTipoPeca.BuscaUmRegistro(this._model);
                this._model.Deserialize(dtRegistroTipoPeca);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraTipoPeca = null;
                if (dtRegistroTipoPeca != null)
                {
                    dtRegistroTipoPeca.Dispose();
                    dtRegistroTipoPeca = null;
                }
            }
        }

        private void HabilitaBotoes()
        {
            this.btnAlterar.Visible = this._alteracao;
            this.btnExclUIr.Visible = this._alteracao;
            //Alteração negado!!
            //------------------
            this.btnOK.Visible = !this._alteracao;
        }

        private void DeletaCadastro()
        {
            rTipoPeca regraTipoPeca = new rTipoPeca();
            try
            {
                regraTipoPeca.ValidarDeleta(this._model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraTipoPeca = null;
            }
        }
        #endregion
    }
}
