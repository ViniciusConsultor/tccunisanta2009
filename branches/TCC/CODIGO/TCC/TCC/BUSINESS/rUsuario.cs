using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rUsuario
    {
        public void CadastraUsuario(mUsuario model)
        {
            dUsuario dalUsuario = new dUsuario();
            try
            {
                dalUsuario.CadastraUsuario(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dalUsuario = null;
            }
        }

        public int BuscaIdMaximoUsuario()
        {
            dUsuario dalUsu = new dUsuario();
            DataTable dt;
            int idUsuario;
            try
            {
                dt = dalUsu.BuscaIdMaximoUsuario();
                idUsuario = Convert.ToInt32(dt.Rows[0]["id_usu"]);
                return ++idUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dalUsu = null;
                dt = null;
            }
        }
    }
}
