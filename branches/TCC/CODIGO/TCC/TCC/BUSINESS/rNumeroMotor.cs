using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TCC.DAL;
using TCC.MODEL;

namespace TCC.BUSINESS
{
    class rNumeroMotor : ComandosSql
    {
        public string BuscaIdMaximo()
        {
            try
            {
                return base.BuscaIdMaximoTabelas("id_num_motor", "Numeromotor");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscaNumeroMotor(string numeroMotor)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(numeroMotor) == true)
                {
                    return base.BuscaDados("sp_busca_numeromotor");
                }
                else
                {
                    param = new SqlParameter("@nom_cli", numeroMotor);
                    return base.BuscaDados("sp_busca_numeromotor_param", param);
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
    }
}