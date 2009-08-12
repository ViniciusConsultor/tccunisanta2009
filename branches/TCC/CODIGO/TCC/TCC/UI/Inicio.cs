using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace TCC.UI
{
    public partial class Inicio : Form
    {
        #region Atributos
        Dictionary<string, object> dicEventos = new Dictionary<string, object>();
        #endregion Atributos

        #region Construtor
        public Inicio()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region Form Load
        private void Inicio_Load(object sender, EventArgs e)
        {
            this.AbreConexaoBanco();
            this.CarregaMenuDefault();
        }
        #endregion Form Load

        #region Inicio Click
        void Inicio_Click(object sender, EventArgs e)
        {
            if (this.dicEventos[sender.ToString()].Equals(sender.ToString()) == true)
            {
                //chamar a classe que esta no banco de dados

            }
        }

        #endregion

        #endregion

        #region Metodos

        #region Abre Conexao Banco
        /// <summary>
        /// Abre a conexão com o banco de dados
        /// </summary>
        private void AbreConexaoBanco()
        {
            DAL.AcessoDados dal = new DAL.AcessoDados();
            if (dal.ConectaBanco() == false)
            {
                MessageBox.Show("Erro ao conectar ao abrir a conexão com banco de dados", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion Abre Conexao Banco

        #region Carrega Menu Default
        /// <summary>
        /// Carrega e popula o menu do form
        /// </summary>
        private void CarregaMenuDefault()
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
                //Busca e carrega o DataTable com os Menus
                //----------------------------------------
                dtMenu = regraMenu.BuscaMenuDefault();
                //Declara o tamanhdo do Array
                //---------------------------
                itemMenuP = new ToolStripMenuItem[dtMenu.Rows.Count];
                for (int contador = 0; contador < dtMenu.Rows.Count; contador++)
                {
                    itemMenuP[contador] = new ToolStripMenuItem(dtMenu.Rows[contador]["dsc_menu"].ToString());
                    dtSubMenu = regraSubMenu.BuscaSubMenuDefault(Convert.ToInt32(dtMenu.Rows[contador]["id_menu"]));
                    this.mnuPrincipal.Items.AddRange(new ToolStripMenuItem[] { itemMenuP[contador] });
                    //Verifica se existem SubMenus para aquele menu
                    //---------------------------------------------
                    if (dtSubMenu.Rows.Count > 0)
                    {
                        //Caso exista adicionas os menus na coleção e adiciona a chamada dos eventos
                        //--------------------------------------------------------------------------
                        for (int i = 0; i < dtSubMenu.Rows.Count; i++)
                        {
                            itemMenuP[contador].DropDownItems.Add(dtSubMenu.Rows[i]["dsc_sub"].ToString());
                            itemMenuP[contador].DropDownItems[i].Click += new EventHandler(Inicio_Click);
                            dicEventos.Add(dtSubMenu.Rows[i]["dsc_sub"].ToString(), dtSubMenu.Rows[i]["end_sub"]);
                        }
                    }
                    else
                    {
                        //Caso não exista apenas adiciona o evento ao controle
                        //----------------------------------------------------
                        this.mnuPrincipal.Items[contador].Click += new EventHandler(Inicio_Click);
                        dicEventos.Add(dtMenu.Rows[contador]["dsc_menu"].ToString(), dtMenu.Rows[contador]["end_menu"]);
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
        #endregion Carrega Menu Default


        #endregion Metodos

        public void abreTela()
        {

            frmCadUsuario usuario = new frmCadUsuario();
            usuario.ShowDialog();


           
            
        
        }
    }
}