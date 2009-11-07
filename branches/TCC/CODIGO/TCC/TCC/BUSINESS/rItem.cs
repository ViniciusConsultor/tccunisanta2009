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
