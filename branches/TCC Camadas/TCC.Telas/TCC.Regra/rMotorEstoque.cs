using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.Mapper;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rMotorEstoque : ComandosSql
    {
        public override void ValidarDeleta(ModelPai model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarAltera(ModelPai model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarInsere(ModelPai model)
        {
            base.Insere(model);
        }

        /// <summary>
        /// Este metodo busca todos os relacionamento entre motor e estoque por motor selecionado
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataTable BuscaMotorEstoquePorMotor(mMotor model)
        {
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@id_motor", model.IdMotor);
                return base.BuscaDados("sp_busca_motorestoqueparammotor", param);
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

        public void DeletaMotorEstoqueporMotor(int? idMotor)
        {
            SqlParameter param = null;
            try
            {
                if (idMotor == null)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    param = new SqlParameter("@id_motor", idMotor);
                    base.BuscaDados("sp_delete_motorestoqueporperfil", param);
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
