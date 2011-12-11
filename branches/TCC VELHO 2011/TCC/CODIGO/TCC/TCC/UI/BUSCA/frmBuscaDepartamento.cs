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
    public partial class frmBuscaDepartamento : Form
    {
        #region Atributos
        mDepartamento _modelDep;
        bool _alteracao;
        #endregion

        #region Construtor
        public frmBuscaDepartamento(mDepartamento modelDepartamento)
        {
            InitializeComponent();
            this._modelDep = modelDepartamento;
            this._alteracao = false;
        }

        public frmBuscaDepartamento(mDepartamento modelDepartamento, bool Alteracao)
        {
            InitializeComponent();
            this._modelDep = modelDepartamento;
            this._alteracao = Alteracao;
        }
        #endregion Construtor

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

        private void frmBuscaDepartamento_Load(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
        }
        #endregion Eventos

        #region Metodos
        private void PopulaGrid()
        {
            rDepartamento regraDepto = new rDepartamento();
            DataTable dt = new DataTable();
            try
            {
                dt = regraDepto.BuscaDepartamento(this.txtFiltro.Text);
                dgDepartamento.DataSource = dt;
                dgDepartamento.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraDepto = null;
                dt = null;
            }
        }

        private void RetornaModel()
        {
            DataGridViewCell dvC = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgDepartamento.DataSource;
                if (this.dgDepartamento.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgDepartamento.CurrentRow != null)
                        {
                            //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                            //------------------------------------------------------------------------------------
                            dvC = this.dgDepartamento["hidDepto", this.dgDepartamento.CurrentRow.Index];
                            this._modelDep.IdDepto = Convert.ToInt32(dvC.Value);
                            dvC = this.dgDepartamento["hDepartamento", this.dgDepartamento.CurrentRow.Index];
                            this._modelDep.DscDepto = dvC.Value.ToString();
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
                        MessageBox.Show("É necessário Cadastrar um Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
            rDepartamento regraDepartamento = new rDepartamento();
            DataTable dtRegistroDepartamento = null;
            try
            {
                dtRegistroDepartamento = regraDepartamento.BuscaUmRegistro(this._modelDep);
                this._modelDep.Deserialize(dtRegistroDepartamento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraDepartamento = null;
                if (dtRegistroDepartamento != null)
                {
                    dtRegistroDepartamento.Dispose();
                    dtRegistroDepartamento = null;
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
            rDepartamento regraDepartamento = new rDepartamento();
            try
            {
                regraDepartamento.ValidarDeleta(this._modelDep);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraDepartamento = null;
            }
        }
        #endregion
    }
}
