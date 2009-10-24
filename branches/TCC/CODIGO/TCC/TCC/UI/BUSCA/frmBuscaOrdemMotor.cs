using System;
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
    public partial class frmBuscaOrdemMotor : Form
    {
        mOrdemProducao modelOrdemProd;

        public frmBuscaOrdemMotor(mOrdemProducao model)
        {
            InitializeComponent();
            modelOrdemProd = model;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PopulaGrid();
        }

        private void PopulaGrid()
        {
            rOrdemProducao regra = new rOrdemProducao();
            DataTable dt = new DataTable();
            try
            {
                dt = regra.BuscaOrdemProducao(this.txtFiltro.Text);
                this.dgCdOrdemMotor.DataSource = dt;
                dgCdOrdemMotor.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
                if (dt != null)
                {
                    dt.Dispose();
                    dt = null;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.RetornaModel();
        }

        private void RetornaModel()
        {
            DataGridViewCell dvc = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgCdOrdemMotor.DataSource;
                if (this.dgCdOrdemMotor.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this.dgCdOrdemMotor.CurrentRow != null)
                        {
                            dvc = this.dgCdOrdemMotor["id_ordem", this.dgCdOrdemMotor.CurrentRow.Index];
                            this.modelOrdemProd.Id_ordem = Convert.ToInt32(dvc.Value);
                            dvc = this.dgCdOrdemMotor["Ordem", this.dgCdOrdemMotor.CurrentRow.Index];
                            this.modelOrdemProd.Dsc_ordem = dvc.Value.ToString();
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
                        MessageBox.Show("É necessário cadastrar uma Ordem de Produção", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário buscar e selecionar uma Ordem de Produção", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
