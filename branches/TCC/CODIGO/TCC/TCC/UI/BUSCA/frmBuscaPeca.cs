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
        List<mPeca> _model;
        bool _alteracao;
        #endregion

        #region Construtor
        public frmBuscaPeca(List<mPeca> modelPeca, bool multiSelecao, bool Alteracao)
        {
            InitializeComponent();
            this._model = modelPeca;
            this._alteracao = Alteracao;
            this.dgPeca.MultiSelect = multiSelecao;
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
            rPeca regra = new rPeca();
            DataTable dt = new DataTable();
            try
            {
                dt = regra.BuscaPecaNome(this.txtFiltro.Text);
                IniciaHeaderDatagrid();
                dgPeca.DataSource = dt;
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
            DataGridViewCell dvC = null;
            DataTable dtSource = new DataTable();
            mPeca modelPeca;
            try
            {
                dtSource = (DataTable)this.dgPeca.DataSource;
                if (this.dgPeca.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgPeca.CurrentRow != null)
                        {
                            foreach (DataGridViewRow linha in this.dgPeca.Rows)
                            {
                                if (linha.Cells[0].Value != null)
                                {
                                    if (Convert.ToBoolean(linha.Cells[0].Value) != false)
                                    {
                                        modelPeca = new mPeca();

                                        //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                                        //------------------------------------------------------------------------------------
                                        //Pega id Peça
                                        dvC = linha.Cells[1];
                                        modelPeca.IdPeca = Convert.ToInt32(dvC.Value);
                                        //Pega Peça
                                        dvC = linha.Cells[2];
                                        modelPeca.Nom = dvC.Value.ToString();
                                        this._model.Add(modelPeca);
                                    }
                                }
                            }
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
            rPeca regraPeca = new rPeca();
            DataTable dtRegistroPeca = null;
            try
            {
                dtRegistroPeca = regraPeca.BuscaUmRegistro(this._model[0]);
                this._model[0].Deserialize(dtRegistroPeca);
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
            rPeca regraPeca = new rPeca();
            try
            {
                regraPeca.ValidarDeleta(this._model[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraPeca = null;
            }
        }
        #endregion

        private void IniciaHeaderDatagrid()
        {
            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn peca = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn idPeca = new DataGridViewTextBoxColumn();
            try
            {
                check.HeaderText = "Seleção";
                check.Visible = true;
                check.ReadOnly = false;
                check.ValueType = typeof(bool);
                peca.DataPropertyName = "Peça";
                peca.HeaderText = "Peça";
                peca.ReadOnly = true;
                idPeca.DataPropertyName = "id_peca";
                idPeca.HeaderText = "id_peca";
                idPeca.ReadOnly = true;
                this.dgPeca.Columns.Add(check);
                this.dgPeca.Columns.Add(peca);
                this.dgPeca.Columns.Add(idPeca);
                this.dgPeca.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
    }
}
