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
    public partial class frmBuscaUsuario : Form
    {
        #region Atributos
        bool _alteracao;
        mUsuario _model;
        #endregion

        #region Construtor
        public frmBuscaUsuario(mUsuario modelUsuario)
        {
            InitializeComponent();
            this._model = modelUsuario;
            this._alteracao = false;
        }

        public frmBuscaUsuario(mUsuario modelUsuario, bool Alteracao)
        {
            InitializeComponent();
            this._model = modelUsuario;
            this._alteracao = Alteracao;
        }
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RetornaModel();
        }

        private void frmBuscaUsuario_Load(object sender, EventArgs e)
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
        private void RetornaModel()
        {
            DataGridViewCell dvC = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgUsuario.DataSource;
                if (this.dgUsuario.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this._alteracao == false)
                        {
                            if (this.dgUsuario.CurrentRow != null)
                            {
                                //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                                //------------------------------------------------------------------------------------
                                dvC = this.dgUsuario["id_usu", this.dgUsuario.CurrentRow.Index];
                                _model.IdUsuario = Convert.ToInt32(dvC.Value);
                                dvC = this.dgUsuario["Usuário", this.dgUsuario.CurrentRow.Index];
                                _model.Login = dvC.Value.ToString();
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("É necessário Selecionar uma linha", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("É necessário Cadastrar um Usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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

        private void PopulaGrid()
        {
            rUsuario regraUsuario = new rUsuario();
            DataTable dt = new DataTable();
            try
            {
                dt = regraUsuario.BuscaUsuario(this.txtFiltro.Text);
                dgUsuario.DataSource = dt;
                this.dgUsuario.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraUsuario = null;
                dt = null;
            }
        }

        private void PopulaModelCompletoAlteracao()
        {
            rUsuario regraUsuario = new rUsuario();
            DataTable dtRegistroUsuario = null;
            try
            {
                dtRegistroUsuario = regraUsuario.BuscaUmRegistro(this._model);
                this._model.Deserialize(dtRegistroUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraUsuario = null;
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

        private void DeletaCadastro()
        {
            rUsuario regraUsuario = new rUsuario();
            try
            {
                regraUsuario.ValidarDeleta(this._model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraUsuario = null;
            }
        }
        #endregion
    }
}
