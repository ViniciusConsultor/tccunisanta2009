using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using TCC.DAL;
using TCC.MODEL;

namespace TCC.BUSINESS
{
    class rDepartamento
    {
        public void CadastraDepartamento(MODEL.mDepartamento model)
        {
            dDepartamento dal = new dDepartamento();
            try
            {
                dal.CadastraDepartamento(model);
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

        public int BuscaIdMaximoDepartamento()
        {
            dDepartamento dalDepartamento = new dDepartamento();
            DataTable dt;
            int idDepartamento;
            try
            {
                dt = dalDepartamento.BuscaIdMaximoDepartamento();
                if (dt.Rows[0]["id_depto"] == DBNull.Value || dt.Rows[0]["id_depto"] == null)
                {
                    idDepartamento = 0;
                }
                else
                {
                    idDepartamento = Convert.ToInt32(dt.Rows[0]["id_depto"]);
                }
                return ++idDepartamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dalDepartamento = null;
                dt = null;
            }
        }
    }
}
