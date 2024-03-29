﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.Regra;
using TCC.Mapper;

namespace TCC.UI
{
    public partial class frmCadPedidoVenda : FormPai
    {
        mDepartamento _modelDepartamento;
        mVenda _modelVenda;

        public frmCadPedidoVenda()
        {
            InitializeComponent();
        }

        private void frmCadPedidoVenda_Load(object sender, EventArgs e)
        {
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelDepartamento = null;
            this._modelVenda = null;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }

        /*protected override void BuscaIdMaximo()
        {
            rPedidoVenda regra = new rPedidoVenda();
            try
            {
                this.txtCdPedidoVenda.Text = regra.BuscaidMaximo();
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

       /* private void btnBuscaVendaMotor_Click(object sender, EventArgs e)
        {
            this._modelVenda = new mVenda();
            frmBuscaVenda objForm = new frmBuscaVenda(this._modelVenda);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelVenda = null;
                }
                else
                {
                    this.txtCdVendaMotor.Text = this._modelVenda.IdVenda.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                objForm = null;
            }
        }
        */
        private void btnBuscaDepartamento_Click(object sender, EventArgs e)
        {
            this._modelDepartamento = new mDepartamento();
            frmBuscaDepartamento objForm = new frmBuscaDepartamento(this._modelDepartamento);
            try
            {
                DialogResult resultado = objForm.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelDepartamento = null;
                    this.txtCdDepartamento.Text = string.Empty;
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
                objForm = null;
            }
        }

        private mPedidoVenda PegaDadosTela()
        {
            mPedidoVenda model = new mPedidoVenda();
            rVendaProduto regra = new rVendaProduto();

            try
            {
                model.DatAlt = DateTime.Now;
                model.DscVenda = this.txtDsPedido.Text;
                model.IdDepto = Convert.ToInt32(this._modelDepartamento.IdDepto);
                model.IdVenda = this._modelVenda.IdVenda;

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

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Insere();
        }

        private void Insere()
        {
            mPedidoVenda model;
            rVendaProduto regra = new rVendaProduto();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                this.btnLimpar_Click(null, null);
                MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (TCC.Regra.Exceptions.CodigoDepartamentoVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código do Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (TCC.Regra.Exceptions.CodigoVendaVazioException)
            {
                MessageBox.Show("É Necessário Buscar o código da Venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                model = null;
                regra = null;
            }
        }

        private void ValidaDadosNulos()
        {
            if (this._modelDepartamento == null)
            {
                throw new TCC.Regra.Exceptions.CodigoDepartamentoVazioException();
            }
            else if (this._modelVenda == null)
            {
                throw new TCC.Regra.Exceptions.CodigoVendaVazioException();
            }
        }

        private void btnBuscaPeca_Click(object sender, EventArgs e)
        {

        }
    }
}
 