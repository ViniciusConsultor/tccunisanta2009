﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.Mapper;
using TCC.Regra;

namespace TCC.UI.Resumo
{
    public partial class frmResumoKitFamilia : Form
    {
        #region Atributos
        List<mKitFamilia> _listaModelKitFamilia;
        #endregion Atributos

        #region Construtor
        public frmResumoKitFamilia(List<mKitFamilia> lista, string nomeFamiliaMotor, string nomeMotor)
        {
            InitializeComponent();
            this._listaModelKitFamilia = lista;
            this.txtNomeFamiliaMotor.Text = nomeFamiliaMotor;
            this.txtMotor.Text = nomeMotor;
        }
        #endregion Construtor

        #region Eventos
        #region frmResumoKitFamilia Load
        private void frmResumoKitFamilia_Load(object sender, EventArgs e)
        {
            DataTable dtSource = new DataTable();
            try
            {
                this.CriaColunasDataTable(dtSource);
                this.PopulaDataTableListaModel(dtSource);
                this.dgKits.DataSource = dtSource;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dtSource != null)
                {
                    dtSource.Dispose();
                    dtSource = null;
                }
            }
        }
        #endregion frmResumoKitFamilia Load

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion btnVoltar Click

        #region btnAceitar Click
        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion btnAceitar Click
        #endregion Eventos

        #region Metodos

        #region CriaColunas DataTable
        private void CriaColunasDataTable(DataTable dt)
        {
            try
            {
                dt.Columns.Add("id_kit");
                dt.Columns.Add("id_kit_real");
                dt.Columns.Add("nom");
                dt.Columns.Add("Qtd");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion CriaColunas DataTable

        #region Popula DataTable ListaModel
        /// <summary>
        /// Popula o DataTable com a table de model
        /// </summary>
        private void PopulaDataTableListaModel(DataTable dt)
        {
            DataRow linha;
            rKitGrupoPeca regraKit = new rKitGrupoPeca();
            mKitGrupoPeca modelKit = new mKitGrupoPeca();
            try
            {
                foreach (mKitFamilia model in this._listaModelKitFamilia)
                {
                    modelKit = regraKit.BuscaUnicoRegistro(Convert.ToInt32(model.Id_kit));
                    linha = dt.NewRow();
                    linha["id_kit"] = model.Id_kit;
                    linha["id_kit_real"] = modelKit.IdKitReal;
                    linha["nom"] = modelKit.Nom_grupo;
                    linha["Qtd"] = model.Qtd_kit;
                    dt.Rows.Add(linha);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                linha = null;
                regraKit = null;
                modelKit = null;
            }
        }
        #endregion Popula DataTable ListaModel

        #endregion Metodos

    }
}
