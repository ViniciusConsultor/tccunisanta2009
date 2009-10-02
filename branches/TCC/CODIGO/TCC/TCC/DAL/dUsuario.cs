using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;


namespace TCC.DAL
{
    class dUsuario : AcessoDados
    {
        public DataTable BuscarUsuario(string Descricao)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(Descricao) == true)
                {
                    return base.BuscaDados("sp_busca_usuario");
                }
                else
                {
                    param = new SqlParameter("@dsc_usuario", Descricao);
                    param.SqlDbType = SqlDbType.VarChar;
                    return base.BuscaDados("sp_busca_usuario", param);
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

        public DataTable VerificaLoginUsuario(string login, string senha)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            try
            {
                parametros[0] = new SqlParameter("@login", login);
                parametros[0].SqlDbType = SqlDbType.VarChar;
                parametros[1] = new SqlParameter("@senha", senha);
                parametros[1].SqlDbType = SqlDbType.VarChar;

                return base.BuscaDados("verifica_loginCorreto", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parametros = null;
            }
        }

        public void DeletaUsuario(int idUsuario)
        {
            SqlParameter param = new SqlParameter("@id_usu", idUsuario);
            param.SqlDbType = SqlDbType.Int;
            try
            {
                base.ExecutaProcedure("sp_deleta_usuario", param);
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
