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
    public partial class frmBuscaVenda : Form
    {
        #region Atributos
        mVenda _model;
        bool _alteracao;
        #endregion

        #region Construtor
        public frmBuscaVenda(mVenda modelVenda)
        {
            InitializeComponent();
            this._model = modelVenda;
            this._alteracao = false;
        }

        public frmBuscaVenda(mVenda modelVenda, bool Alteracao)
        {
            InitializeComponent();
            this._model = modelVenda;
            this._alteracao = Alteracao;
        }
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.populaGrid();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.retornaModel();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmBuscaVenda_Load(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                this.retornaModel();
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
                this.retornaModel();
                this.DeletaCadastro();
                this.populaGrid();
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
        private void populaGrid()
        {
            rVenda regra = new rVenda();
            DataTable dt = new DataTable();

            string data = this.txtDataVenda.Text;
            string cliente = this.txtNomeCliente.Text;
            try
            {
                dt = regra.buscaVenda(data, cliente);
                dgVenda.DataSource = dt;
                dgVenda.Columns[0].Visible = true;

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

        private void retornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgVenda.DataSource;
                if (this.dgVenda.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgVenda.CurrentRow != null)
                        {
                            dvc = this.dgVenda["hVenda", this.dgVenda.CurrentRow.Index];
                            this._model.IdVenda = Convert.ToInt32(dvc.Value);
                            //hCliente??
                            dvc = this.dgVenda["hData", this.dgVenda.CurrentRow.Index];
                            this._model.DatVenda = Convert.ToDateTime(dvc.Value);

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
                        MessageBox.Show("É necessário cadastrar uma Venda", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar uma Venda!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
            rVenda regraVenda = new rVenda();
            DataTable dtRegistroVenda = null;
            try
            {
                dtRegistroVenda = regraVenda.BuscaUmRegistro(this._model);
                this._model.Deserialize(dtRegistroVenda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraVenda = null;
                if (dtRegistroVenda != null)
                {
                    dtRegistroVenda.Dispose();
                    dtRegistroVenda = null;
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
            rVenda regraVenda = new rVenda();
            try
            {
                regraVenda.ValidarDeleta(this._model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraVenda = null;
            }
        }
        #endregion
    }
}
