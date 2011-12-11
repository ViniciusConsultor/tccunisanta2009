using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rVenda : ComandosSql
    {

        public DataTable buscaVenda(string data, string cliente)
        {
            SqlParameter[] parametros = null;
            try
            {
                if (string.IsNullOrEmpty(data) == true && string.IsNullOrEmpty(cliente) == true)
                    {
                    return base.BuscaDados("sp_busca_venda");
                }
                else
                {
                    parametros[0] = new SqlParameter("@dat_venda", data);
                    parametros[1] = new SqlParameter("@nom_cli", cliente);
                    return base.BuscaDados("sp_busca_venda_param", parametros);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parametros = null;
            }
        }

        private void ValidaDados(mVenda model)
        {
            if (model.Valor <= 0)
            {
                throw new Exceptions.Venda.ValorVendaZeroOuNuloException();
            }
        }

        public int BuscaIdMaximo()
        {
            try
            {
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_venda", "Venda"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        public override void ValidarInsere(TCC.MODEL.ModelPai model)
        {
            mVenda modelVenda = (mVenda)model;
            this.ValidaDados(modelVenda);
            base.Insere(model);
        }

        public override void ValidarDeleta(TCC.MODEL.ModelPai model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarAltera(TCC.MODEL.ModelPai model)
        {
            throw new NotImplementedException();
        }
    }
}
 