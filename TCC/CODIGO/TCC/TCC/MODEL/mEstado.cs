using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mEstado : ModelPai
    {
        private string nomeTabela = "estado";
        private string siglaEstado;
        private string nomEstado;

        [ColunasBancoDados("nom_estado", System.Data.SqlDbType.VarChar, false)]
        public string NomEstado
        {
            get { return nomEstado; }
            set { nomEstado = value; }
        }

        [ColunasBancoDados("slg_estado", System.Data.SqlDbType.VarChar, false)]
        public string SiglaEstado
        {
            get { return siglaEstado; }
            set { siglaEstado = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        }
    }
}
