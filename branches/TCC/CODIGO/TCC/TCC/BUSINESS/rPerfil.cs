using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rPerfil
    {
        public void cadastraPerfil(mPerfil model)
        {
            dPerfil dalPerfil= new dPerfil();
            try
            {
                dalPerfil.CadastraPerfil(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dalPerfil = null;
            }
        }

        public int BuscaIdMaximoPerfil()
        {
            dPerfil dalPerfil = new dPerfil();
            DataTable dt;
            int idPerfil;
            try
            {
                dt = dalPerfil.BuscaIdMaximoPerfil();
                if (dt.Rows[0]["id_perfil"] == DBNull.Value || dt.Rows[0]["id_perfil"] == null)
                {
                    idPerfil = 0;
                }
                else
                {
                    idPerfil = Convert.ToInt32(dt.Rows[0]["id_perfil"]);
                }
                return ++idPerfil;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                dalPerfil = null;
                dt = null;
            }
        }

        public DataTable BuscaPerfil(string Descricao)
        {
            dPerfil dal = new dPerfil();
            try
            {
                return dal.BuscaPerfil(Descricao);
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
    }
}
