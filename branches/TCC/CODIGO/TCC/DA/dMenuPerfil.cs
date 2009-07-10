using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Text;
using System.Web.UI.WebControls.WebParts;

namespace TCC.DA
{
    public class dMenuPerfil : AcessoDados
    {
        #region Busca Menu Usuario Deslogado
        /// <summary>
        /// Busca o Menu de um usuario Deslogado.
        /// </summary>
        /// <returns>DataTable com o menu de um usuario deslogado</returns>
        public DataTable BuscaMenuUsuarioDeslogado()
        {
            StringBuilder query = new StringBuilder();
            try
            {
                query.Append(" SELECT dsc_menu ");
                query.Append(" FROM Menu m ");
                query.Append(" INNER JOIN MenuPerfil mp ");
                query.Append(" ON m.id_menu = mp.id_menu ");
                query.Append(" INNER JOIN Perfil p ");
                query.Append(" ON mp.id_perfil = p.id_perfil ");
                query.Append(" WHERE id_perfil = 0 ");

                return base.ExecuteSql(query.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                query = null;
            }
        }
        #endregion Busca Menu Usuario Deslogado
    }
}
