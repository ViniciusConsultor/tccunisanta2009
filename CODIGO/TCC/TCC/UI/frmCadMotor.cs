﻿using System;
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
    public partial class frmCadMotor : Form
    {
        public frmCadMotor()
        {
            InitializeComponent();
        }

        private void BuscaIdMaximo()
        {
            rMotor regraMotor = new rMotor();
            try
            {
                this.txtCdMotor.Text = regraMotor.BuscaIdMaximoMotor().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraMotor = null;
            }
        }

        private void frmMotor_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            mMotor model;
            rMotor regra = new rMotor();
            try
            {
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.LimpaDadosTela();
                this.BuscaIdMaximo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                model = null;
                regra = null;
            }
        }

        private mMotor PegaDadosTela()
        {
            mMotor model = new mMotor();
            try
            {
                model.IdMotor = Convert.ToInt32(this.txtCdMotor.Text);
                model.DscMotor = this.txtDsMotor.Text;
                model.FlgAtivo = true;

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

        private void LimpaDadosTela()
        {
            try
            {
                foreach (Control controle in this.Controls)
                {
                    if (controle.GetType().Equals(new TextBox().GetType()) == true)
                    {
                        controle.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.LimpaDadosTela();
            this.BuscaIdMaximo();
        }
    }
}