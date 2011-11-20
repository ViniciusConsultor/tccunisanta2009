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
    public partial class frmBuscaNumMotor : Form
    {
        #region Atributos
        mNumMotor _model;
        bool _alteracao;
        #endregion

        #region Construtor
        public frmBuscaNumMotor(mNumMotor modelNumMotor)
        {
            InitializeComponent();
            this._model = modelNumMotor;
            this._alteracao = false;
        }

        public frmBuscaNumMotor(mNumMotor modelNumMotor, bool Alteracao)
        {
            InitializeComponent();
            this._model = modelNumMotor;
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

        private void frmBuscaNumMotor_Load(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
        }
        #endregion

        #region Metodos
        private void PopulaGrid()
        {
            rNumeroMotor regraNumMotor = new rNumeroMotor();
            DataTable dt = new DataTable();
            try
            {
                dt = regraNumMotor.BuscaNumeroMotor(this.txtFiltro.Text);
                dgNumMotor.DataSource = dt;
                this.dgNumMotor.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraNumMotor = null;
                dt = null;
            }
        }

        private void RetornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgNumMotor.DataSource;
                if (this.dgNumMotor.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgNumMotor.CurrentRow != null)
                        {
                            dvc = this.dgNumMotor["hid", this.dgNumMotor.CurrentRow.Index];
                            this._model.Id_num_motor = Convert.ToInt32(dvc.Value);
                            dvc = this.dgNumMotor["hCodigo", this.dgNumMotor.CurrentRow.Index];
                            this._model.IdNumMotorReal = dvc.Value.ToString();
                            dvc = this.dgNumMotor["hDescNumMotor", this.dgNumMotor.CurrentRow.Index];
                            this._model.Dsc_num_motor = dvc.Value.ToString();
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
                        MessageBox.Show("É necessário cadastrar um Numero de motor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar um Numero de motor!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
            rNumeroMotor regraNumMotor = new rNumeroMotor();
            DataTable dtRegistroNumMotor = null;
            try
            {
                dtRegistroNumMotor = regraNumMotor.BuscaUmRegistro(this._model);
                this._model.Deserialize(dtRegistroNumMotor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraNumMotor = null;
                if (dtRegistroNumMotor != null)
                {
                    dtRegistroNumMotor.Dispose();
                    dtRegistroNumMotor = null;
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
            rNumeroMotor regraNumMotor = new rNumeroMotor();
            try
            {
                regraNumMotor.ValidarDeleta(this._model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraNumMotor = null;
            }
        }
        #endregion

    }
}
