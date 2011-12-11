﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelasDesenvolvedor.MODEL;
using TelasDesenvolvedor.DAL;

namespace TelasDesenvolvedor.BUSINESS
{
    class rCadColaborador
    {
        public void cadastraColaborador(mCadColaborador model)
        {
            dCadColaborador dalCadColaborador = new dCadColaborador();
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

    }
}
