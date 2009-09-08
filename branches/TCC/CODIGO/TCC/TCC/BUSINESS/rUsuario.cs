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
        #region Cadastra Usuario
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
        #endregion Cadastra Usuario

        #region Busca Id Maximo Usuario
        public int BuscaIdMaximoUsuario()
        {
            dUsuario dalUsu = new dUsuario();
            DataTable dt;
            int idUsuario;
            try
            {
                dt = dalUsu.BuscaIdMaximoUsuario();
                if (dt.Rows[0]["id_usu"] == DBNull.Value || dt.Rows[0]["id_usu"] == null)
                {
                    idUsuario = 0;
                }
                else
                {
                    idUsuario = Convert.ToInt32(dt.Rows[0]["id_usu"]);
                }
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
        public DataTable BuscaUsuario(string Descricao)
        {
            dUsuario dal = new dUsuario();
            try
            {
                return dal.BuscarUsuario(Descricao);
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
        #endregion Busca Id Maximo Usuario

        public DataTable VerificaLoginUsuario(string login, string senha)
        {
            dUsuario dal = new dUsuario();
            try
            {
                return dal.VerificaLoginUsuario(login, senha);
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
    }
}
