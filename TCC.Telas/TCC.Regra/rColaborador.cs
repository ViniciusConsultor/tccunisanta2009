using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.Mapper;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rColaborador:ComandosSql
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
                Util.Validacoes.ValidaMasked(model.Ddd.ToString(), TCC.Regra.Util.TipoMasked.ddd);
            }
            if (model.Telefone != null)
            {
                Util.Validacoes.ValidaMasked(model.Telefone.ToString(), TCC.Regra.Util.TipoMasked.tel);
            }
            if (model.Cep != null)
            {
                Util.Validacoes.ValidaMasked(model.Cep.ToString(), TCC.Regra.Util.TipoMasked.cep);
            }
            if (model.Cpf != null)
            {
                Util.Validacoes.ValidaMasked(model.Cpf.ToString(), TCC.Regra.Util.TipoMasked.cpf);
                if (this.ExisteCpfColaborador(model.Cpf) == true && alteracao == false)
                {
                    throw new Regra.Exceptions.Colaborador.CpfExistenteException();
                }
            }
            if (model.Email != null)
            {
                string email = Convert.ToString(model.Email);
                Util.Validacoes.ValidaEmail(email);
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