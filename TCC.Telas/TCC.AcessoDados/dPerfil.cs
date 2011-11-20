﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TCC.AcessoDados
{
    public class dPerfil : AcessoDados
    {
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