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


namespace TCC.UI
{
    public partial class frmPerfilMenu : FormPai
    {
        #region Atributos
        mPerfil _modelPerfil;
        List<mPerfilMenu> _listaModelPerfilMenu;
        
        // indicador de tela
        // True - caso esta tela seja chamada de outra tela
        // False - caso esta tela seja chamada direto do menu
        bool _telaConsulta;

        #endregion Atributos

        #region Construtores
        public frmPerfilMenu(mPerfil modelPerfil)
        {
            InitializeComponent();

            _modelPerfil = modelPerfil;
            txtPerfil.Text = _modelPerfil.DescPerfil;

            txtPerfil.Enabled = false;
            btnBuscarPerfil.Enabled = false;
            _telaConsulta = true;

            this.PopulaGrid();
            
            this.MarcaPerfilMenu(_modelPerfil.IdPerfil);
        }

        public frmPerfilMenu()
        {
            InitializeComponent();
            _telaConsulta = false;
        }
        #endregion Construtores

        #region Eventos
        
        #region frmPerfilMenu_Load
        private void frmPerfilMenu_Load(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }
        #endregion frmPerfilMenu_Load

        #region btnBuscarPerfil_Click
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
                    this.MarcaPerfilMenu(_modelPerfil.IdPerfil);
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
        #endregion

        #region btnConfirma_Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion

        #region btnLimpa_Click
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            if (_telaConsulta == false)
            {
                base.LimpaDadosTela(this);
            }
            else
            {
                DataTable dt = (DataTable)dgMenu.DataSource;
                dt.Rows.Clear();
                dgMenu.DataSource = dt;
                dt = null;
            }

            _modelPerfil = null;
            _listaModelPerfilMenu = null;
            this.PopulaGrid();
            dgMenu.Columns["hIdMenu"].Visible = false;

        }
        #endregion

        private void btnBuscaAlteracaoDelecao_Click(object sender, EventArgs e)
        {
        }

        #region btnVolta_Click
        private void btnVolta_Click(object sender, EventArgs e)
        {
            if (this._telaConsulta == false)
            {
                base.FechaTela(this);
            }
            else
            {
                base.Close();
            }
        }
        #endregion

        #endregion

        #region Metodos

        #region Popula Grid
        private void PopulaGrid()
        {
            DataTable dtSource = null;
            try
            {
                dtSource = this.BuscaMenu("");
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
                                        modelPerfilMenu.IdPerfil = this._modelPerfil.IdPerfil ;
                                        modelPerfilMenu.DatTrans = DateTime.Now;
                                        modelPerfilMenu.FlgAtivo = true;

                                        //Atribui o model à lista de models
                                        if (this._listaModelPerfilMenu == null)
                                        {
                                            this._listaModelPerfilMenu = new List<mPerfilMenu>();
                                            this._listaModelPerfilMenu.Add(modelPerfilMenu);
                                        }
                                        else
                                        {
                                            this._listaModelPerfilMenu.Add(modelPerfilMenu);
                                        }
                                    }
                                }
                            }
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

        #region Valida Lista model
        /// <summary>
        /// Valida os dados que não podem ser nulos na tela
        /// </summary>
        private void ValidaListaModel()
        {
            if (this._listaModelPerfilMenu == null || this._listaModelPerfilMenu.Count<=0)
            {
                throw new BUSINESS.Exceptions.PerfilMenu.MenuNaoEscolhidoException();
            }
        }
        #endregion Valida Lista model

        #region Valida Model
        /// <summary>
        /// Valida os dados que não podem ser nulos na tela
        /// </summary>
        private void ValidaModel()
        {
            if (this._modelPerfil == null)
            {
                throw new BUSINESS.Exceptions.PerfilMenu.PerfilVazioException();
            }
        }
        #endregion Valida Model

        #region Insere
        /// <summary>
        /// Insere os dados que estão no model
        /// </summary>
        private void Insere()
        {
            rPerfilMenu regra = new rPerfilMenu();
            try
            {
                this.ValidaModel();
                this.PopulaListaModel();
                this.ValidaListaModel();

                // Exclui tudo por perfil antes de inserir
                this.DeletaTudoPorPerfil();

                foreach (mPerfilMenu modelPerfilMenu in this._listaModelPerfilMenu)
                {
                    regra.ValidarInsere(modelPerfilMenu);
                }
                this.btnLimpa_Click(null, null);
                MessageBox.Show("Registro salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                if (this._telaConsulta == true)
                {
                    this.DialogResult = DialogResult.OK;
                    base.FechaTela(this);
                }
            }
            catch (BUSINESS.Exceptions.PerfilMenu.PerfilVazioException)
            {
                MessageBox.Show("É necessário buscar um Perfil", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscarPerfil.Focus();
            }
            catch (BUSINESS.Exceptions.PerfilMenu.MenuNaoEscolhidoException)
            {
                MessageBox.Show("É necessário selecionar ao menos um menu", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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

        #region MarcaPerfilMenu
        private void MarcaPerfilMenu(int? idPerfil)
        {
            DataTable dtPerfilMenuTela = null;
            DataTable dtPerfilMenuBanco = null;
            rPerfilMenu regraPerfilMenu = null;

            try
            {
                regraPerfilMenu = new rPerfilMenu();
                int idMenuTela, idMenuBanco;
                dtPerfilMenuBanco = regraPerfilMenu.BuscaPerfilMenu(idPerfil);
                dtPerfilMenuTela = (DataTable)dgMenu.DataSource;
                for (int linhaTela = 0; linhaTela < dtPerfilMenuTela.Rows.Count; linhaTela++)
                {
                    // desmarca este menu para limpar o controle
                    this.dgMenu["hSelecionar", linhaTela].Value = false;
                    idMenuTela = Convert.ToInt32(dtPerfilMenuTela.Rows[linhaTela]["id_menu"]);
                    for (int linhaBanco = 0; linhaBanco < dtPerfilMenuBanco.Rows.Count; linhaBanco++)
                    {
                        idMenuBanco = Convert.ToInt32(dtPerfilMenuBanco.Rows[linhaBanco]["id_menu"]);
                        if (idMenuBanco == idMenuTela)
                        {
                            // marca este menu pois foi localizado no banco
                            this.dgMenu["hSelecionar", linhaTela].Value = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraPerfilMenu = null;
                dtPerfilMenuTela = null;
                dtPerfilMenuBanco = null;
            }
        }
        #endregion MarcaPerfilMenu

        #region DeletaTudoPorPerfil
        private void DeletaTudoPorPerfil()
        {
            rPerfilMenu regraPerfilMenu = null;
            try
            {
                regraPerfilMenu = new rPerfilMenu();
                regraPerfilMenu.DeletaPerfilMenuporPerfil(_modelPerfil.IdPerfil);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraPerfilMenu = null;
            }
        }
        #endregion DeletaTudoPorPerfil

        #endregion Metodos

    }
}
