using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmCadCliente : FormPai
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void BuscaEstados()
        {
            rEstado regraEstado = new rEstado();
            try
            {
                this.cboEstado.DisplayMember = "slg_est";
                this.cboEstado.ValueMember = "Estado";
                this.cboEstado.DataSource = regraEstado.BuscaEstado();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraEstado = null;
            }
        }

        private mCliente PegaDadosTela()
        {
            mCliente model = new mCliente();
            rCliente regra = new rCliente();

            try
            {
                if (string.IsNullOrEmpty(this.txtBairro.Text) == true)
                {
                    model.Bairro = null;
                }
                else
                {
                    model.Bairro = this.txtBairro.Text;
                }
                if (this.txtCep.Modified == false)
                {
                    model.Cep = null;
                }
                else
                {
                    model.Cep = Convert.ToInt32(this.txtCep.Text.Replace("-",String.Empty));
                }
                model.Cidade = this.txtCidade.Text;
                if (string.IsNullOrEmpty(this.txtCnpj.Text) == true)
                {
                    model.Cnpj = null;
                }
                else
                {
                    model.Cnpj = Convert.ToInt32(this.txtCnpj.Text);
                }
                model.ComplementoEndereco = this.txtComplemento.Text;
                model.DatAtl = DateTime.Now;
                model.FlgAtivo = true;
                model.IdCliente = Convert.ToInt32(regra.BuscaIdMaximoCliente());
                model.SlgEstado = this.cboEstado.GetItemText(this.cboEstado.SelectedItem);
                model.NomeCliente = this.txtNome.Text;
                model.NomeRua = this.txtRua.Text;
                if (string.IsNullOrEmpty(this.txtNumero.Text) == true)
                {
                    model.NumeroEndereco = null;
                }
                else
                {
                    model.NumeroEndereco = Convert.ToInt32(this.txtNumero.Text);
                }
                if (string.IsNullOrEmpty(this.maskedTextBox1.Text) == true)
                {
                    model.Rg = null;
                }
                else
                {
                    model.Rg = Convert.ToInt32(this.maskedTextBox1.Text);
                }
                model.TelefoneCliente = this.txtTelefone.Text;
                if (string.IsNullOrEmpty(this.txtDDD.Text) == true)
                {
                    model.Ddd = null;
                }
                else
                {
                    model.Ddd = Convert.ToInt32(this.txtDDD.Text);
                }
                if (string.IsNullOrEmpty(this.txtEmail.Text) == true)
                {
                    model.Email = null;
                }
                else
                {
                    model.Email = this.txtEmail.Text;
                }
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

       
        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
            this.BuscaEstados();
            this.AtribuiTipoTextBox();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            rCliente regra = new rCliente();
            mCliente model;
            try
            {
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
                this.BuscaIdMaximo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                regra = null;
                model = null;
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this.BuscaIdMaximo();
        }

        /*protected override void BuscaIdMaximo()
        {
            rCliente regra = new rCliente();
            try
            {
                this.txtCodigo.Text = regra.BuscaIdMaximoCliente();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
            }
        }*/

        void btnVolta_Click(object sender, System.EventArgs e)
        {
            base.FechaTela(this);
        }

        private void AtribuiTipoTextBox()
        {
            txtDDD._tipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            txtNumero._tipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;
            txtTelefone._tipoTexto = Controles.MegaTextBox.TipoTexto.Numerico;           
        }
    }
}
