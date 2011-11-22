using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using TCC.AcessoDados;
using TCC.Mapper;

namespace TCC.Regra
{
    public class rCliente : ComandosSql
    {
        public DataTable BuscaClientes(string nomeCliente)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(nomeCliente) == true)
                {
                    return base.BuscaDados("sp_busca_cliente");
                }
                else
                {
                    param = new SqlParameter("@nom_cli", nomeCliente);
                    return base.BuscaDados("sp_busca_cliente_param", param);
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
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_cli", "Cliente"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ValidaDados(mCliente model)
        {
            if (model.CodPostal != null && model.Nom_pais == "Brasil")
            {
                Util.Validacoes.ValidaMasked(model.CodPostal, TCC.Regra.Util.TipoMasked.cep);
            }

            if (model.Email != null)
            {
                string email = Convert.ToString(model.Email);
                Util.Validacoes.ValidaEmail(email);
            }

            if (model.Ddi != null)
            {
                string ddi = Convert.ToString(model.Ddi);
                Util.Validacoes.ValidaMasked(ddi, TCC.Regra.Util.TipoMasked.ddd);
            }

            if (model.Ddd != null && model.Nom_pais == "Brasil")
            {
                string ddd = Convert.ToString(model.Ddd);
                Util.Validacoes.ValidaMasked(ddd, TCC.Regra.Util.TipoMasked.ddd);
            }

            if (model.TelefoneCliente != null && model.Nom_pais == "Brasil")
            {
                string tel = Convert.ToString(model.TelefoneCliente);
                Util.Validacoes.ValidaMasked(tel, TCC.Regra.Util.TipoMasked.tel);
            }

            if (model.Cpf != null)
            {
                Util.Validacoes.ValidaMasked(model.Cpf, TCC.Regra.Util.TipoMasked.cpf);
                if (this.ExisteCpf(model.Cpf) == true)
                {
                    throw new Regra.Exceptions.Cliente.CPFClienteExistente();
                }
            }

            if (model.Cnpj != null)
            {
                string cnpj = Convert.ToString(model.Cnpj);
                Util.Validacoes.ValidaMasked(cnpj, TCC.Regra.Util.TipoMasked.cnpj);
                if (this.ExisteCnpj(cnpj) == true)
                {
                    throw new Regra.Exceptions.Cliente.CNPJClienteExistente();
                }
            }

            if (model.IdentInter != null)
            {
                if (this.ExisteIdentInter(model.IdentInter) == true)
                {
                    throw new Regra.Exceptions.Cliente.IdentInterExistenteException();
                }
            }
        }

        private bool ExisteCpf(string cpf)
        {
            DataTable dt = null;
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@cpf", cpf);
                dt = base.BuscaDados("sp_existe_cpf_cliente", param);

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

        private bool ExisteCnpj(string cnpj)
        {
            DataTable dt = null;
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@cnpj", cnpj);
                dt = base.BuscaDados("sp_existe_cnpj_cliente", param);

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

        private bool ExisteIdentInter(string identInter)
        {
            DataTable dt = null;
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@ident_inter", identInter);
                dt = base.BuscaDados("sp_existe_cliente_ident_inter", param);

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
            base.Insere(model);
        }

        public override void ValidarDeleta(ModelPai model)
        {
            base.Deleta(model);
        }

        public override void ValidarAltera(ModelPai model)
        {
            base.Altera(model);
        }

        public DataTable BuscaUmRegistro(ModelPai model)
        {
            return base.BuscaUmRegistro(model);
        }
    }
}
