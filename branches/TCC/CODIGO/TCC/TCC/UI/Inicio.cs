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
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.AbreConexaoBanco();
            this.CarregaMenuDefault();
        }

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

        /// <summary>
        /// Carrega e popula o menu do form
        /// </summary>
        private void CarregaMenuDefault()
        {
            BUSINESS.rMenu regraMenu = new TCC.BUSINESS.rMenu();
            BUSINESS.rSubMenu regraSubMenu = new TCC.BUSINESS.rSubMenu();
            DataTable dtMenu;
            DataTable dtSubMenu;
            ToolStripMenuItem itemMenuP;
            try
            {
                dtMenu = regraMenu.BuscaMenuDefault();
                foreach (DataRow linha in dtMenu.Rows)
                {
                    dtSubMenu = regraSubMenu.BuscaSubMenuDefault(Convert.ToInt32(linha["id_menu"]));
                    itemMenuP = new ToolStripMenuItem(linha["dsc_menu"].ToString());
                    foreach (DataRow linhaSubMenu in dtSubMenu.Rows)
                    {

                    }
                    //TODO: Descobrir como inserir items dentro de item.
                    //--------------------------------------------------
                    this.mnuPrincipal.Items.Add(subMenus.Items);
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
                dtMenu = null;
            }
        }
    }
}
