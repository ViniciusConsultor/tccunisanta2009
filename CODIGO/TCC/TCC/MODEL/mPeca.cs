using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mPeca:ModelPai
    {
        private string nomeTabela = "peca";
        public override string getNomeTabela()
        {
            return nomeTabela;
        }
    }
}
