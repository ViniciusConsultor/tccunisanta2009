using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace TCC.DAL
{
    class dMenu : AcessoDados
    {
        /// <summary>
        /// Busca o menu de um usuario default(deslogado).
        /// </summary>
        /// <returns>DataTable com o menu de um usuario default</returns>
        public DataTable BuscaMenu(int idPerfil)
        {
            SqlParameter param;
            try
            {
                param = new SqlParameter("@id_perfil", idPerfil);
                param.SqlDbType = SqlDbType.Int;
                return base.BuscaDados("sp_busca_menu", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
            }
        }

        public DataTable TelaBuscaMenu(string Descricao)
        {
            SqlParameter param;
            try
            {
                if (string.IsNullOrEmpty(Descricao) == true)
                {
                    return base.BuscaDados("sp_busca_todosMenus");
                }
                else
                {
                    param = new SqlParameter("@param", Descricao);
                    return base.BuscaDados("sp_busca_menu", param);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
            }
        }

        /// <summary>
        /// Busca os submenus de um menu pai.
        /// </summary>
        /// <returns>DataTable com os menus</returns>
        public DataTable BuscaSubMenu(int idMenuPai)
        {
            SqlParameter param;
            try
            {
                param = new SqlParameter("@id_menu_pai", idMenuPai);
                param.SqlDbType = SqlDbType.Int;
                return base.BuscaDados("sp_busca_submenu", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
            }
        }
    }
}

