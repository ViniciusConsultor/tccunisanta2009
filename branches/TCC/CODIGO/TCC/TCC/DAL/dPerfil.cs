using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;

namespace TCC.DAL
{
    class dPerfil : AcessoDados
    {
        public void CadastraPerfil(mPerfil model)
        {
            ModelAuxiliar mod;
            SqlParameter[] parametros;
            try
            {
                mod = new ModelAuxiliar(model.GetType(), model);
                parametros = mod.BuscaNomeParametros();
                base.ExecutaProcedure("sp_insert_perfil", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mod = null;
                parametros = null;
            }

        }

        public DataTable BuscaIdMaximoPerfil()
        {
            try
            {
                return base.BuscaDados("sp_busca_maxPerfil");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscaPerfil(string Descricao)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(Descricao) == true)
                {
                    return base.BuscaDados("sp_busca_Perfil");
                }
                else
                {
                    param = new SqlParameter("@dsc_perfil", Descricao);
                    param.SqlDbType = SqlDbType.VarChar;
                    return base.BuscaDados("sp_busca_perfil_param", param);
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
    }
}