using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TCC.AcessoDados;
using TCC.Mapper;

namespace TCC.Regra
{
    public class rNumeroMotor : ComandoSql
    {
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

        public int BuscaIdMaximo()
        {
            try
            {
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_num_motor", "Numeromotor"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ValidaDados(mNumMotor model)
        {
            if (this.ExisteCodigoNumeroMotor(model.IdNumMotorReal) == true)
            {
                throw new Regra.Exceptions.NumeroMotor.CodigoNumeroMotorExistenteException();
            }
        }

        private bool ExisteCodigoNumeroMotor(string CodigoNumeroMotor)
        {
            DataTable dt = null;
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@id_num_motor_real", CodigoNumeroMotor);
                dt = base.BuscaDados("sp_existe_numeroMotor", param);
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
            this.ValidaDados((mNumMotor)model);
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