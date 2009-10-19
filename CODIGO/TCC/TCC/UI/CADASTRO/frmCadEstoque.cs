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
        mDepartamento modelDepartamento;
        public frmCadEstoque()
        {
            InitializeComponent();
            modelDepartamento = new mDepartamento();
        }

        protected override void BuscaIdMaximo()
        {
            rEstoque regra = new rEstoque();
            try
            {
                this.txtCdEstoque.Text = regra.BuscaIdMaximoEstoque();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
            }
        }

        private mEstoque PegaDadosTela()
        {
            mEstoque model = new mEstoque();
            try
            {
                model.Id_estoque = Convert.ToInt32(this.txtCdEstoque.Text);
                model.Id_depto = Convert.ToInt32(this.txtCdDepartamento.Text);
                model.Dsc_estoque = this.txtNome.Text;
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
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
        private void ApagaControles()
        {
            foreach (Control controle in this.Controls)
            {
                if (controle.GetType().Equals(new TextBox().GetType()) == true)
                {
                    if (controle.Name.Equals("txtCdEstoque") == false)
                    {
                        controle.Text = string.Empty;
                    }
                }
            }
        }
        private void btnInsere_Click(object sender, EventArgs e)
        {
            rEstoque regra = new rEstoque();
            mEstoque model;
            try
            {
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.ApagaControles();
                this.BuscaIdMaximo();
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
            this.BuscaIdMaximo();
        }

        private void btnBuscaDepartamento_Click(object sender, EventArgs e)
        {
            frmBuscaDepartamento objFormBuscaDep = new frmBuscaDepartamento(modelDepartamento);
            try
            {
                objFormBuscaDep.ShowDialog();
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
            this.BuscaIdMaximo();
        }
    }
}
