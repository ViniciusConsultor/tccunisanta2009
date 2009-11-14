using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace TCC.BUSINESS
{
    class rFamiliaMotor : ComandosSql
    {
        /// <summary>
        /// Método utilziado pelo Tree View em "ResumoOrdemProducao"
        /// </summary>
        /// <param name="idFamiliaMotor"></param>
        /// <returns></returns>
        public DataTable BuscaFamiliaMotorTree(int parametro)
        {
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@id_fam_motor", parametro);
                return base.BuscaDados("sp_busca_tree_familiamotor", param);
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
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_fam_motor", "Familiamotor"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscaFamiliaMotorNome(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_familiaMotor");
                }
                else
                {
                    param = new SqlParameter("@dsc_fam_motor", parametro);
                    return base.BuscaDados("sp_busca_familiaMotor_param_nome", param);
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

        public DataTable BuscaFamiliaMotorCodigo(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_familiaMotor");
                }
                else
                {
                    param = new SqlParameter("@id_fam_motor_real", parametro);
                    return base.BuscaDados("sp_busca_familiaMotor_param_codigo", param);
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
