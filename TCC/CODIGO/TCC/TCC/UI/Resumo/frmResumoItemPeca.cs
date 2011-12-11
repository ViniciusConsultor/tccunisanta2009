using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI.Resumo
{
    public partial class frmResumoItemPeca : Form
    {
        #region Atributos
        List<mItemPeca> _listaModelItemPeca;
        #endregion Atributos

        #region Construtor
        public frmResumoItemPeca(List<mItemPeca> lista, string nomeItem)
        {
            InitializeComponent();
            this._listaModelItemPeca = lista;
            this.lblNome.Text = nomeItem;
        }
        #endregion Construtor

        #region Eventos

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion btnVoltar Click

        #region frmResumoItemPeca Load
        private void frmResumoItemPeca_Load(object sender, EventArgs e)
        {
            DataTable dtSource = new DataTable();
            try
            {
                this.CriaColunasDataTable(dtSource);
                this.PopulaDataTableListaModel(dtSource);
                this.dgItems.DataSource = dtSource;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dtSource != null)
                {
                    dtSource.Dispose();
                    dtSource = null;
                }
            }
        }
        #endregion frmResumoItemPeca Load

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion btnAceitar Click
        #endregion Eventos

        #region Metodos

        #region CriaColunas DataTable
        private void CriaColunasDataTable(DataTable dt)
        {
            try
            {
                dt.Columns.Add("id_peca");
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Peça");
                dt.Columns.Add("qtd");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion CriaColunas DataTable

        #region Popula DataTable ListaModel
        /// <summary>
        /// Popula o DataTable com a table de model
        /// </summary>
        private void PopulaDataTableListaModel(DataTable dt)
        {
            DataRow linha;
            rPeca regraPeca = new rPeca();
            mPeca modelPeca = new mPeca();
            try
            {
                foreach (mItemPeca model in this._listaModelItemPeca)
                {
                    modelPeca = regraPeca.BuscaUnicoRegistro(Convert.ToInt32(model.Id_peca));
                    linha = dt.NewRow();
                    linha["id_peca"] = model.Id_peca;
                    linha["Codigo"] = modelPeca.IdPecaReal;
                    linha["Peça"] = modelPeca.Nom;
                    linha["qtd"] = model.Qtd_peca;
                    dt.Rows.Add(linha);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                linha = null;
                regraPeca = null;
                modelPeca = null;
            }
        }
        #endregion Popula DataTable ListaModel

        #endregion Metodos
    }
}
