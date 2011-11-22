using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using TCC.AcessoDados;
using TCC.Mapper;

namespace TCC.Regra
{
    public class rItemPeca : ComandoSql
    {
        public DataTable BuscaItemPeca(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_itemPeca");
                }
                else
                {
                    param = new SqlParameter("@nom", parametro);
                    return base.BuscaDados("sp_busca_itemPeca_param", param);
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

        /// <summary>
        /// Este método é utilizado no Tree View "ResumoOrdemProdução"
        /// </summary>
        /// <param name="parametro">ID_item</param>
        /// <returns></returns>
        public DataTable BuscaItemPecaTree(int parametro)
        {
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@id_item", parametro);
                return base.BuscaDados("sp_busca_tree_itempeca", param);
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

        public int BuscaIdMaximo()
        {
            try
            {
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_item_peca", "itempeca"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void ValidarInsere(ModelPai model)
        {
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
