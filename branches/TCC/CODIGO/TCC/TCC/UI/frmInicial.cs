using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

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
        #endregion Atributos

        #region Propriedades
        public static int _idPerfil = 1;

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
            this.CarregaMenu(frmInicial._idPerfil);
        }
        #endregion Form Load

        void frmInicial_Click(object sender, EventArgs e)
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            if (this._dicEventos.ContainsKey(sender.ToString()) == true)
            {
                Form objFormDinamico = (Form)ass.CreateInstance(_NAMESPACEFORMS + this._dicEventos[sender.ToString()]);
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
            BUSINESS.rMenu regraMenu = new TCC.BUSINESS.rMenu();
            BUSINESS.rSubMenu regraSubMenu = new TCC.BUSINESS.rSubMenu();
            //Declarando DataTables onde serão armazenados os itens de Menu e os SubMenus
            //---------------------------------------------------------------------------
            DataTable dtMenu;
            DataTable dtSubMenu;
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
                itemMenuP = new ToolStripMenuItem[dtMenu.Rows.Count];
                for (int contador = 0; contador < dtMenu.Rows.Count; contador++)
                {
                    itemMenuP[contador] = new ToolStripMenuItem(dtMenu.Rows[contador]["Descrição do menu"].ToString());
                    dtSubMenu = regraSubMenu.BuscaSubMenu(Convert.ToInt32(dtMenu.Rows[contador]["id_menu"]), frmInicial._idPerfil);
                    this.mnuPrincipal.Items.AddRange(new ToolStripMenuItem[] { itemMenuP[contador] });
                    //Verifica se existem SubMenus para aquele menu
                    //---------------------------------------------
                    if (dtSubMenu.Rows.Count > 0)
                    {
                        //Caso exista adicionas os menus na coleção e adiciona a chamada dos eventos
                        //--------------------------------------------------------------------------
                        for (int i = 0; i < dtSubMenu.Rows.Count; i++)
                        {
                            itemMenuP[contador].DropDownItems.Add(dtSubMenu.Rows[i]["Descrição submenu"].ToString());
                            itemMenuP[contador].DropDownItems[i].Click += new EventHandler(frmInicial_Click);
                            _dicEventos.Add(dtSubMenu.Rows[i]["Descrição submenu"].ToString(), dtSubMenu.Rows[i]["Endereço submenu"]);
                        }
                    }
                    else
                    {
                        //Caso não exista apenas adiciona o evento ao controle
                        //----------------------------------------------------
                        this.mnuPrincipal.Items[contador].Click +=new EventHandler(frmInicial_Click);
                        _dicEventos.Add(dtMenu.Rows[contador]["Descrição do menu"].ToString(), dtMenu.Rows[contador]["Endereço do menu"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                regraMenu = null;
                regraSubMenu = null;
                itemMenuP = null;
                dtMenu = null;
                dtSubMenu = null;
            }
        }

        #endregion Carrega Menu

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

        #endregion Metodos
    }
}