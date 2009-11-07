using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    public class mProduto : ModelPai
    {
        private int? id_produto;
        private string dsc_produto;
       // private int id_depto;
        private int idFamMotor;
        private int idKit;
        private int id_tipo_produto;
        private string nomeTabela = "Produto";


        [ColunasBancoDados("id_fam_motor", System.Data.SqlDbType.Int, false)]
        public int IdFamMotor
        {
            get { return idFamMotor; }
            set { idFamMotor = value; }
        }
        

        [ColunasBancoDados ("id_prdto", System.Data.SqlDbType.Int,true)]
        public int? Id_produto
        {
            get { return id_produto; }
            set { id_produto = value; }
        }

        [ColunasBancoDados ("dsc_prdto", System.Data.SqlDbType.VarChar,false)]
        public string Dsc_produto
        {
            get { return dsc_produto; }
            set { dsc_produto= value; }
        }
        /*
        [ColunasBancoDados ("id_depto", System.Data.SqlDbType.Int,false)]
        public int Id_depto
        {
            get { return id_depto; }
            set { id_depto = value; }
        }
        */
       
       

        [ColunasBancoDados ("id_kit", System.Data.SqlDbType.Int,false)]
        public int IdKit
        {
            get { return idKit; }
            set { idKit = value; }
        }

        [ColunasBancoDados ("id_tipo_produto", System.Data.SqlDbType.Int,false)]
        public int Id_tipo_produto
        {
            get { return id_tipo_produto; }
            set { id_tipo_produto = value; }
        }

        public override string getNomeTabela()
        {
            return this.nomeTabela;
        } 
    }
}
