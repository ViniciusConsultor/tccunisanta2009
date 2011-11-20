using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCC.AcessoDados;
using System.Data.SqlClient;

namespace TCC.Regra
{
    public class rInicio
    {
        public rInicio()
        {

        }

        public static SqlConnection conexao = ConexaoBanco.Conexao;
        
        public static bool ConectarBanco()
        {
            return ConexaoBanco.ConectaBancoDados();

        }

        public static bool DesconectarBanco()
        {
            return ConexaoBanco.DesconectaBanco();
        }
    }
}
