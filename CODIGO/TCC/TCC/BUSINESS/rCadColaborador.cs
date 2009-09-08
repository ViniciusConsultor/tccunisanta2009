using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rCadColaborador
    {
        public void cadastraColaborador(mColaborador model)
        {
            dColaborador dalCadColaborador = new dColaborador();
            try
            {
                dalCadColaborador.CadastraColaborador(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dalCadColaborador = null;
            }
        }

        public int BuscaIDMaximoColaborador()
        {
            dColaborador dalColaborador = new dColaborador();
            DataTable dt;
            int idColaborador;
            try
            {
                dt = dalColaborador.BuscaIDMaximoColaborador();
                if (dt.Rows[0]["id_colab"] == DBNull.Value || dt.Rows[0]["id_colab"] == null)
                {
                    idColaborador = 0;
                }
                else
                {
                    idColaborador = Convert.ToInt32(dt.Rows[0]["id_colab"]);
                }
                return ++idColaborador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dalColaborador = null;
                dt = null;
            }
        }
    }
}
