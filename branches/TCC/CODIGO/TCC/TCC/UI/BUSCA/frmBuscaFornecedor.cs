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
    public partial class frmBuscaFornecedor : Form
    {
        #region Atributos
        mFornecedor _model;
        bool _alteracao;
        #endregion

        #region Construtor
        public frmBuscaFornecedor(mFornecedor modelFornecedor)
        {
            InitializeComponent();
            _model = modelFornecedor;
            _alteracao = false;
        }

        public frmBuscaFornecedor(mFornecedor modelFornecedor, bool Alteracao)
        {
            InitializeComponent();
            _model = modelFornecedor;
            _alteracao = Alteracao;
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

        private void frmBuscaFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Metodos
        private void PopulaGrid()
        {
            rFornecedor regra = new rFornecedor();
            try
            {
                this.dgFornecedor.DataSource = regra.BuscaFornecedor(this.txtFiltro.Text);
                dgFornecedor.Columns[0].Visible = false;
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
                dtSource = (DataTable)this.dgFornecedor.DataSource;
                if (this.dgFornecedor.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgFornecedor.CurrentRow != null)
                        {
                            //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                            //------------------------------------------------------------------------------------
                            dvC = this.dgFornecedor["id_forn", this.dgFornecedor.CurrentRow.Index];
                            _model.IdFornecedor = Convert.ToInt32(dvC.Value);
                            dvC = this.dgFornecedor["Fornecedor", this.dgFornecedor.CurrentRow.Index];
                            _model.NomeFornecedor = dvC.Value.ToString();
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
                        MessageBox.Show("É necessário Cadastrar um Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
        #endregion
    }
}
