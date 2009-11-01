﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmBuscaKit : Form
    {
        #region Atributos
        mKitGrupoPeca _model;
        #endregion

        #region Construtor
        public frmBuscaKit(mKitGrupoPeca modelKit)
        {
            InitializeComponent();
            this._model = modelKit;
        }
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RetornaModel();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region Metodos

        private void PopulaGrid()
        {
            rKitGrupoPeca regra = new rKitGrupoPeca();
            DataTable dt = new DataTable();
            try
            {
                dt = regra.BuscaKitGrupoPeca(this.txtFiltro.Text);
                dgKit.DataSource = dt;
                dgKit.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
                dt = null;
            }
        }

        private void RetornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgKit.DataSource;
                if (this.dgKit.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgKit.CurrentRow != null)
                        {
                            dvc = this.dgKit["id_kit", this.dgKit.CurrentRow.Index];
                            this._model.IdKit = Convert.ToInt32(dvc.Value);
                            dvc = this.dgKit["Kit Grupo Peça", this.dgKit.CurrentRow.Index];
                            this._model.Nom_grupo = dvc.Value.ToString();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("É necessário Selecionar uma linha", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("É necessário cadastrar um Kit Grupo Peça", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar um Kit Grupo Peça", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dvc != null)
                {
                    dvc.Dispose();
                    dvc = null;
                }
                if (dtSource != null)
                {
                    dtSource.Dispose();
                    dtSource = null;
                }
            }
        }
        #endregion
    }
}