using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace TCC.BUSINESS
{
    class rKitGrupoPeca:ComandosSql
    {
        public DataTable BuscaKitGrupoPecaNome(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_kitGrupoPeca");
                }
                else
                {
                    param = new SqlParameter("@nom", parametro);
                    return base.BuscaDados("sp_busca_kitGrupoPeca_param_nome", param);
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

        public DataTable BuscaKitGrupoPecaCodigo(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_kitGrupoPeca");
                }
                else
                {
                    param = new SqlParameter("@id_kit_real", parametro);
                    return base.BuscaDados("sp_busca_kitGrupoPeca_param_codigo", param);
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
            return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_kit", "kitgrupopeca"));
        }

        public override void ValidarInsere(TCC.MODEL.ModelPai model)
        {
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
