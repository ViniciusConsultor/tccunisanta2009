using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rUsuario : ComandosSql
    {

        #region Busca Id Maximo Usuario
        public string BuscaIdMaximoUsuario()
        {
            try
            {
                return base.BuscaIdMaximoTabelas("id_usu", "Usuario");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Busca Id Maximo Usuario

        public DataTable BuscaUsuario(string Descricao)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(Descricao) == true)
                {
                    return base.BuscaDados("sp_busca_usuario");
                }
                else
                {
                    param = new SqlParameter("@login", Descricao);
                    return base.BuscaDados("sp_busca_usuario_param", param);
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
        

        public DataTable VerificaLoginUsuario(string login, string senha)
        {
            dUsuario dal = new dUsuario();
            try
            {
                return dal.VerificaLoginUsuario(login, senha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal = null;
            }
        }

        public void ValidaDados(mUsuario model)
        {
            if (string.IsNullOrEmpty(model.Login) == true)
            {
                throw new Exceptions.Login.LoginVazioException();
            }
            else if (this.VerificaExistenciaUsuario(model.Login))
            {
                throw new Exceptions.Login.LoginExistenteException();
            }
            else if (string.IsNullOrEmpty(model.Senha) == true)
            {
                throw new Exceptions.Login.SenhaVaziaException();
            }
        }

        public bool VerificaExistenciaUsuario(string login)
        {
            DataTable dtBusca = null;
            try
            {
                SqlParameter param = new SqlParameter("@usuario", login);
                dtBusca = base.BuscaDados("sp_existe_usuario", param);
                int retorno = Convert.ToInt32(dtBusca.Rows[0]["flg_existe"]);
                if (retorno == 1)
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
                if (dtBusca != null)
                {
                    dtBusca.Dispose();
                    dtBusca = null;
                }
            }
        }

        public void DeletaUsuario(mUsuario model)
        {
            dUsuario dal = new dUsuario();
            try
            {
                dal.DeletaUsuario(model.IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal = null;
            }
        }

        public void BuscaDadosAlterar(int idUsuario)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        public override void ValidarInsere(ModelPai model)
        {
            mUsuario modelUsu = (mUsuario)model;
            try
            {
                this.ValidaDados(modelUsu);
                base.Insere(modelUsu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                modelUsu = null;
            }
        }

        public override void ValidarDeleta(ModelPai model)
        {
            base.Deleta(model);
        }

        public override void ValidarAltera(ModelPai model)
        {
            throw new NotImplementedException();
        }
    }
}
