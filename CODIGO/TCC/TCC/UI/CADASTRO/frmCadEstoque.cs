using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmCadEstoque : FormPai
    {
        mDepartamento _modelDepartamento;
        public frmCadEstoque()
        {
            InitializeComponent();
        }

        private mEstoque PegaDadosTela()
        {
            mEstoque model = new mEstoque();
            rEstoque regra = new rEstoque();

            try
            {
                model.Id_depto = Convert.ToInt32 (this._modelDepartamento.IdDepto);
                model.Dsc_estoque = this.txtNome.Text;
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
                model.Flg_negativo = this.ckbFlgNegativo.Checked;

                return model;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                model = null;
            }
        }
        
        private void btnInsere_Click(object sender, EventArgs e)
        {
            rEstoque regra = new rEstoque();
            mEstoque model;
            try
            {
                this.ValidaCamposNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.btnLimpa_Click(null, null);
            }
            catch (BUSINESS.Exceptions.CodigoDepartamentoVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnBuscaDepartamento.Focus();
            }
            catch (BUSINESS.Exceptions.Estoque.NomEstoqueVazioException)
            {
                MessageBox.Show("É Necessário cadastrar o nome do Estoque", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                regra = null;
                model = null;
            }
        }

        private void frmCadEstoque_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscaDepartamento_Click(object sender, EventArgs e)
        {
            this._modelDepartamento = new mDepartamento();
            frmBuscaDepartamento objFormBuscaDep = new frmBuscaDepartamento(this._modelDepartamento);
            try
            {
                DialogResult resultado = objFormBuscaDep.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelDepartamento = null;
                }
                else
                {
                    this.txtCdDepartamento.Text = this._modelDepartamento.DscDepto;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFormBuscaDep = null;
            }
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelDepartamento = null;
        }

        private void ValidaCamposNulos()
        {
            if (this._modelDepartamento == null)
            {
                throw new BUSINESS.Exceptions.CodigoDepartamentoVazioException();
            }
            else if (string.IsNullOrEmpty(this.txtNome.Text) == true)
            {
                throw new BUSINESS.Exceptions.Estoque.NomEstoqueVazioException();
            }
        }
    }
}
