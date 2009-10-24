using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using TCC.MODEL;

namespace TCC.BUSINESS
{
    class rPeca:ComandosSql
    {
        public string BuscaIdMaximoPeca()
        {
            try
            {
                return base.BuscaIdMaximoTabelas("id_peca", "peca");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BuscaPeca(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_peca");
                }
                else
                {
                    param = new SqlParameter("@nom", parametro);
                    return base.BuscaDados("sp_busca_peca_param", param);
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

        public bool VerificaExistenciaPeca(string idPecaReal)
        {
            SqlParameter param = new SqlParameter("@id_peca_real", idPecaReal);
            DataTable dtRetorno;
            try
            {
                dtRetorno = base.BuscaDados("sp_existe_peca", param);
                if (dtRetorno.Rows[0]["flg_existe"].ToString().Equals("1") == true)
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

            }
        }

        private void ValidaDados(mPeca model)
        {
            if (this.VerificaExistenciaPeca(model.IdPecaReal) == true)
            {
                throw new Exceptions.Peca.PecaJaExistenteException();
            }
            else if (model.QtdMin <= 0 || model.QtdMin == null)
            {
                throw new Exceptions.Peca.QtdMinimaNuloOuZeroException();
            }
        }

        public override void ValidarInsere(TCC.MODEL.ModelPai model)
        {
            mPeca mPeca = (mPeca)model;
            this.ValidaDados(mPeca);
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
