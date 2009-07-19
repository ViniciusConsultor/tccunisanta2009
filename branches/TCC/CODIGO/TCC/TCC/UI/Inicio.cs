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
            ToolStripMenuItem[] itemMenuP;
            try
            {
                dtMenu = regraMenu.BuscaMenuDefault();
                itemMenuP= new ToolStripMenuItem[dtMenu.Rows.Count];
                for (int contador = 0; contador < dtMenu.Rows.Count; contador++)
                {
                    itemMenuP[contador] = new ToolStripMenuItem(dtMenu.Rows[contador]["dsc_menu"].ToString());
                    dtSubMenu = regraSubMenu.BuscaSubMenuDefault(Convert.ToInt32(dtMenu.Rows[contador]["id_menu"]));
                    foreach (DataRow linha in dtSubMenu.Rows)
                    {
                        itemMenuP[contador].DropDownItems.Add(linha["dsc_sub"].ToString());
                    }
                    //TODO: Descobrir como inserir items dentro de item.
                    //--------------------------------------------------
                    this.mnuPrincipal.Items.AddRange(new ToolStripMenuItem[] { itemMenuP[contador] });
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
                regraSubMenu = null;
                dtSubMenu = null;
                itemMenuP = null;
            }
        }
    }
}
