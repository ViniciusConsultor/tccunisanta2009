using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.Regra.Util
{
    public static class Auxiliar
    {
        //TODO: Pensar em colocar em uma public classe auxiliar ou algo do tipo
        #region Criptografa Senha
        /// <summary>
        /// Criptografa a senha do usuario
        /// </summary>
        /// <param name="senha">Senha a ser Criptografada</param>
        /// <returns>Senha Criptografada</returns>
        public static string CriptografaSenha(string senha)
        {
            string criptografado;
            try
            {
                byte[] b = ASCIIEncoding.ASCII.GetBytes(senha);
                criptografado = Convert.ToBase64String(b);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return criptografado;
        }
        #endregion Criptografa Senha


    }
}
