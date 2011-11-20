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
    public partial class frmBuscaKit : FormPai
    {
        #region Atributos
        mKitGrupoPeca _model;
        bool _alteracao;
        bool _buscaMenu;
        #endregion

        #region Construtor
        public frmBuscaKit()
        {
            InitializeComponent();
            this._buscaMenu = true;
        }

        public frmBuscaKit(mKitGrupoPeca modelKit)
        {
            InitializeComponent();
            this._model = modelKit;
            this._alteracao = false;
        }

        public frmBuscaKit(mKitGrupoPeca modelKit, bool Alteracao)
        {
            InitializeComponent();
            this._model = modelKit;
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
            base.FechaTela(this);
        }

        private void frmBuscaKit_Load(object sender, EventArgs e)
        {
            if (this._buscaMenu == true)
            {
                this.btnAlterar.Visible = false;
                this.btnExclUIr.Visible = false;
                this.btnOK.Visible = false;
            }
            else
            {
                this.HabilitaBotoes();
            }
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
            rKitGrupoPeca regra = new rKitGrupoPeca();
            DataTable dt = new DataTable();
            try
            {
                dt = regra.BuscaKitGrupoPecaNome(this.txtFiltro.Text);
                dgKit.DataSource = dt;
                dgKit.Columns[0].Visible = false;
                dgKit.Columns[3].Visible = false;
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
                dtSource = (DataTable)this.dgKit.DataSource;
                if (this.dgKit.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgKit.CurrentRow != null)
                        {
                            dvc = this.dgKit["hIdKit", this.dgKit.CurrentRow.Index];
                            this._model.IdKit = Convert.ToInt32(dvc.Value);
                            dvc = this.dgKit["hIdKitReal", this.dgKit.CurrentRow.Index];
                            this._model.IdKitReal = Convert.ToString(dvc.Value);
                            dvc = this.dgKit["hNome", this.dgKit.CurrentRow.Index];
                            this._model.Nom_grupo = dvc.Value.ToString();
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
                        MessageBox.Show("É necessário cadastrar um Kit Grupo Peça", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar um Kit Grupo Peça", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
            rKitGrupoPeca regraKit = new rKitGrupoPeca();
            DataTable dtRegistroKit = null;
            try
            {
                dtRegistroKit = regraKit.BuscaUmRegistro(this._model);
                this._model.Deserialize(dtRegistroKit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraKit = null;
                if (dtRegistroKit != null)
                {
                    dtRegistroKit.Dispose();
                    dtRegistroKit = null;
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
            rKitGrupoPeca regraKit = new rKitGrupoPeca();
            try
            {
                regraKit.ValidarDeleta(this._model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraKit = null;
            }
        }
        #endregion
    }
}
