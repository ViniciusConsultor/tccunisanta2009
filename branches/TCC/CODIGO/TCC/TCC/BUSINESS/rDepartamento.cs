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
        public int BuscaIdMaximo()
        {
            try
            {
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_depto", "Departamento"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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

        private void ValidaDados(mDepartamento model)
        {
            if (this.ExisteDepartamento(model.NomeDepto) == true)
            {
                throw new Exceptions.Departamento.NomeDepartamentoExistenteException();
            }
        }

        private bool ExisteDepartamento(string nome)
        {
            DataTable dt = null;
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@nom", nome);
                dt = base.BuscaDados("sp_existe_departamento", param);
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

        public override void ValidarInsere(ModelPai model)
        {
            this.ValidaDados((mDepartamento)model);
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
