using System;
using System.Collections.Generic;
using System.Text;

namespace TCC.BUSINESS.UTIL
{
    public enum TipoMasked
    {
        cep,
        tel,
        ddd,
        cnpj
    }

    public static class Validacoes
    {
        #region Atributos
        /// <summary>
        /// Ano Minimo Aceito pelo SQL e DateTime
        /// </summary>
        const int ANOMINIMO = 1753;
        #endregion Atributos

        #region Valida Data
        /// <summary>
        /// Validação para Data
        /// </summary>
        /// <param name="DataSemFormatacao">Data com '/' exemplo:. "02/06/1988"</param>
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
        #endregion Valida Data

        #region Verifica Ano Bixesto
        /// <summary>
        /// Verifica se é ano Bixesto ou não
        /// </summary>
        /// <param name="ano">Ano para verificação</param>
        /// <returns>true é um ano bisexto caso contrario, false</returns>
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
        #endregion Verifica Ano Bixesto


        public static void ValidaMasked(string masked, TipoMasked tipo)
        {
            //string mensagem = "OK";
            switch (tipo)
            {
                case TipoMasked.cep:
                    if (masked.Length < 8)
                    {
                        throw new Exceptions.Validacoes.MaskedInvalidaException(tipo);
                    }
                    break;
                case TipoMasked.ddd:
                    if (masked.Length < 2)
                    {
                        throw new Exceptions.Validacoes.MaskedInvalidaException(tipo);
                    }
                    break;
                case TipoMasked.tel:
                    if (masked.Length < 8)
                    {
                        throw new Exceptions.Validacoes.MaskedInvalidaException(tipo);
                    }
                    break;
                case TipoMasked.cnpj:
                    if (masked.Length < 14)
                    {
                        throw new Exceptions.Validacoes.MaskedInvalidaException(tipo);
                    }
                    break;
            }
        }

        /// <summary>
        /// Retorna true se o email estiver OK ou false se estiver errado
        /// </summary>
        /// <param name="_email"></param>
        /// <returns></returns>
        public static bool ValidaEmail(string _email)
        {
            string email = _email;
            bool retorno = true;

            //Verifica se o email é nulo
            if (string.IsNullOrEmpty(email) == false)
            {
                //Verifica se o email contem '@' e '.'
                if (email.Contains("@") == false || email.Contains(".") == false)
                {
                    retorno = false;
                }
                else
                {
                    //Verifica se o email inicia ou termina com '@' ou '.'
                    if (email.EndsWith("@") == true || email.EndsWith(".") == true || email.StartsWith("@") == true || email.StartsWith(".") == true)
                    {
                        retorno = false;
                    }
                    else
                    {
                        //Verifica se o email possui '@' seguido de '.' ou '.' seguido de '@'
                        char aux1, aux2;
                        for (int i = 0; i < email.Length; i++)
                        {
                            aux1 = Convert.ToChar(email.Substring(i, 1));
                            if (aux1.Equals('@') == true || aux1.Equals('.') == true)
                            {
                                aux2 = Convert.ToChar(email.Substring(i + 1, 1));
                                if (aux2.Equals('@') == true || aux2.Equals('.') == true)
                                {
                                    retorno = false;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                retorno = false;
            }
            //Retorna true se o email estiver OK ou false se estiver errado
            return retorno;
        }
    }
}
