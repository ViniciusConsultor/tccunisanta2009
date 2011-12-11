using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI.Resumo
{
    public partial class frmResumoVendaProduto : Form
    {
        #region Atributos
        private List<mVendaProduto> _listaModelVendaProduto;
        #endregion Atributos

        #region Construtor
        public frmResumoVendaProduto(List<mVendaProduto> lista, string nomeKit)
        {
            InitializeComponent();
            this._listaModelVendaProduto = lista;
            this.lblNome.Text = nomeKit;
        }
        #endregion Construtor

        #region Eventos
        #region Form Load
        private void frmResumoVendaProduto_Load(object sender, EventArgs e)
        {
            DataTable dtSource = new DataTable();
            try
            {
                this.CriaColunasDataTable(dtSource);
                this.PopulaDataTableListaModel(dtSource);
                this.dgProdutos.DataSource = dtSource;
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
        #endregion Form Load 

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion btnVoltar Click

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
                dt.Columns.Add("id_prdto");
                dt.Columns.Add("dsc_prdto");
                dt.Columns.Add("Qtd");
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
            rProduto regraProduto = new rProduto();
            mProduto modelProduto = new mProduto();
            try
            {
                foreach (mVendaProduto model in this._listaModelVendaProduto)
                {
                    modelProduto = regraProduto.BuscaUnicoRegistro(model.IdProduto);
                    linha = dt.NewRow();
                    linha["id_prdto"] = modelProduto.IdProduto;
                    linha["dsc_prdto"] = modelProduto.DescProduto;
                    linha["Qtd"] = model.Qtd;
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
                regraProduto = null;
                modelProduto = null;
            }
        }
        #endregion Popula DataTable ListaModel 
        #endregion Metodos
    }
}
