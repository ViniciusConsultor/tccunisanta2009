using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rCliente : ComandosSql
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
                UTIL.Validacoes.ValidaMasked(model.CodPostal, TCC.BUSINESS.UTIL.TipoMasked.cep);
            }

            if (model.Email != null)
            {
                string email = Convert.ToString(model.Email);
                UTIL.Validacoes.ValidaEmail(email);
            }

            if (model.Ddi != null)
            {
                string ddi = Convert.ToString(model.Ddi);
                UTIL.Validacoes.ValidaMasked(ddi, TCC.BUSINESS.UTIL.TipoMasked.ddd);
            }

            if (model.Ddd != null && model.Nom_pais == "Brasil")
            {
                string ddd = Convert.ToString(model.Ddd);
                UTIL.Validacoes.ValidaMasked(ddd, TCC.BUSINESS.UTIL.TipoMasked.ddd);
            }

            if (model.TelefoneCliente != null && model.Nom_pais == "Brasil")
            {
                string tel = Convert.ToString(model.TelefoneCliente);
                UTIL.Validacoes.ValidaMasked(tel, TCC.BUSINESS.UTIL.TipoMasked.tel);
            }

            if (model.Cpf != null)
            {
                UTIL.Validacoes.ValidaMasked(model.Cpf, TCC.BUSINESS.UTIL.TipoMasked.cpf);
                if (this.ExisteCpf(model.Cpf) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.CPFClienteExistente();
                }
            }

            if (model.Cnpj != null)
            {
                string cnpj = Convert.ToString(model.Cnpj);
                UTIL.Validacoes.ValidaMasked(cnpj, TCC.BUSINESS.UTIL.TipoMasked.cnpj);
                if (this.ExisteCnpj(cnpj) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.CNPJClienteExistente();
                }
            }

            if (model.IdentInter != null)
            {
                if (this.ExisteIdentInter(model.IdentInter) == true)
                {
                    throw new BUSINESS.Exceptions.Cliente.IdentInterExistenteException();
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
    }
}
