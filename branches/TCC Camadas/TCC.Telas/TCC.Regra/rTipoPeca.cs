using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TCC.Mapper;
using TCC.AcessoDados;

namespace TCC.Regra
{
    public class rTipoPeca : ComandosSql
    {
        public DataTable BuscaTipoPeca(string Descricao)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(Descricao) == true)
                {
                    return base.BuscaDados("sp_busca_tipoPeca");
                }
                else
                {
                    param = new SqlParameter("@dsc_tipo_peca", Descricao);
                    return base.BuscaDados("sp_busca_tipoPeca_param", param);
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

        private void ValidaDados(mTipoPeca model)
        {
            if (this.ExisteTipoPeca(model.DscTipoPeca) == true)
            {
                throw new Exceptions.TipoPeca.TipoPecaExistenteException();
            }
        }

        private bool ExisteTipoPeca(string dscTipoPeca)
        {
            SqlParameter param = null;
            DataTable dt = null;
            try
            {
                param = new SqlParameter("@dsc_tipo_peca", dscTipoPeca);
                dt = base.BuscaDados("sp_existe_tipoPeca", param);
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
                param = null;
                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }
            }
        }

        public override void ValidarInsere(ModelPai model)
        {
            this.ValidaDados((mTipoPeca)model);
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

        public int BuscaIdMaximo()
        {
            try
            {
                return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_tipo_peca", "tipopeca"));
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
