using System;
using System.Collections.Generic;
using System.Text;
using TelasDesenvolvedor.MODEL;
using System.Data.SqlClient;

namespace TelasDesenvolvedor.DAL
{
    class dCadColaborador
    {
        public void CadastraColaborador(mCadColaborador model)
        {
            StringBuilder sql = new StringBuilder();
            try
            {
                int flgAt;
                if (model.FlgAtivo == true)
                {
                    flgAt = 1;
                }
                else
                {
                    flgAt = 0;
                }
                SqlParameter[] parametros = new SqlParameter[5];
                parametros[0] = new SqlParameter("@id_colab", model.IdColab);
                parametros[0].SqlDbType = System.Data.SqlDbType.Int;
                parametros[1] = new SqlParameter("@id_usu", model.IdUsuario);
                parametros[1].SqlDbType = System.Data.SqlDbType.Int;
                parametros[2] = new SqlParameter("@id_depto", model.IdDepto);
                parametros[2].SqlDbType = System.Data.SqlDbType.Int;
                parametros[3] = new SqlParameter("@nom_colab", model.NomeColab);
                parametros[3].SqlDbType = System.Data.SqlDbType.VarChar;
                parametros[4] = new SqlParameter("@dat_nasc", model.DatNasc);
                parametros[4].SqlDbType = System.Data.SqlDbType.DateTime;
                parametros[5] = new SqlParameter("@nom_rua", model.NomeRua);
                parametros[5].SqlDbType = System.Data.SqlDbType.VarChar;
                parametros[6] = new SqlParameter("@nro_end", model.NroEnd);
                parametros[6].SqlDbType = System.Data.SqlDbType.Int;
                parametros[7] = new SqlParameter("@compl_end", model.ComplEnd);
                parametros[7].SqlDbType = System.Data.SqlDbType.VarChar;
                parametros[8] = new SqlParameter("@cep", model.Cep);
                parametros[8].SqlDbType = System.Data.SqlDbType.VarChar;
                parametros[9] = new SqlParameter("@bairr_end", model.BairrEnd);
                parametros[9].SqlDbType = System.Data.SqlDbType.VarChar;
                parametros[10] = new SqlParameter("@cidade", model.Cidade);
                parametros[10].SqlDbType = System.Data.SqlDbType.VarChar;
                parametros[11] = new SqlParameter("@estado", model.Estado);
                parametros[11].SqlDbType = System.Data.SqlDbType.Char;
                parametros[12] = new SqlParameter("@rg", model.Rg);
                parametros[12].SqlDbType = System.Data.SqlDbType.VarChar;
                parametros[13] = new SqlParameter("@cpf", model.Cpf);
                parametros[13].SqlDbType = System.Data.SqlDbType.VarChar;
                parametros[14] = new SqlParameter("@sexo", model.Sexo);
                parametros[14].SqlDbType = System.Data.SqlDbType.Char;
                parametros[15] = new SqlParameter("@dat_atl", model.DatAtl);
                parametros[15].SqlDbType = System.Data.SqlDbType.DateTime;
                parametros[16] = new SqlParameter("@flg_ativo", model.FlgAtivo);
                parametros[16].SqlDbType = System.Data.SqlDbType.Bit;
                
                base.InsereDados("sp_cadastra_colaborador", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sql = null;
            }
        }        
    }
}
