using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmBuscaPeca : Form
    {
        #region Atributos
        mPeca _model;
        bool _alteracao;
        #endregion

        #region Construtor
        public frmBuscaPeca(mPeca modelPeca)
        {
            InitializeComponent();
            this._model = modelPeca;
            this._alteracao = false;
        }
        
        public frmBuscaPeca(mPeca modelPeca, bool Alteracao)
        {
            InitializeComponent();
            this._model = modelPeca;
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

        private void frmBuscaPeca_Load(object sender, EventArgs e)
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.RetornaModel();
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
        #endregion

        #region Metodos
        private void PopulaGrid()
        {
            rPeca regraPeca = new rPeca();
            DataTable dt = new DataTable();
            try
            {
                dt = regraPeca.BuscaPeca(this.txtFiltro.Text);
                dgPeca.DataSource = dt;
                this.dgPeca.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                regraPeca = null;
                dt = null;
            }
        }

        private void RetornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgPeca.DataSource;
                if (this.dgPeca.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgPeca.CurrentRow != null)
                        {
                            dvc = this.dgPeca["hIdPeca", this.dgPeca.CurrentRow.Index];
                            _model.IdPeca = Convert.ToInt32(dvc.Value);
                            dvc = this.dgPeca["hNome", this.dgPeca.CurrentRow.Index];
                            _model.Nom = dvc.Value.ToString();
                            dvc = this.dgPeca["hIdPecaReal", this.dgPeca.CurrentRow.Index];
                            _model.IdPecaReal = dvc.Value.ToString();
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
                        MessageBox.Show("É necessário cadastrar um motor!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar um motor!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
            rPeca regraPeca = new rPeca ();
            DataTable dtRegistroPeca = null;
            try
            {
                dtRegistroPeca = regraPeca.BuscaUmRegistro(this._model);
                this._model.Deserialize(dtRegistroPeca);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraPeca = null;
                if (dtRegistroPeca != null)
                {
                    dtRegistroPeca.Dispose();
                    dtRegistroPeca = null;
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
            rMotor regraMotor = new rMotor();
            try
            {
                regraMotor.ValidarDeleta(this._model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraMotor = null;
            }
        }
        #endregion

    }
}
