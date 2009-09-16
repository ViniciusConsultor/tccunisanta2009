﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TCC.MODEL;
using TCC.DAL;

namespace TCC.BUSINESS
{
    class rCliente
    {
        public void CadastraCliente(mCliente model)
        {
            dCliente dal = new dCliente();
            try
            {
                dal.CadastraCliente(model);
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

        public int BuscaIdMaximoCliente()
        {
            dCliente dal = new dCliente();
            DataTable dt;
            int idCli;
            try
            {
                dt = dal.BuscaIdMaximoCliente();
                if (dt.Rows[0]["id_cli"] == DBNull.Value || dt.Rows[0]["id_cli"] == null)
                {
                    idCli = 0;
                }
                else
                {
                    idCli = Convert.ToInt32(dt.Rows[0]["id_cli"]);
                }
                return ++idCli;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dal = null;
                dt = null;
            }
        }
    }
}