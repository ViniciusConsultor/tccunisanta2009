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
    public partial class frmCadPeca : FormPai
    {
        #region Atributos
        mEstoque _modelEstoque;
        mTipoPeca _modelTipoPeca;
        #endregion Atributos

        #region Construtor
        public frmCadPeca()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region btnCdTipoPeca Click
        private void btnCdTipoPeca_Click(object sender, EventArgs e)
        {
            this._modelTipoPeca = new mTipoPeca();
            frmBuscaTipoPeca objTela = new frmBuscaTipoPeca(_modelTipoPeca);
            try
            {
                DialogResult resultado = objTela.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    this._modelTipoPeca = null;
                }
                else
                {
                    this.txtCdTipoPeca.Text = this._modelTipoPeca.DscTipoPeca;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objTela = null;
            }
        }
        #endregion btnCdTipoPeca Click

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
            this._modelEstoque = null;
            this._modelTipoPeca = null;
        }
        #endregion btnLimpar Click

        #region btnConfirmar Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnConfirmar Click

        #region txtCdTipoPeca Changed
        private void txtCdTipoPeca_TextChanged(object sender, EventArgs e)
        {
            this.btnConfirma.Enabled = true;
        }
        #endregion txtCdTipoPeca Changed

        #region btnRelacionarFornecedor Click
        private void btnRelacionarFornecedor_Click(object sender, EventArgs e)
        {
            this.ValidaDadosNulos();
            mPeca model = this.PegaDadosTela();
            frmPecaFornecedor obj = new frmPecaFornecedor(model.IdPeca, model.Nom);
            obj.ShowDialog();
        }
        #endregion btnRelacionarFornecedor Click

        #region btnRelacionarEstoque Click
        private void btnRelacionarEstoque_Click(object sender, EventArgs e)
        {
            this.ValidaDadosNulos();
            mPeca model = this.PegaDadosTela();
            frmCadPecaEstoque obj = new frmCadPecaEstoque(model);
            obj.ShowDialog();
        }
        #endregion btnRelacionarEstoque Click

        #endregion Eventos

        #region Metodos

        /// <summary>
        /// Abre a tela de relacionar a peça com o estoque
        /// </summary>
        private void AbreTelaRelacionarEstoque()
        {

        }

        #region PegaDadosTela
        private mPeca PegaDadosTela()
        {
            mPeca model = new mPeca();
            rPeca regra = new rPeca();

            try
            {
                model.IdPeca = regra.BuscaIdMaximo();
                model.DatAlt = DateTime.Now;
                model.DscPeca = this.txtDsPeca.Text;
                model.FlgAtivo = true;
                model.IdPecaReal = this.txtCodigoReal.Text;
                model.IdTipoPeca = Convert.ToInt32(this._modelTipoPeca.IdTipoPeca);
                model.Nom = this.txtNmPeca.Text;
                if (string.IsNullOrEmpty(this.txtPesoPeca.Text) == true)
                {
                    model.Peso = null;
                }
                else
                {
                    model.Peso = Convert.ToDecimal(this.txtPesoPeca.Text);
                }
                if (string.IsNullOrEmpty(this.txtQtdPeca.Text) == true)
                {
                    model.QtdMin = null;
                }
                else
                {
                    model.QtdMin = Convert.ToInt32(this.txtQtdPeca.Text);
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
        #endregion PegaDadosTela

        #region Insere
        private void Insere()
        {
            mPeca model;
            rPeca regra = new rPeca();
            try
            {
                this.ValidaDadosNulos();
                model = this.PegaDadosTela();
                regra.ValidarInsere(model);
                base.LimpaDadosTela(this);
                this.btnConfirma.Enabled = false;
                MessageBox.Show("Registro salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
            catch (BUSINESS.Exceptions.CodigoTipoPecaVazioException)
            {
                MessageBox.Show("O código do Tipo da Peça não pode ser vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.btnCdTipoPeca.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.CodigoPecaVazioException)
            {
                MessageBox.Show("O código da Peça não pode ser vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodigoReal.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.PecaJaExistenteException)
            {
                MessageBox.Show("Peça já existente favor cadastrar outro Código Real", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtCodigoReal.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.NomePecaVazioException)
            {
                MessageBox.Show("Digitar o nome da Peça", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNmPeca.Focus();
            }
            catch (BUSINESS.Exceptions.Peca.QtdMinimaNuloOuZeroException)
            {
                MessageBox.Show("A quantidade mínima da Peça deve ser maior que zero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtQtdPeca.Focus();
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
        #endregion Insere

        #region ValidaDadosNulos
        private void ValidaDadosNulos()
        {
            if (this._modelTipoPeca == null)
            {
                throw new BUSINESS.Exceptions.CodigoTipoPecaVazioException();
            }
            else if (string.IsNullOrEmpty(this.txtCodigoReal.Text) == true)
            {
                throw new BUSINESS.Exceptions.Peca.CodigoPecaVazioException();
            }
            else if (string.IsNullOrEmpty(this.txtNmPeca.Text) == true)
            {
                throw new BUSINESS.Exceptions.Peca.NomePecaVazioException();
            }
            else if (string.IsNullOrEmpty(this.txtQtdPeca.Text) == true)
            {
                throw new BUSINESS.Exceptions.Peca.QtdMinimaNuloOuZeroException();
            }
        }
        #endregion ValidaDadosNulos

        #endregion Metodos
    }
}
