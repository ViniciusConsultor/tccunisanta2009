using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using TCC.MODEL;

namespace TCC.BUSINESS
{
    class rKitGrupoPeca:ComandosSql
    {
        public mKitGrupoPeca BuscaUnicoRegistro(int idKit)
        {
            DataTable dtRetorno = null;
            SqlParameter param = null;
            mKitGrupoPeca modelKit = new mKitGrupoPeca();
            try
            {
                param = new SqlParameter("@id_kit", idKit);
                dtRetorno = base.BuscaDados("sp_select_kitgrupopeca", param);
                modelKit.Deserialize(dtRetorno);
                return modelKit;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
                if (dtRetorno != null)
                {
                    dtRetorno.Dispose();
                    dtRetorno = null;
                }
                modelKit = null;
            }
        }

        /*public DataTable BuscaKitGrupoPeca(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_kitGrupoPeca");
                }
                else
                {
                    param = new SqlParameter("@nom", parametro);
                    return base.BuscaDados("sp_busca_kitGrupoPeca_param_nome", param);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                param = null;
            }
        }*/

        public DataTable BuscaKitGrupoPecaNome(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_kitgrupopeca");
                }
                else
                {
                    param = new SqlParameter("@nom", parametro);
                    return base.BuscaDados("sp_busca_kitGrupoPeca_param_nome", param);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                param = null;
            }
        }
        
        public DataTable BuscaKitCodigo(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_kitGrupoPeca");
                }
                else
                {
                    param = new SqlParameter("@id_item_real", parametro);
                    return base.BuscaDados("sp_busca_kitGrupoPeca_param_codigo", param);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                param = null;
            }
        }

        public DataTable BuscaKitGrupoPecaCodigo(string parametro)
        {
            SqlParameter param = null;
            try
            {
                if (string.IsNullOrEmpty(parametro) == true)
                {
                    return base.BuscaDados("sp_busca_kitGrupoPeca");
                }
                else
                {
                    param = new SqlParameter("@id_kit_real", parametro);
                    return base.BuscaDados("sp_busca_kitGrupoPeca_param_codigo", param);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                param = null;
            }
        }

        public bool VerificaExistenciaKit(string idKitReal)
        {
            SqlParameter param = new SqlParameter("@id_kit_real", idKitReal);
            DataTable dtRetorno;
            try
            {
                dtRetorno = base.BuscaDados("sp_existe_kitgrupopeca", param);
                if (dtRetorno.Rows[0]["flg_existe"].ToString().Equals("1") == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ValidaDados(mKitGrupoPeca model)
        {
            SqlParameter param = null;
            DataTable dtQuery = null;
            try
            {
                param = new SqlParameter("@id_kit_real", model.IdKitReal);
                dtQuery = base.BuscaDados("sp_existe_kitgrupopeca", param);
                if (Convert.ToInt32(dtQuery.Rows[0]["flg_existe"]) > 0)
                {
                    throw new Exceptions.KitGrupoPeca.CodigoRealKitExistenteException();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dtQuery != null)
                {
                    dtQuery.Dispose();
                    dtQuery = null;
                }
                param = null;
            }
        }

        public int BuscaIdMaximo()
        {
            return Convert.ToInt32(base.BuscaIdMaximoTabelas("id_kit", "kitgrupopeca"));
        }

        /// <summary>
        /// Este método é utilizado para preencher o TreeView
        /// </summary>
        /// <param name="parametro">ID_kit, NÃO utilizar o id_kit_real</param>
        /// <returns></returns>
        public DataTable BuscaKitGrupoPecaTree(int parametro)
        {
            SqlParameter param = null;
            try
            {
                param = new SqlParameter("@id_kit", parametro);
                return base.BuscaDados("sp_busca_tree_kitgrupopeca", param);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                param = null;
            }
        }


        public override void ValidarInsere(TCC.MODEL.ModelPai model)
        {
            base.Insere(model);
        }

        public override void ValidarDeleta(TCC.MODEL.ModelPai model)
        {
            throw new NotImplementedException();
        }

        public override void ValidarAltera(TCC.MODEL.ModelPai model)
        {
            throw new NotImplementedException();
        }
    }
}
