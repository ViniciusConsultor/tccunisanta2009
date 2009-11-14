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
                    this.CriaNoProduto(Convert.ToInt32(linha["id_prdto"]));
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
                        noFamiliaMotor = this.CriaNoFamiliaMotor(Convert.ToInt32(linha["id_fam_motor"]));
                        noProduto.Nodes.Add(noFamiliaMotor);
                    }
                    else if (linha["id_kit"] != DBNull.Value)
                    {
                        //noKit = this.CriaNoKit(Convert.ToInt32(linha["id_kit"]));
                        //noProduto.Nodes.Add(noKit);
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

        private TreeNode CriaNoFamiliaMotor(int idFamiliaMotor)
        {
            DataTable dtFamiliaMotor = null;
            TreeNode noFamiliaMotor = null, noKitGrupoPeca = null;
            rFamiliaMotor regraFamiliaMotor = new rFamiliaMotor();
            try
            {
                dtFamiliaMotor = regraFamiliaMotor.BuscaFamiliaMotorTree(idFamiliaMotor);
                foreach (DataRow linhaFamMotor in dtFamiliaMotor.Rows)
                {
                    noFamiliaMotor = new TreeNode(linhaFamMotor["id_fam_motor_real"].ToString());
                    noKitGrupoPeca = this.CriaNoKitGrupoPeca(Convert.ToInt32(linhaFamMotor["id_kit"]));
                    noFamiliaMotor.Nodes.Add(noKitGrupoPeca);
                }
                return noFamiliaMotor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraFamiliaMotor = null;
                noFamiliaMotor = null;
                noKitGrupoPeca = null;
                if (dtFamiliaMotor != null)
                {
                    dtFamiliaMotor.Dispose();
                    dtFamiliaMotor = null;
                }
            }
        }

        private TreeNode CriaNoKitGrupoPeca(int idKitGrupoPeca)
        {
            DataTable dtKitGrupoPeca = null;
            TreeNode noKitGrupoPeca = null, noItem = null;
            rKitGrupoPeca regraKitGrupoPeca = new rKitGrupoPeca();
            try
            {
                dtKitGrupoPeca = regraKitGrupoPeca.BuscaKitGrupoPecaTree(idKitGrupoPeca);
                foreach (DataRow linha in dtKitGrupoPeca.Rows)
                {
                    noKitGrupoPeca = new TreeNode(linha["id_kit_real"].ToString());
                    noItem = this.CriaNoItemKit(Convert.ToInt32(linha["id_kit"]));
                    noKitGrupoPeca.Nodes.Add(noItem);
                }
                return noKitGrupoPeca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraKitGrupoPeca = null;
                noKitGrupoPeca = null;
                noItem = null;
                if (dtKitGrupoPeca != null)
                {
                    dtKitGrupoPeca.Dispose();
                    dtKitGrupoPeca = null;
                }
            }
        }

        private TreeNode CriaNoItemKit(int idKit)
        {
            DataTable dtItem = null;
            TreeNode noItem = null, noPeca = null;
            rItemKit regraItem = new rItemKit();
            try
            {
                dtItem = regraItem.BuscaItemKitTree(idKit);
                foreach (DataRow linha in dtItem.Rows)
                {
                    noItem = new TreeNode(linha["id_item_real"].ToString());
                }
                return noItem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraItem = null;
                noItem = null;
                noPeca = null;
                if (dtItem!= null)
                {
                    dtItem.Dispose();
                    dtItem = null;
                }
            }
        }

        private TreeNode CriaNoPeca(int idItem)
        {
            DataTable dtPeca = null;
            TreeNode noPeca = null;
            rItemPeca regraPeca = new rItemPeca();
            try
            {
                dtPeca = regraPeca.BuscaItemPecaTree(idItem);
                foreach (DataRow linha in dtPeca.Rows)
                {
                    noPeca = new TreeNode(linha["id_peca_real"].ToString());
                }
                return noPeca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraPeca = null;
                noPeca = null;
                if (dtPeca != null)
                {
                    dtPeca.Dispose();
                    dtPeca = null;
                }
            }
        }

    }
}