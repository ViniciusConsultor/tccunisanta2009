using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using TCC.Mapper;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rTipoMotor : ComandosSql
    {
        public DataTable BuscaTipoMotor(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_tipoMotor");
                }
                else
                {
                    param = new SqlParameter("@dsc_tipo_motor", parametro);
                    return base.BuscaDados("sp_busca_tipoMotor_param", param);
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
            return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_tipo_motor", "tipomotor"));
        }

        private bool ExisteTipoMotor(string CodigoTipoMotor)
        {
            DataTable dt = null;
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@id_tipo_motor_real", CodigoTipoMotor);
                dt = base.BuscaDados("sp_existe_tipoMotor", param);
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
                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }
                param = null;
            }
        }

        private void ValidaDados(mTipoMotor model)
        {
            if (this.ExisteTipoMotor(model.IdTipoMotorReal) == true)
            {
                throw new Exceptions.TipoMotor.CodigoTipoMotorExistenteException();
            }
        }

        public override void ValidarInsere(ModelPai model)
        {
            this.ValidaDados((mTipoMotor)model);
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