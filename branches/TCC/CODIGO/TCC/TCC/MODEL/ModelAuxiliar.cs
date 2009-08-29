using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Reflection;

namespace TCC.MODEL
{
    class ModelAuxiliar
    {
        Type _tipo;
        object _modelo;

        public ModelAuxiliar(Type tipo, object modelo)
        {
            this._tipo = tipo;
            this._modelo = modelo;
        }

        public SqlParameter[] BuscaNomeParametros()
        {
            SqlParameter[] param = new SqlParameter[this._tipo.GetProperties().Length];
            object[] cols;
            PropertyInfo[] prop;
            try
            {
                prop = this._tipo.GetProperties();
                for (int contador = 0; contador < prop.Length; contador++)
                {
                    cols = prop[contador].GetCustomAttributes(typeof(ColunasBancoDados), true);
                    if (cols.Length > 0)
                    {
                        ColunasBancoDados colunas = (ColunasBancoDados)cols[0];
                        param[contador] = new SqlParameter("@" + colunas.NomeColuna, prop[contador].GetValue(this._modelo, null));
                    }
                }
                return param;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
                cols = null;
                prop = null;
            }
        }
    }
}
