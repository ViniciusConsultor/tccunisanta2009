using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmInicial : Form
    {
        #region Atributos
        private int childFormNumber = 0;
        /// <summary>
        /// Dicionario de eventos da Classe inicial.
        /// </summary>
        private Dictionary<string, object> _dicEventos = new Dictionary<string, object>();
        private const string _NAMESPACEFORMS = "TCC.UI.";
        public static List<string> listaTelasAbertas = new List<string>();
        int qtdDeslogar;
        #endregion Atributos

        #region Propriedades
        public static int _idPerfil;

        public static int IdPerfil
        {
            get { return _idPerfil; }
            set { _idPerfil = value; }
        } 
        #endregion Propriedades

        #region Construtor
        public frmInicial()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region Form Load
        private void frmInicial_Load(object sender, EventArgs e)
        {
            this.CriaItemDeslogar();
            this.CarregaMenu(frmInicial._idPerfil);
        }
        #endregion Form Load

        void frmInicial_Click(object sender, EventArgs e)
        {
            string endereco = this._dicEventos[sender.ToString()].ToString();
            if (listaTelasAbertas.Contains(endereco) == false)
            {
                Assembly ass = Assembly.GetExecutingAssembly();
                if (this._dicEventos.ContainsKey(sender.ToString()) == true)
                {
                    Form objFormDinamico = (Form)ass.CreateInstance(_NAMESPACEFORMS + endereco);
                    if (objFormDinamico != null)
                    {
                        listaTelasAbertas.Add(endereco);
                        if (sender.ToString().Equals("LOGIN") == true)
                        {

                            objFormDinamico.ShowDialog();
                            this.CarregaMenu(frmInicial.IdPerfil);
                        }
                        else
                        {

                            objFormDinamico.MdiParent = this;
                            objFormDinamico.Show();
                        }
                    }
                    }
            }
            else
            {
                MessageBox.Show("Já Existe uma tela "+sender.ToString()+" aberta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        #region newToolStripButton Click
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        #endregion newToolStripButton Click

        #region openToolStripButton Click
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        #endregion openToolStripButton Click

        #region SaveAsToolStripMenuItem Click
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        #endregion SaveAsToolStripMenuItem Click

        #region ExitToolsStripMenuItem Click
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion ExitToolsStripMenuItem Click

        #region CutToolStripMenuItem Click
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion CutToolStripMenuItem Click

        #region CopyToolStripMenuItem Click
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion CopyToolStripMenuItem Click

        #region PasteToolStripMenuItem Click
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion PasteToolStripMenuItem Click

        #region CascadeToolStripMenuItem Click
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        #endregion CascadeToolStripMenuItem Click

        #region TileVerticalToolStripMenuItem Click
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion TileVerticalToolStripMenuItem Click

        #region TileHorizontalToolStripMenuItem Click
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        #endregion TileHorizontalToolStripMenuItem Click

        #region ArrangeIconsToolStripMenuItem Click
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        #endregion ArrangeIconsToolStripMenuItem Click

        #region CloseAllToolStripMenuItem Click
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion CloseAllToolStripMenuItem Click
        #endregion Eventos

        #region Metodos

        #region Carrega Menu
        /// <summary>
        /// Carrega e popula o menu do form
        /// </summary>
        private void CarregaMenu(int idPerfil)
        {
            //Instanciando os objetos
            //-----------------------
            rMenu regraMenu = new rMenu();
            //Declarando DataTables onde serão armazenados os itens de Menu e os SubMenus
            //---------------------------------------------------------------------------
            DataTable dtMenu;
            //Array para armazenar os itens do menu
            //-------------------------------------
            ToolStripMenuItem[] itemMenuP;
            try
            {
                this.ApagaMenu();
                //Busca e carrega o DataTable com os Menus Relacionados a um Perfil
                //-----------------------------------------------------------------
                dtMenu = regraMenu.BuscaMenu(idPerfil);
                //Declara o tamanho do Array baseado no tamanho do DataTable com os menus
                //-----------------------------------------------------------------------
                itemMenuP = new ToolStripMenuItem[dtMenu.Rows.Count + 1];
                for (int contador = 0; contador < dtMenu.Rows.Count; contador++)
                {
                    itemMenuP[contador] = new ToolStripMenuItem(dtMenu.Rows[contador]["Menu"].ToString());
                    this.mnuPrincipal.Items.AddRange(new ToolStripMenuItem[] { itemMenuP[contador] });

                    if (dtMenu.Rows[contador]["ende"] != DBNull.Value)
                    {

                        itemMenuP[contador].Click += new EventHandler(frmInicial_Click);
                        _dicEventos.Add(dtMenu.Rows[contador]["Menu"].ToString(), dtMenu.Rows[contador]["ende"]);
                    }

                    //Caso exista adicionas os menus na coleção e adiciona a chamada dos eventos
                    //--------------------------------------------------------------------------
                    this.PreencheSubMenu(itemMenuP[contador], dtMenu.Rows[contador]);
                
                    
                }
                this.mnuPrincipal.Items.AddRange(new ToolStripMenuItem[] { this.deslogarToolStripMenuItem });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                regraMenu = null;
                itemMenuP = null;
                dtMenu = null;
            }
        }

        #endregion Carrega Menu

        private void PreencheSubMenu(ToolStripMenuItem itemMenuPai, DataRow drLinha)
        {
            rMenu regraSubMenu;
            DataTable dtSubMenu;
            ToolStripMenuItem itemSubMenu;
            int idMenu;
            try
            {
                regraSubMenu = new rMenu();
                idMenu = Convert.ToInt32(drLinha["id_menu"]);
                dtSubMenu = regraSubMenu.BuscaSubMenu(idMenu);
                if (dtSubMenu.Rows.Count > 0)
                {
                    for (int i = 0; i < dtSubMenu.Rows.Count; i++)
                    {
                        itemSubMenu = new ToolStripMenuItem(dtSubMenu.Rows[i]["dsc_menu"].ToString());
                        itemMenuPai.DropDownItems.AddRange(new ToolStripMenuItem[] { itemSubMenu });

                        if (dtSubMenu.Rows[i]["ende"] != DBNull.Value)
                        {
                            itemMenuPai.DropDownItems[i].Click += new EventHandler(frmInicial_Click);
                            _dicEventos.Add(dtSubMenu.Rows[i]["dsc_menu"].ToString(), dtSubMenu.Rows[i]["ende"]);
                        }

                        this.PreencheSubMenu(itemSubMenu, dtSubMenu.Rows[i]) ;
                    }
                }
                else
                {
                    /*//Caso não exista apenas adiciona o evento ao controle
                    //----------------------------------------------------
                    itemMenuPai.DropDownItems.Add(drLinha["dsc_menu"].ToString());
                    itemMenuPai.Click += new EventHandler(frmInicial_Click);
                    _dicEventos.Add(drLinha["dsc_menu"].ToString(), drLinha["ende"]);*/
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        #region Apaga Menu
        private void ApagaMenu()
        {
            if (this.mnuPrincipal.Items.Count > 0)
            {
                this.mnuPrincipal.Items.Clear();
                if (this._dicEventos.Count > 0)
                {
                    this._dicEventos.Clear();
                }
            }
        }
        #endregion Apaga Menu

        private void frmInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.Retry)
            {
                DAL.ConectaBanco.DesconectaBanco();
                GC.Collect();
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void CriaItemDeslogar()
        {
            // 
            // deslogarToolStripMenuItem
            // 
            this.deslogarToolStripMenuItem.Name = "deslogarToolStripMenuItem";
            this.deslogarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.deslogarToolStripMenuItem.Text = "Deslogar";
            this.deslogarToolStripMenuItem.Click += new System.EventHandler(this.deslogarToolStripMenuItem_Click);
        }

        #endregion Metodos

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (qtdDeslogar <= 0)
            {
                DialogResult resultado = MessageBox.Show("Deseja Realmente deslogar do sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                if (resultado == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Retry;
                    qtdDeslogar++;
                }
                else
                {
                    qtdDeslogar++;
                }
            }
            else
            {
                qtdDeslogar = 0;
            }
        }
    }
}