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
    public partial class frmResumoOrdemProducao : Form
    {
        #region Atributos
        private int _idVenda;
        #endregion Atributos

        #region Construtor
        public frmResumoOrdemProducao()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos
        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion btnVoltar Click

        #region btnGerarArquivo Click
        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {

        }
        #endregion btnGerarArquivo Click

        #region Form Load
        private void frmResumoOrdemProducao_Load(object sender, EventArgs e)
        {

        }
        #endregion Form Load 
        #endregion Eventos

        #region Cria Nos Tree View
        /// <summary>
        /// Cria os nós que apareceram no TreeView
        /// </summary>
        private void CriaNosTreeView()
        {
            rVendaProduto regraVendaProduto = new rVendaProduto();
            DataTable dtVendaProduto = null;
            try
            {
                dtVendaProduto = regraVendaProduto.BuscaProdutosVenda(this._idVenda);
                foreach (DataRow linha in dtVendaProduto.Rows)
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraVendaProduto = null;
                if (dtVendaProduto != null)
                {
                    dtVendaProduto.Dispose();
                    dtVendaProduto = null;
                }
            }
        }
        #endregion Cria Nos Tree View


        private void CriaNoProduto(int idProduto)
        {
            rProduto regraProduto = new rProduto();
            TreeNode noProduto = null;
            TreeNode noFamiliaMotor = null;
            TreeNode noKit = null;
            DataTable dtProduto = null;
            try
            {
                dtProduto = regraProduto.BuscaProdutosVenda(idProduto, this._idVenda);
                foreach (DataRow linha in dtProduto.Rows)
                {
                    noProduto = new TreeNode(linha["dsc_prdto"].ToString() + " - " + linha["qtd"].ToString());
                    if (linha["id_fam_motor"] != DBNull.Value)
                    {
                        //noFamiliaMotor = this.CriaNoFamiliaMotor(Convert.ToInt32(linha["id_fam_motor"]));
                        noProduto.Nodes.Add(noFamiliaMotor);
                    }
                    else if (linha["id_kit"] != DBNull.Value)
                    {
                        //noKit = this.CriaNoKit(Convert.ToInt32(linha["id_kit"]));
                        noProduto.Nodes.Add(noKit);
                    }

                    this.tvOrdemProducao.Nodes.Add(noProduto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                noProduto = null;
                regraProduto = null;
                noFamiliaMotor = null;
                noKit = null;
                if (dtProduto != null)
                {
                    dtProduto.Dispose();
                    dtProduto = null;
                }
            }
        }

        /*private TreeNode CriaNoFamiliaMotor(int idFamiliaMotor)
        {
            DataTable dtFamiliaMotor = null;
            TreeNode noFamiliaMotor = null;
            rFamiliaMotor regraFamiliaMotor = new rFamiliaMotor();
            try
            {
                //dtFamiliaMotor = 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraFamiliaMotor = null;
                noFamiliaMotor = null;
                if (dtFamiliaMotor != null)
                {
                    dtFamiliaMotor.Dispose();
                    dtFamiliaMotor = null;
                }
            }
        }*/

        /*private TreeNode CriaNoKit(int idKit)
        {

        }*/
    }
}