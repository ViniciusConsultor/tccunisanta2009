using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rCadColaborador:ComandosSql
    {
        public int BuscaIDMaximoColaborador()
        {
            dColaborador dalColaborador = new dColaborador();
            DataTable dt;
            int idColaborador;
            try
            {
                dt = base.BuscaIdMaximoTabelas("id_colab", "Colaborador");
                if (dt.Rows[0]["max"] == DBNull.Value || dt.Rows[0]["max"] == null)
                {
                    idColaborador = 0;
                }
                else
                {
                    idColaborador = Convert.ToInt32(dt.Rows[0]["max"]);
                }
                return ++idColaborador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dalColaborador = null;
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
