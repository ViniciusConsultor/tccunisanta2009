using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TCC.BUSINESS
{
    class rPeca:ComandosSql
    {
        public int BuscaIdMaximoPeca()
        {
            DataTable dtIdMax = new DataTable();
            int id= 0;
            try
            {
                dtIdMax = base.BuscaIdMaximoTabelas("id_peca", "peca");
                if (dtIdMax.Rows[0]["max"] != DBNull.Value)
                {
                    id = Convert.ToInt32(dtIdMax.Rows[0]["max"]);
                }
                return ++id;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (dtIdMax != null)
                {
                    dtIdMax.Dispose();
                    dtIdMax = null;
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
