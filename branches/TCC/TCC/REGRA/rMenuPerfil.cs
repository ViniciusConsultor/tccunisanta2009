using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using TCC.DA;

namespace TCC.BUSINESS
{
    public class rMenuPerfil
    {
        #region Busca Menu Usuario Deslogado
        /// <summary>
        /// Busca o Menu de um usuario Deslogado.
        /// </summary>
        /// <returns>DataTable com o menu de um usuario deslogado</returns>
        public DataTable BuscaMenuUsuarioDeslogado()
        {
            dMenuPerfil dal = new dMenuPerfil();
            try
            {
                return dal.BuscaMenuUsuarioDeslogado();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal = null;
            }
        }
        #endregion Busca Menu Usuario Deslogado
    }
}
