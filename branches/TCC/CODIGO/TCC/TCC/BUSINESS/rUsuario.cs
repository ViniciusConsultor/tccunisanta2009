using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rUsuario : ComandosSql
    {

        #region Busca Id Maximo Usuario
        public int BuscaIdMaximoUsuario()
        {
            DataTable dt;
            int idUsuario;
            try
            {
                dt = base.BuscaIdMaximoTabelas("id_usu", "Usuario");
                if (dt.Rows[0]["max"] == DBNull.Value || dt.Rows[0]["max"] == null)
                {
                    idUsuario = 0;
                }
                else
                {
                    idUsuario = Convert.ToInt32(dt.Rows[0]["max"]);
                }
                return ++idUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dt = null;
            }
        }
        public DataTable BuscaUsuario(string Descricao)
        {
            dUsuario dal = new dUsuario();
            try
            {
                return dal.BuscarUsuario(Descricao);
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
        #endregion Busca Id Maximo Usuario

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
                throw new Exceptions.LoginVazioException();
            }
            else if (string.IsNullOrEmpty(model.Senha) == true)
            {
                throw new Exceptions.SenhaVaziaException();
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
