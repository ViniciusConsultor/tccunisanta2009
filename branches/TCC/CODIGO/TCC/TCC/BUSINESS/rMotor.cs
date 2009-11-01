using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace TCC.BUSINESS
{
    class rMotor:ComandosSql
    {
        public override void ValidarInsere(TCC.MODEL.ModelPai model)
        {
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
        public DataTable BuscaMotores(string descricaoMotor)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(descricaoMotor) == true)
                {
                    return base.BuscaDados("sp_busca_motor");
                }
                else
                {
                    param = new SqlParameter("@dsc_motor_compra", descricaoMotor);
                    return base.BuscaDados("sp_busca_motor_param", param);
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
    }
}
