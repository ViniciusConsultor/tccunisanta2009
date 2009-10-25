using System;
using System.Collections.Generic;
using System.Text;

namespace TCC.BUSINESS.UTIL
{
    public static class Validacoes
    {
        const int ANOMINIMO = 1753;

        public static void ValidaData(string DataSemFormatacao)
        {
            string[] dataString = DataSemFormatacao.Split('/');
            int[] data = new int[3];
            int[] mes = new int[13];
            for (int cont = 0; cont < dataString.Length; cont++)
            {
                data[cont] = Convert.ToInt32(dataString[cont]);
            }
            mes[1] = 31;
            if (Validacoes.VerificaAnoBixesto(data[2]) == true)
            {
                mes[2] = 28;
            }
            else
            {
                mes[2] = 29;
            }
            mes[3] = 31;
            mes[4] = 30;
            mes[5] = 31;
            mes[6] = 30;
            mes[7] = 31;
            mes[8] = 31;
            mes[9] = 30;
            mes[10] = 31;
            mes[11] = 30;
            mes[12] = 31;

            if (data[2] < ANOMINIMO)
            {
                throw new Exceptions.Validacoes.DataInvalidaException(TCC.BUSINESS.Exceptions.Validacoes.TipoErroData.ano, data);
            }
            else if (data[1] > mes.Length || data[1] < 1)
            {
                throw new Exceptions.Validacoes.DataInvalidaException(TCC.BUSINESS.Exceptions.Validacoes.TipoErroData.mes, data);
            }
            else if (data[0] > mes[data[1]] || data[0] < 1)
            {
                throw new Exceptions.Validacoes.DataInvalidaException(TCC.BUSINESS.Exceptions.Validacoes.TipoErroData.dia, data);
            }
        }

        private static bool VerificaAnoBixesto(int ano)
        {
            bool retorno = false;
            if (ano % 400 == 0)
            {
                retorno = true;
            }
            else if (ano % 100 == 0 && ano % 400 != 0)
            {
                retorno = false;
            }
            else if (ano % 4 == 0 && ano % 100 != 0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
