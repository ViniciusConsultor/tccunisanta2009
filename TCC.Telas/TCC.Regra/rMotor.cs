using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using TCC.Mapper;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rMotor: ComandosSql
    {
        private void ValidaDados(mMotor model)
        {
            if (this.ExisteNomeMotor(model.DscMotor) == true)
            {
                throw new Regra.Exceptions.Motor.DescMotorExistenteException();
            }
        }

        private bool ExisteNomeMotor(string nomeMotor)
        {
            DataTable dt = null;
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@dsc_motor", nomeMotor);
                dt = base.BuscaDados("sp_existe_motor", param);
                if (Convert.ToInt32(dt.Rows[0]["flg_existe"]) > 0)
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
                param = null;
                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }
            }
        }

        public override void ValidarInsere(ModelPai model)
        {
            this.ValidaDados((mMotor)model);
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

        public int BuscaMaxId()
        {
            return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_motor", "Motor"));
        }
    }
}
