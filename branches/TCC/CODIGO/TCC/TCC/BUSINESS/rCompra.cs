using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TCC.BUSINESS
{
    class rCompra : ComandosSql
    {
        public int BuscaIdMaximoCompra()
        {
            DataTable dt;
            int id;
            try
            {
                dt = base.BuscaIdMaximoTabelas("id_compra", "compra");
                if (dt.Rows[0]["max"] == DBNull.Value || dt.Rows[0]["max"] == null)
                {
                    id = 0;
                }
                else
                {
                    id = Convert.ToInt32(dt.Rows[0]["max"]);
                }
                return ++id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dt = null;
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
