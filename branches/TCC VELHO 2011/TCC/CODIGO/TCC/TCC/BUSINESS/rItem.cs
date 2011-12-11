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
        public mItem BuscaUnicoRegistro(int idItem)
        {
            DataTable dtRetorno = null;
            SqlParameter param = null;
            mItem modelItem = new mItem();
            try
            {
                param = new SqlParameter("@id_item", idItem);
                dtRetorno = base.BuscaDados("sp_select_item", param);
                modelItem.Deserialize(dtRetorno);
                return modelItem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
                if (dtRetorno != null)
                {
                    dtRetorno.Dispose();
                    dtRetorno = null;
                }
                modelItem = null;
            }
        }

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

        private bool ExisteItemReal(string ItemReal)
        {
            SqlParameter param = null;
            DataTable dtQuery = null;
            try
            {
                param = new SqlParameter("@id_item_real", ItemReal);
                dtQuery = base.BuscaDados("sp_existe_itemReal", param);
                if (Convert.ToInt32(dtQuery.Rows[0]["flg_existe"]) > 0)
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
                if (dtQuery != null)
                {
                    dtQuery.Dispose();
                    dtQuery = null;
                }
                param = null;
            }
        }

        private bool ExisteItemNome(string NomeItem)
        {
            SqlParameter param = null;
            DataTable dtQuery = null;
            try
            {
                param = new SqlParameter("@nom", NomeItem);
                dtQuery = base.BuscaDados("sp_existe_itemNome", param);
                if (Convert.ToInt32(dtQuery.Rows[0]["flg_existe"]) > 0)
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
                if (dtQuery != null)
                {
                    dtQuery.Dispose();
                    dtQuery = null;
                }
                param = null;
            }
        }

        private void ValidaDados(mItem model)
        {
            if (this.ExisteItemReal(model.Id_item_real) == true)
            {
                throw new Exceptions.Item.CodigoRealItemExistenteException();
            }
            else if (this.ExisteItemNome(model.Nom) == true)
            {
                throw new Exceptions.Item.NomeItemExistenteException();
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
