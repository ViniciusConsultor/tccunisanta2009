﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace TCC.BUSINESS
{
    class rCompra : ComandosSql
    {
        public DataTable BuscaCompra(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_compra");
                }
                else
                {
                    param = new SqlParameter("@obs", parametro);
                    return base.BuscaDados("sp_busca_compra_param", param);
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

        public string BuscaIdMaximoCompra()
        {
            try
            {
                return base.BuscaIdMaximoTabelas("id_compra", "compra");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void ValidarInsere(TCC.MODEL.ModelPai model)
        {
            base.Insere(model);
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