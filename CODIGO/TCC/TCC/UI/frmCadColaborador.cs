using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI
{
    public partial class frmCadColaborador : Form
    {
        public frmCadColaborador()
        {
            InitializeComponent();
        }

        #region Eventos
        private void frmCadColaborador_Load(object sender, EventArgs e)
        {
            this.BuscaCodigoColadoradorMax();
            this.PopulaComboEstados();
            CbSexo.SelectedIndex = 0;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            mColaborador modelColaborador = new mColaborador();
            BUSINESS.rCadColaborador regraMenu = new BUSINESS.rCadColaborador();
            try
            {
                modelColaborador = this.PegaDadosTela();
                regraMenu.ValidarInsere(modelColaborador);
                this.LimpaControles();
                this.BuscaCodigoColadoradorMax();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                modelColaborador = null;
            }
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            this.LimpaControles();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBuscaUsuario_Click(object sender, EventArgs e)
        {
            BUSCA.frmBuscaUsuario buscarUsuario = new BUSCA.frmBuscaUsuario(this.txtCdUsuario);
            try
            {
                buscarUsuario.MdiParent = this.MdiParent;
                buscarUsuario.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                buscarUsuario = null;
            }
        }
        private void btnBuscaDepartamento_Click(object sender, EventArgs e)
        {
            BUSCA.frmBuscaDepartamento buscarDepartamento = new BUSCA.frmBuscaDepartamento(this.txtCdDepartamento);
            try
            {
                buscarDepartamento.MdiParent = this.MdiParent;
                buscarDepartamento.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                buscarDepartamento = null;
            }
        }
        private void txtDataDd_TextChanged(object sender, EventArgs e)
        {
            if (txtDataDd.Text.Length == 2)
            {
                txtDataMm.Focus();
            }
        }
        private void txtDataMm_TextChanged(object sender, EventArgs e)
        {
            if (txtDataMm.Text.Length == 2)
            {
                txtDataYyyy.Focus();
            }
        }
        private void txtDataYyyy_TextChanged(object sender, EventArgs e)
        {
            if (txtDataYyyy.Text.Length == 4)
            {
                txtRua.Focus();
            }
        }
        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCEP.TextLength == 5)
            {
                this.txtCep2.Focus();
            }
        }
        private void txtCep2_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCep2.TextLength == 3)
            {
                this.txtBairro.Focus();
            }
        }
        #endregion

        #region Metodos
        private mColaborador PegaDadosTela()
        {
            mColaborador model = new mColaborador();
            model.BairrEnd = txtBairro.Text;
            model.Cep = txtCEP.Text+txtCep2.Text;
            model.Cidade = txtCidade.Text;
            model.ComplEnd = txtComplemento.Text;
            model.Cpf = txtCpf.Text;
            model.DatNasc = new DateTime(Convert.ToInt32(txtDataYyyy.Text),Convert.ToInt32(txtDataMm.Text),Convert.ToInt32(txtDataDd.Text));
            model.Estado = Convert.ToInt32(cbEstado.SelectedValue);
            model.IdColab = Convert.ToInt32(txtCdColab.Text);
            model.IdDepto = Convert.ToInt32(txtCdDepartamento.Text);
            model.IdUsuario = Convert.ToInt32(txtCdUsuario.Text);
            model.NomeColab = txtNome.Text;
            model.NomeRua = txtRua.Text;
            model.NroEnd = Convert.ToInt32(txtNumero.Text);
            model.Sexo = Convert.ToChar(CbSexo.Text);
            model.Rg = txtRg.Text;

            return model;
        }
        private void BuscaCodigoColadoradorMax()
        {
            rCadColaborador regraColaborador = new rCadColaborador();
            try
            {
                this.txtCdColab.Text = regraColaborador.BuscaIDMaximoColaborador().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraColaborador = null;
            }
        }
        private void PopulaComboEstados()
        {
            BUSINESS.rEstado estados = new rEstado();
            cbEstado.ValueMember = "id_estado";
            cbEstado.DisplayMember = "slg_estado";
            cbEstado.DataSource = estados.BuscaEstado();
        }
        private mUsuario PegaDadosUsuario()
        {
            mUsuario model = new mUsuario();
            model.IdUsuario = Convert.ToInt32(txtCdUsuario.Text);
            return model;
        }
        private mDepartamento PegaDadosDepto()
        {
            mDepartamento model = new mDepartamento();
            model.IdDepto = Convert.ToInt32(txtCdDepartamento);
            return model;
        }
        #region Limpa Controles
        /// <summary>
        /// Limpa os controles da tela
        /// </summary>
        private void LimpaControles()
        {
            //Varre todos os controles da tela
            //--------------------------------
            foreach (Control controle in this.Controls)
            {
                //Se for do tipo TextBox apaga o conteudo escrito
                //-----------------------------------------------
                if (controle.GetType().Equals(new TextBox().GetType()) == true)
                {
                    if(controle.Name.Equals("txtCdColab")==false)
                    {
                        controle.Text = string.Empty;
                    }
                }
            }
        }
        #endregion Limpa Controles        

        #endregion
    }
}
