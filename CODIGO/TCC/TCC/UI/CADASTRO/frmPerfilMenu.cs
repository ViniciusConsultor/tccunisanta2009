using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;


namespace TCC.UI.CADASTRO
{
    public partial class frmPerfilMenu : Form
    {
        #region Atributos
        mPerfil _modelPerfil;
        List<mPerfilMenu> _listaModelPerfilMenu;
        int? _idPerfil;
        #endregion Atributos
        
        #region Construtores
        public frmPerfilMenu(int? idPerfil, string nomePerfil)
        {
            InitializeComponent();

            _idPerfil = idPerfil;
            txtPerfil.Text = nomePerfil;

            txtPerfil.Enabled = false;
            btnBuscarMenuDtGrid.Enabled = false;
        }

        public frmPerfilMenu()
        {
            InitializeComponent();
        }
        #endregion Construtores

        #region Eventos

        private void btnBuscarMenuDtGrid_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
            this._modelPerfil = new mPerfil();
            frmBuscaPerfil objForm = new frmBuscaPerfil(this._modelPerfil);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelPerfil = null;
                }
                else
                {
                    this.txtPerfil.Text = this._modelPerfil.DescPerfil;
                    this._idPerfil = this._modelPerfil.IdPerfil;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objForm = null;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscaAlteracaoDelecao_Click(object sender, EventArgs e)
        {

        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Metodos

        #region Popula Grid
        private void PopulaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = this.BuscaMenu(this.txtMenu.Text);
                this.dgMenu.DataSource = dtSource;
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
        #endregion Popula Grid

        #region Busca Menu
        /// <summary>
        /// Busca Menu atraves do filtro escolhido pelo usuario
        /// </summary>
        /// <param name="menu">o filtro passado pelo usuário pode ser Vazio</param>
        /// <returns>DataTable com o resultado da query</returns>
        private DataTable BuscaMenu(string menu)
        {
            rMenu regraMenu = new rMenu();
            try
            {
                return regraMenu.TelaBuscaMenu(menu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraMenu = null;
            }
        }
        #endregion Busca Menu

        #region Popula Lista Model
        private void PopulaListaModel()
        {
            DataGridViewCell dvC = null;
            DataTable dtSource = new DataTable();
            mPerfilMenu modelPerfilMenu;
            try
            {
                dtSource = (DataTable)this.dgMenu.DataSource;
                if (this.dgMenu.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgMenu.CurrentRow != null)
                        {
                            //Varre o DataGrid linha por linha
                            //--------------------------------
                            foreach (DataGridViewRow linha in this.dgMenu.Rows)
                            {
                                //Verifica se a linha é nula
                                //--------------------------
                                if (linha.Cells[0].Value != null)
                                {
                                    //Converte o valor para Boolean e verifica se está checado
                                    //--------------------------------------------------------
                                    if (Convert.ToBoolean(linha.Cells[0].Value) != false)
                                    {
                                        modelPerfilMenu = new mPerfilMenu();

                                        //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                                        //------------------------------------------------------------------------------------
                                        //Pega id Menu
                                        dvC = linha.Cells[1];
                                        modelPerfilMenu.IdMenu = Convert.ToInt32(dvC.Value);
                                        //Pega id Perfil
                                        modelPerfilMenu.IdPerfil = this._idPerfil;
                                        modelPerfilMenu.DatTrans = DateTime.Now;
                                        modelPerfilMenu.FlgAtivo = true;

                                        //Atribui o model à lista de models
                                        if (this._listaModelPerfilMenu == null)
                                        {
                                            this._listaModelPerfilMenu = new List<mPerfilMenu>();
                                        }
                                        else
                                        {
                                            this._listaModelPerfilMenu.Add(modelPerfilMenu);
                                        }
                                    }
                                }
                            }
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
                        MessageBox.Show("É necessário Cadastrar um Menu", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Perfil", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
        #endregion Popula Lista Model

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados que não podem ser nulos na tela
        /// </summary>
        private void ValidaDadosNulos()
        {
            if (this._listaModelPerfilMenu == null)
            {
                throw new BUSINESS.Exceptions.PerfilMenu.MenuNaoEscolhidoException();
            }
            else if (this._modelPerfil == null)
            {
                throw new BUSINESS.Exceptions.PerfilMenu.PerfilVazioException();
            }
        }
        #endregion Valida Dados Nulos

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere()
        {
            rPerfilMenu regra = new rPerfilMenu();

            try
            {
                this.PopulaListaModel();
                this.ValidaDadosNulos();
                foreach (mPerfilMenu modelPerfilMenu in this._listaModelPerfilMenu)
                {
                    regra.ValidarInsere(modelPerfilMenu);
                }
                this.btnLimpa_Click(null, null);
                this.btnConfirma.Enabled = false;
            }
            catch (BUSINESS.Exceptions.PerfilMenu.PerfilVazioException)
            {
                MessageBox.Show("É necessário buscar um Perfil", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarPerfil.Focus();
            }
            catch (BUSINESS.Exceptions.PerfilMenu.MenuNaoEscolhidoException)
            {
                MessageBox.Show("É necessário selecionar ao menos um menu", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarMenuDtGrid.Focus();
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
        #endregion Insere

        #endregion Metodos
    }
}
