﻿using System;
using System.Collections.Generic;
using System.Text;
using TelasDesenvolvedor.MODEL;
using TelasDesenvolvedor.DAL;

namespace TelasDesenvolvedor.BUSINESS
{
    class rUsuario
    {
        public void CadastraUsuario(mUsuario model)
        {
            dUsuario dalUsuario = new dUsuario();
            try
            {
                dalUsuario.CadastraUsuario(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dalUsuario = null;
            }
        }
    }
}
