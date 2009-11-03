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
    public partial class frmCadTipoMotor : FormPai
    {
        mTipoMotor _mTipoMotor;

        public frmCadTipoMotor()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        /*protected override void BuscaIdMaximo()
        {
            rTipoMotor regra = new rTipoMotor();
            try
            {
                this.txtCdTipoMotor.Text = regra.BuscaIdMaximo();
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

        private void frmCadTipoMotor_Load(object sender, EventArgs e)
        {
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void Insere()
        {
            mTipoMotor model;
            rTipoMotor regra = new rTipoMotor();
            try
            {
                model = this.PedaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
            }
            catch (BUSINESS.Exceptions.TipoMotor.NumeroTipoMotorVazioExeption)
            {
                MessageBox.Show("Preencher campo Numero do Tipo do Motor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtIdReal.Focus();
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

        private mTipoMotor PedaDadosTela()
        {
            mTipoMotor model = new mTipoMotor();
            rTipoMotor regra = new rTipoMotor();
            try
            {
                model.IdTipoMotorReal = this.txtIdReal.Text;
                model.DscTipoMotor = this.txtNmTipoMotor.Text;
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
        public void ValidaDadosNulos()
        {
            try
            {
                if (this._mTipoMotor == null)
                {
                    throw new BUSINESS.Exceptions.TipoMotor.NumeroTipoMotorVazioExeption();
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
    }
}