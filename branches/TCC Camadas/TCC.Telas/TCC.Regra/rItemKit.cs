using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.AcessoDados;
using TCC.Mapper;

namespace TCC.Regra
{
    public class rItemKit : ComandoSql
    {
        public DataTable BuscaItemKit(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_itemKit");
                }
                else
                {
                    param = new SqlParameter("@nom", parametro);
                    return base.BuscaDados("sp_busca_itemKit_param", param);
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
        /// Este méto é utilizado o Tree View "Resumo Ordem de Produção"
        /// </summary>
        /// <param name="parametro">ID_kit</param>
        /// <returns></returns>
        public DataTable BuscaItemKitTree(int parametro)
        {
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@id_kit", parametro);
                return base.BuscaDados("sp_busca_tree_itemkit", param);
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
