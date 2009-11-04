using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rColaborador:ComandosSql
    {
        public int BuscaIdMaximo()
        {
            try
            {
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_colab", "Colaborador"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscaColaborador(string nomeColaborador)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(nomeColaborador) == true)
                {
                    return base.BuscaDados("sp_busca_colaborador");
                }
                else
                {
                    param = new SqlParameter("@nom_colab", nomeColaborador);
                    return base.BuscaDados("sp_busca_colaborador_param", param);
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
            base.Altera(model);
        }


    }
}
