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
    class rVenda : ComandosSql
    {
        public string BuscaidMaximo()
        {
            try
            {
                return base.BuscaIdMaximoTabelas("id_venda", "venda");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable buscaVenda()
        {
            SqlParameter param = null;
            try
            {
            /*    if (string.IsNullOrEmpty(venda) == true)
                */    {
                    return base.BuscaDados("sp_busca_venda");
                }
            /*    else
                {
                    param = new SqlParameter("@id_venda", nomeCliente);
                    return base.BuscaDados("sp_busca_venda_param", param);
                }*/
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

        private void ValidaDados(mVenda model)
        {
            if (model.Qtd == null || model.Qtd <= 0)
            {
                throw new Exceptions.Venda.QuantidadeVendaZeroOuNuloException();
            }
            else if (model.Valor == null || model.Valor <= 0)
            {
                throw new Exceptions.Venda.ValorVendaZeroOuNuloException();
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
 