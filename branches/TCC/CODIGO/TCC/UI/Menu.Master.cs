using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        #region Eventos

        #region Form Load
        protected void Page_Load(object sender, EventArgs e)
        {
            //Abre a Conexão com o banco de dados.
            //------------------------------------
            DA.AcessoDados dal = new DA.AcessoDados();
            //Se a o metodo retornar falso
            //----------------------------
            if (dal.ConectaBanco() == false)
            {
                //Exibe Mensagem de erro
                //----------------------
                //TODO: não sei exibir mensagem de erro em Web
                //--------------------------------------------
                //"Falha ao conectar com o Banco de Dados."
            }
            else
            {
                this.CarregaMenuDefault();
            }
        }
        #endregion Form Load

        #endregion Eventos

        #region Metodos

        #region Carrega Menu Default
        /// <summary>
        /// Carrega os menus padronizados para um usuario deslogado.
        /// </summary>
        private void CarregaMenuDefault()
        {
            rMenuPerfil regraMenuP = new rMenuPerfil();
            DataTable dt = new DataTable();
            MenuItem itemMenu = null;
            try
            {
                //Busca o Menu de um usuario deslogado.
                //-------------------------------------
                dt = regraMenuP.BuscaMenuUsuarioDeslogado();
                //Para cada linha que o DataTable tiver eu adiciono no menu.
                //----------------------------------------------------------
                foreach (DataRow linha in dt.Rows)
                {
                    itemMenu = new MenuItem(linha["dsc_menu"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraMenuP = null;
                dt.Dispose();
                dt = null;
                itemMenu = null;
            }
        }
        #endregion Carrega Menu Default 

        #endregion Metodos
    }
}
