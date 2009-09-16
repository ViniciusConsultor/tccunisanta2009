﻿using System;
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
    public partial class frmCadCliente : Form
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
                this.cboEstado.DisplayMember = "slg_estado";
                this.cboEstado.ValueMember = "id_estado";
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

        private void BuscaIdMaximo()
        {
            rCliente regra = new rCliente();
            try
            {
                this.txtCodigo.Text = regra.BuscaIdMaximoCliente().ToString();
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

        private mCliente PegaDadosTela()
        {
            mCliente model = new mCliente();
            try
            {
                model.Bairro = this.txtBairro.Text;
                model.Cep = Convert.ToInt32(this.txtCep.Text + this.txtCep2.Text);
                model.Cidade = this.txtCidade.Text;
                model.Cnpj = Convert.ToInt32(this.txtCnpj.Text);
                model.ComplementoEndereco = this.txtComplemento.Text;
                model.DatAtl = DateTime.Now;
                model.FlgAtivo = true;
                model.IdCliente = Convert.ToInt32(this.txtCodigo.Text);
                model.IdEstado = Convert.ToInt32(this.cboEstado.SelectedValue);
                model.NomeCliente = this.txtNome.Text;
                model.NomeRua = this.txtRua.Text;
                model.NumeroEndereco = Convert.ToInt32(this.txtNumero.Text);
                model.Rg = Convert.ToInt32(this.txtRg.Text);
                model.TelefoneCliente = this.txtTelefone.Text;
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
                    if (controle.Name.Equals("txtCodigo") == false)
                    {
                        controle.Text = string.Empty;
                    }
                }
            }
            this.cboEstado.SelectedIndex = 0;
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCep.TextLength == 5)
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
        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
            this.BuscaEstados();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            rCliente regra = new rCliente();
            mCliente model;
            try
            {
                model = this.PegaDadosTela();
                regra.CadastraCliente(model);
                this.ApagaControles();
                this.BuscaIdMaximo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
                model = null;
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            this.ApagaControles();
        }
    }
}