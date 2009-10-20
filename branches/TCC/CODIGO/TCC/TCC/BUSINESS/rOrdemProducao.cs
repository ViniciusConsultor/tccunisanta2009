﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace TCC.BUSINESS
{
    class rOrdemProducao : ComandosSql
    {
        public DataTable BuscaOrdemProducao(string ParametroBusca)
        {
            SqlParameter param = new SqlParameter();
            try
            {
                if (string.IsNullOrEmpty(ParametroBusca) == true)
                {
                    return base.BuscaDados("sp_busca_ordemProducao");
                }
                else
                {
                    param = new SqlParameter("@dsc_ordem", ParametroBusca);
                    return base.BuscaDados("sp_busca_ordemProducao_param", param);
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

        public string BuscaIdMaximo()
        {
            try
            {
                return base.BuscaIdMaximoTabelas("id_ordem", "Ordemproducao");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void ValidarInsere(TCC.MODEL.ModelPai model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarDeleta(TCC.MODEL.ModelPai model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarAltera(TCC.MODEL.ModelPai model)
        {
            throw new NotImplementedException();
        }
    }
}
