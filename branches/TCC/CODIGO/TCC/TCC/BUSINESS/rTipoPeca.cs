﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TCC.BUSINESS
{
    class rTipoPeca : ComandosSql
    {
        public DataTable BuscaTipoPeca(string Descricao)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(Descricao) == true)
                {
                    return base.BuscaDados("sp_busca_tipoPeca");
                }
                else
                {
                    param = new SqlParameter("@dsc_tipo_peca", Descricao);
                    return base.BuscaDados("sp_busca_tipoPeca_param", param);
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

        public int BuscaIdMaximo()
        {
            try
            {
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_tipo_peca", "tipopeca"));
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
