using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
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
        public frmResumoOrdemProducao(int? idVenda)
        {
            InitializeComponent();
            _idVenda = (int)idVenda;
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
            this.CriaArquivoOrdermProducao();
        }
        #endregion btnGerarArquivo Click

        #region Form Load
        private void frmResumoOrdemProducao_Load(object sender, EventArgs e)
        {
            this.CriaNosTreeView();
        }
        #endregion Form Load 
        #endregion Eventos

        #region Metodos

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

        #region Cria No Produto
        private void CriaNoProduto(int idProduto)
        {
            rProduto regraProduto = new rProduto();
            TreeNode noProduto = null;
            TreeNode noFamiliaMotor = null;
            TreeNode noKit = null;
            DataTable dtProduto = null;
            try
            {
                int qtdeProduto = 0;
                dtProduto = regraProduto.BuscaProdutosVenda(idProduto, this._idVenda);
                foreach (DataRow linha in dtProduto.Rows)
                {
                    noProduto = new TreeNode("Produto: " + linha["dsc_prdto"].ToString() + " | Qtde: " + linha["qtd"].ToString());
                    qtdeProduto = Convert.ToInt32(linha["qtd"]);

                    if (linha["id_fam_motor"] != DBNull.Value)
                    {
                        noFamiliaMotor = this.CriaNoFamiliaMotor(Convert.ToInt32(linha["id_fam_motor"]),qtdeProduto);
                        noProduto.Nodes.Add(noFamiliaMotor);
                    }
                    else if (linha["id_kit"] != DBNull.Value)
                    {
                        noKit = this.CriaNoKitGrupoPeca(Convert.ToInt32(linha["id_kit"]), qtdeProduto);
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
        #endregion Cria No Produto

        #region Cria No Familia Motor
        private TreeNode CriaNoFamiliaMotor(int idFamiliaMotor, int qtdeProduto)
        {
            DataTable dtFamiliaMotor = null;
            TreeNode noFamiliaMotor = null, noKitGrupoPeca = null;
            rFamiliaMotor regraFamiliaMotor = new rFamiliaMotor();
            try
            {
                int qtde = 0;
                dtFamiliaMotor = regraFamiliaMotor.BuscaFamiliaMotorTree(idFamiliaMotor);
                foreach (DataRow linhaFamMotor in dtFamiliaMotor.Rows)
                {
                    noFamiliaMotor = new TreeNode(linhaFamMotor["id_fam_motor_real"].ToString());
                    qtde = Convert.ToInt32(linhaFamMotor["qtd_kit"]) * qtdeProduto;
                    noKitGrupoPeca = this.CriaNoKitGrupoPeca(Convert.ToInt32(linhaFamMotor["id_kit"]), qtde);
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
        #endregion Cria No Familia Motor

        #region Cria No Kit Grupo Peca
        private TreeNode CriaNoKitGrupoPeca(int idKitGrupoPeca, int qtdeProduto)
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
                    noItem = this.CriaNoItemKit(Convert.ToInt32(linha["id_kit"]), qtdeProduto);
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
        #endregion Cria No Kit Grupo Peca

        #region Cria No Item Kit
        private TreeNode CriaNoItemKit(int idKit, int qtdeKit)
        {
            DataTable dtItem = null;
            TreeNode noItem = null, noPeca = null;
            rItemKit regraItem = new rItemKit();
            try
            {
                int qtde = 0;
                dtItem = regraItem.BuscaItemKitTree(idKit);
                foreach (DataRow linha in dtItem.Rows)
                {
                    qtde = Convert.ToInt32(linha["qtd_item"]) * qtdeKit;
                    noItem = new TreeNode("Item: " + linha["id_item_real"].ToString() + " | Qtde: " + qtde);
                    noPeca = this.CriaNoPeca( Convert.ToInt32(linha["id_item"]), qtde);
                    noItem.Nodes.Add(noPeca);
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
                noPeca = null;
                if (dtItem!= null)
                {
                    dtItem.Dispose();
                    dtItem = null;
                }
            }
        }
        #endregion Cria No Item Kit

        #region Cria No Peca
        private TreeNode CriaNoPeca(int idItem, int qtdItem)
        {
            DataTable dtPeca = null;
            TreeNode noPeca = null;
            rItemPeca regraPeca = new rItemPeca();
            try
            {
                int qtde = 0;
                dtPeca = regraPeca.BuscaItemPecaTree(idItem);
                foreach (DataRow linha in dtPeca.Rows)
                {
                    qtde = Convert.ToInt32(linha["qtd_peca"]) * qtdItem;
                    noPeca = new TreeNode("Peça: " + linha["id_peca_real"].ToString() + " | Qtde: " + qtde);
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
        #endregion Cria No Peca

        #region Cria Arquivo Ordem Producao
        /// <summary>
        /// Este método varre 4 niveis do treeView escrevendo no arquivo o conteúdo Text do nó.
        /// </summary>
        private void CriaArquivoOrdermProducao()
        {
            StreamWriter sw = null;
            const string TAB1 = "     ";
            const string TAB2 = "          ";
            const string TAB3 = "               ";
            const string TAB4 = "                    ";
            try
            {
                string pasta = ConfigurationManager.AppSettings.Get("ordemProducao");
                string nomeArquivo = pasta + "OP_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                sw = new StreamWriter(nomeArquivo);
                foreach (TreeNode no in tvOrdemProducao.Nodes)
                {
                    if (no.Level == 0)
                    {
                        sw.WriteLine(no.Text);
                        foreach (TreeNode no1 in no.Nodes)
                        {
                            if (no1.Level == 1)
                            {
                                sw.WriteLine(TAB1 + no1.Text);
                                foreach (TreeNode no2 in no1.Nodes)
                                {
                                    if (no2.Level == 2)
                                    {
                                        sw.WriteLine(TAB2 + no2.Text);
                                        foreach (TreeNode no3 in no2.Nodes)
                                        {
                                            if (no3.Level == 3)
                                            {
                                                sw.WriteLine(TAB3 + no3.Text);
                                                foreach (TreeNode no4 in no3.Nodes)
                                                {
                                                    if (no4.Level == 4)
                                                    {
                                                        sw.WriteLine(TAB4 +no4.Text);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                sw.Close();
                string mensagem = "Arquivo gerado com sucesso!\r\n Local:" + nomeArquivo;
                MessageBox.Show(mensagem, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Dispose();
                    sw = null;
                }
            }
        }
        #endregion Cria Arquivo Ordem Producao
        
        #endregion Metodos
    }
}