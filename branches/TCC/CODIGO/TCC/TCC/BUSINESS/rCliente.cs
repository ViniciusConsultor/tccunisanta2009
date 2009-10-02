using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rCliente : ComandosSql
    {
        public int BuscaIdMaximoCliente()
        {
            dCliente dal = new dCliente();
            DataTable dt;
            int idCli;
            try
            {
                dt = dal.BuscaIdMaximoCliente();
                if (dt.Rows[0]["id_cli"] == DBNull.Value || dt.Rows[0]["id_cli"] == null)
                {
                    idCli = 0;
                }
                else
                {
                    idCli = Convert.ToInt32(dt.Rows[0]["id_cli"]);
                }
                return ++idCli;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal = null;
                dt = null;
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
