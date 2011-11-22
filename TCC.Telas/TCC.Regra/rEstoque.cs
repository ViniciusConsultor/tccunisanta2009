using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.Mapper;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rEstoque : ComandoSql
    {
        public int BuscaIdMaximo()
        {
            try
            {
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_estoq", "Estoque"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscaEstoque(string Descricao)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(Descricao) == true)
                {
                    return base.BuscaDados("sp_busca_estoque");
                }
                else
                {
                    param = new SqlParameter("@nom_estoque", Descricao);
                    return base.BuscaDados("sp_busca_estoque_param", param);
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

        private void ValidaDados(mEstoque model)
        {
            if (this.ExisteEstoque(model.Dsc_estoque) == true)
            {
                throw new Regra.Exceptions.Estoque.NomEstoqueExistenteException();
            }
        }

        private bool ExisteEstoque(string NomeEstoque)
        {
            DataTable dt = null;
            SqlParameter param = null;
            try
            {

                param = new SqlParameter("@dsc_estoq", NomeEstoque);
                dt = base.BuscaDados("sp_existe_estoque", param);
                if (Convert.ToInt32(dt.Rows[0]["flg_existe"]) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }
            }
        }

        public override void ValidarInsere(ModelPai model)
        {
            this.ValidaDados((mEstoque)model);
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
