using System;
using System.Collections.Generic;
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

        public void ValidaDados(mColaborador model, bool alteracao)
        {
            if (model.Ddd != null)
            {
                UTIL.Validacoes.ValidaMasked(model.Ddd.ToString(), TCC.BUSINESS.UTIL.TipoMasked.ddd);
            }
            if (model.Telefone != null)
            {
                UTIL.Validacoes.ValidaMasked(model.Telefone.ToString(), TCC.BUSINESS.UTIL.TipoMasked.tel);
            }
            if (model.Cep != null)
            {
                UTIL.Validacoes.ValidaMasked(model.Cep.ToString().PadLeft(8,'0'), TCC.BUSINESS.UTIL.TipoMasked.cep);
            }
            if (model.Cpf != null)
            {
                UTIL.Validacoes.ValidaMasked(model.Cpf.ToString(), TCC.BUSINESS.UTIL.TipoMasked.cpf);
                if (this.ExisteCpfColaborador(model.Cpf) == true && alteracao == false)
                {
                    throw new BUSINESS.Exceptions.Colaborador.CpfExistenteException();
                }
            }
            if (model.Email != null)
            {
                string email = Convert.ToString(model.Email);
                UTIL.Validacoes.ValidaEmail(email);
            }
        }

        private bool ExisteCpfColaborador(string cpf)
        {
            DataTable dt = null;
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@cpf", cpf);
                dt = base.BuscaDados("sp_existe_cpf_colaborador", param);
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
            this.ValidaDados((mColaborador)model, false);
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