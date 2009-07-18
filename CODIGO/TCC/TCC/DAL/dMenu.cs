using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TCC.DAL
{
    class dMenu : AcessoDados
    {
        /// <summary>
        /// Busca o menu de um usuario default(deslogado).
        /// </summary>
        /// <returns>DataTable com o menu de um usuario default</returns>
        public DataTable BuscaMenuDefault()
        {
            StringBuilder query = new StringBuilder();
            try
            {
                //TODO: Passar essa query para um procedure.
                //------------------------------------------
                query.Append(" SELECT m.id_menu, m.dsc_menu ");
                query.Append(" FROM Menu m");
                query.Append(" INNER JOIN PerfilMenu pm ");
                query.Append(" ON m.id_menu = pm.id_menu ");
                query.Append(" INNER JOIN Perfil p ");
                query.Append(" ON pm.id_perfil = p.id_perfil ");
                query.Append(" WHERE pm.id_perfil = 1 ");

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
    }
}

