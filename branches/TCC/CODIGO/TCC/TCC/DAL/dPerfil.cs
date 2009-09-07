﻿using System;
using System.Collections.Generic;
using System.Text;
using TCC.MODEL;
using System.Data;
using System.Data.SqlClient;

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
                base.InsereDados("sp_insert_perfil", parametros);
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
                
                throw;
            }
        }
    }
}
