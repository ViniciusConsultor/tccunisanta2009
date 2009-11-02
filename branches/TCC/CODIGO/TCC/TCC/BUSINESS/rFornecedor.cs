using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rFornecedor : ComandosSql
    {

        public DataTable BuscaFornecedor(string Descricao)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(Descricao) == true)
                {
                    return base.BuscaDados("sp_busca_fornecedor");
                }
                else
                {
                    param = new SqlParameter("@nomeFornecedor", Descricao);
                    return base.BuscaDados("sp_busca_fornecedor_param", param);
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

        private void ValidaDados(mFornecedor model)
        {
            try
            {
                UTIL.Validacoes.ValidaMasked(model.CepFornecedor.ToString(), TCC.BUSINESS.UTIL.TipoMasked.cep);
                UTIL.Validacoes.ValidaMasked(model.Telefone.ToString(), TCC.BUSINESS.UTIL.TipoMasked.tel);
                UTIL.Validacoes.ValidaMasked(model.Ddd.ToString(), TCC.BUSINESS.UTIL.TipoMasked.ddd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void ValidarInsere(ModelPai model)
        {
            this.ValidaDados((mFornecedor)model);
            base.Insere(model);
        }

        public override void ValidarDeleta(ModelPai model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarAltera(ModelPai model)
        {
            throw new NotImplementedException();
        }
    }
}
