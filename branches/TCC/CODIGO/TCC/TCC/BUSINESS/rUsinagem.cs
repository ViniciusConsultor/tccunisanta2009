using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TCC.BUSINESS
{
    class rUsinagem : ComandosSql
    {
        public int BuscaIdMaximoUsinagem()
        {
            DataTable dtId = new DataTable();
            int id = 0;
            try
            {
                dtId = base.BuscaIdMaximoTabelas("id_usinagem", "Usinagem");
                if (dtId.Rows[0]["max"] != DBNull.Value)
                {
                    id = Convert.ToInt32(dtId.Rows[0]["max"]);
                }
                return ++id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dtId != null)
                {
                    dtId.Dispose();
                    dtId = null;
                }
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
