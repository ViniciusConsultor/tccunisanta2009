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
    public partial class frmBuscaFamiliaMotor : Form
    {
        #region Atributos
        mFamiliaMotor _model;
        bool _alteracao;
        #endregion

        #region Construtor
        public frmBuscaFamiliaMotor(mFamiliaMotor modelFamilia)
        {
            InitializeComponent();
            this._model = modelFamilia;
            this._alteracao = false;
        }

        public frmBuscaFamiliaMotor(mFamiliaMotor modelFamilia, bool Alteracao)
        {
            InitializeComponent();
            this._model = modelFamilia;
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

        private void frmBuscaFamiliaMotor_Load(object sender, EventArgs e)
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
            rFamiliaMotor regraFamiliaM = new rFamiliaMotor();
            DataTable dt = new DataTable();
            try
            {
                dt = regraFamiliaM.BuscaFamiliaMotorNome(this.txtFiltro.Text);
                dgFamMotor.DataSource = dt;
                dgFamMotor.Columns[0].Visible = false;
                dgFamMotor.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraFamiliaM = null;
                dt = null;
            }
        }

        private void RetornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgFamMotor.DataSource;
                if (this.dgFamMotor.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgFamMotor.CurrentRow != null)
                        {
                            dvc = this.dgFamMotor["hIdFamMotor", this.dgFamMotor.CurrentRow.Index];
                            this._model.IdFamiliaMotor = Convert.ToInt32(dvc.Value);
                            dvc = this.dgFamMotor["hCodigo", this.dgFamMotor.CurrentRow.Index];
                            this._model.Id_fam_motor_real = Convert.ToString(dvc.Value);
                            dvc = this.dgFamMotor["hNome", this.dgFamMotor.CurrentRow.Index];
                            this._model.DscFamiliaMotor = dvc.Value.ToString();
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
                        MessageBox.Show("É necessário cadastrar uma Familia de Motor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar uma Familia de Motor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
            rFamiliaMotor regraFamMotor = new rFamiliaMotor();
            DataTable dtRegistroFamMotor = null;
            try
            {
                dtRegistroFamMotor = regraFamMotor.BuscaUmRegistro(this._model);
                this._model.Deserialize(dtRegistroFamMotor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraFamMotor = null;
                if (dtRegistroFamMotor != null)
                {
                    dtRegistroFamMotor.Dispose();
                    dtRegistroFamMotor = null;
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
            rFamiliaMotor regraFamMotor = new rFamiliaMotor();
            try
            {
                regraFamMotor.ValidarDeleta(this._model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraFamMotor = null;
            }
        }

        #endregion
    }
}
