using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using TCC.DAL;
using TCC.MODEL;

namespace TCC.BUSINESS
{
    class rDepartamento :ComandosSql
    {
        public DataTable BuscaDepartamento(string Descricao)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(Descricao) == true)
                {
                    return base.BuscaDados("sp_busca_departamento");
                }
                else
                {
                    param = new SqlParameter("@dsc_departamento", Descricao);
                    return base.BuscaDados("sp_busca_departamento_param", param);
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

        public int BuscaIdMaximoDepartamento()
        {
            DataTable dt;
            int idDepartamento;
            try
            {
                dt = base.BuscaIdMaximoTabelas("id_depto", "departamento");
                if (dt.Rows[0]["max"] == DBNull.Value || dt.Rows[0]["max"] == null)
                {
                    idDepartamento = 0;
                }
                else
                {
                    idDepartamento = Convert.ToInt32(dt.Rows[0]["max"]);
                }
                return ++idDepartamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
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
