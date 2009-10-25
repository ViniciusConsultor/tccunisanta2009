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

        public string BuscaIdMaximoCliente()
        {
            try
            {
                return base.BuscaIdMaximoTabelas("id_cli", "cliente");
            }
            catch (Exception ex)
            {
                throw ex;
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
