using System;
using System.Collections.Generic;
using System.Text;
using TCC.MODEL;
using System.Data;
using System.Data.SqlClient;

namespace TCC.BUSINESS
{
    class rItem : ComandosSql
    {
        public DataTable BuscaItemNome(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_item");
                }
                else
                {
                    param = new SqlParameter("@nom", parametro);
                    return base.BuscaDados("sp_busca_item_param_nome", param);
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
                
        public DataTable BuscaItemCodigo(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_item");
                }
                else
                {
                    param = new SqlParameter("@id_item_real", parametro);
                    return base.BuscaDados("sp_busca_item_param_codigo", param);
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

        public bool VerificaExistenciaItem(string idItemReal)
        {
            SqlParameter param = new SqlParameter("@id_item_real", idItemReal);
            DataTable dtRetorno;
            try
            {
                dtRetorno = base.BuscaDados("sp_existe_item", param);
                if (dtRetorno.Rows[0]["flg_existe"].ToString().Equals("1") == true)
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
        }

        public int BuscaIdMaximo()
        {
            return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_item", "Item"));
        }

        private void ValidaDados(mItem model)
        {
            SqlParameter param = null;
            DataTable dtQuery = null;
            try
            {
                param = new SqlParameter("@id_item_real", model.Id_item_real);
                dtQuery = base.BuscaDados("sp_existe_item", param);
                if (Convert.ToInt32(dtQuery.Rows[0]["flg_existe"]) > 0)
                {
                    throw new Exceptions.Item.CodigoRealItemExistenteException();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dtQuery != null)
                {
                    dtQuery.Dispose();
                    dtQuery = null;
                }
                param = null;
            }
        }

        public override void ValidarInsere(TCC.MODEL.ModelPai model)
        {
            this.ValidaDados((mItem)model);
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
