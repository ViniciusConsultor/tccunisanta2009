using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection;

namespace TCC.MODEL
{
    public abstract class ModelPai
    {
        public abstract string getNomeTabela();

        public void Deserialize(DataTable dtModel)
        {
            Type tipo = this.GetType();
            object[] cols;
            object valor;
            PropertyInfo[] prop;
            try
            {
                prop = tipo.GetProperties();
                //Varre as propriedades
                //---------------------
                for (int contador = 0; contador < prop.Length; contador++)
                {
                    //Atribui os atributos de uma propriedade ao Array cols
                    //-----------------------------------------------------
                    cols = prop[contador].GetCustomAttributes(typeof(ColunasBancoDados), true);
                    if (cols.Length > 0)
                    {
                        ColunasBancoDados colunas = (ColunasBancoDados)cols[0];
                        valor = dtModel.Rows[0][colunas.NomeColuna];
                        if (valor == DBNull.Value)
                        {
                            valor = null;
                        }
                        prop[contador].SetValue(this, valor, null);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cols = null;
                prop = null;
            }
        }
    }
}
