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
    public partial class frmResumoItemKit : Form
    {
        #region Atributos
        private List<mItemKit> _listaModelItemKit;
        #endregion Atributos

        #region Construtor
        public frmResumoItemKit(List<mItemKit> lista, string nomeKit)
        {
            InitializeComponent();
            this._listaModelItemKit = lista;
            this.lblNome.Text = nomeKit;
        }
        #endregion Construtor

        #region Eventos

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion btnAceitar Click

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion btnVoltar Click

        #region frmResumoItemKit Load
        private void frmResumoItemKit_Load(object sender, EventArgs e)
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
        #endregion frmResumoItemKit Load

        #endregion Eventos

        #region Metodos

        #region CriaColunas DataTable
        private void CriaColunasDataTable(DataTable dt)
        {
            try
            {
                dt.Columns.Add("id_item");
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Item");
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
            rItem regraItem = new rItem();
            mItem modelItem = new mItem();
            try
            {
                foreach (mItemKit model in this._listaModelItemKit)
                {
                    modelItem = regraItem.BuscaUnicoRegistro(Convert.ToInt32(model.Id_item));
                    linha = dt.NewRow();
                    linha["id_item"] = model.Id_item;
                    linha["Codigo"] = modelItem.Id_item_real;
                    linha["Item"] = modelItem.Nom;
                    linha["qtd"] = model.Qtd_item;
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
                regraItem = null;
                modelItem = null;
            }
        }
        #endregion Popula DataTable ListaModel

        #endregion Metodos
    }
}
