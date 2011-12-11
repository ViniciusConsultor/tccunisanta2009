using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCC.MODEL;

namespace TCC.BUSINESS
{
    class rOrdemProducaoo : ComandosSql
    {
        public int BuscaIdMaximo()
        {
            try
            {
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_ordem_prod", "Ordemproducao"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void ValidarInsere(ModelPai model)
        {
            ((mOrdemProducaoo)model).IdOrdemProd = this.BuscaIdMaximo();

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
