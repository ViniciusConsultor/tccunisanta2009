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
    public partial class frmCadDepartamento : FormPai
    {
        #region Construtor
        public frmCadDepartamento()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region Form Load
        private void frmCadDepartamento_Load(object sender, EventArgs e)
        {
        }
        #endregion Form Load

        #region btnConfirma Click
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Insere();
        }
        #endregion btnConfirma Click

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            base.LimpaDadosTela(this);
        }
        #endregion btnLimpar Click

        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            base.FechaTela(this);
        }
        #endregion btnVoltar Click

        #region txtNomeDepartamento TextChanged
        private void txtNomeDepartamento_TextChanged(object sender, EventArgs e)
        {
            this.btnConfirma.Enabled = true;
        }
        #endregion txtNomeDepartamento TextChanged

        #endregion Eventos

        #region Metodos

        #region Insere
        /// <summary>
        /// Insere no banco os dados do model
        /// </summary>
        private void Insere()
        {
            BUSINESS.rDepartamento regraDep = new TCC.BUSINESS.rDepartamento();
            try
            {
                this.ValidaDadosNulos();
                regraDep.ValidarInsere(this.PegaDadosTela());
                base.LimpaDadosTela(this);
                this.btnConfirma.Enabled = false;

                MessageBox.Show("Registro Salvo com Sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

            }
            catch (BUSINESS.Exceptions.Departamento.NomeDepartamentoExistenteException)
            {
                MessageBox.Show("Nome do Departamento já Cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNomeDepartamento.Focus();
            }
            catch (BUSINESS.Exceptions.Departamento.NomeDepartamentoVazioException)
            {
                MessageBox.Show("É Necessário Preencher o campo Nome do Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.txtNomeDepartamento.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion Insere

        #region Pega Dados Tela
        /// <summary>
        /// Pega os dados da tela e popula o model
        /// </summary>
        /// <returns></returns>
        private mDepartamento PegaDadosTela()
        {
            mDepartamento model = new mDepartamento();
            rDepartamento regra = new rDepartamento();

            try
            {
                model.IdDepto = regra.BuscaIdMaximo();
                model.DscDepto = this.txtDescricaoDepartamento.Text;
                model.FlgAtivo = true;
                model.DatAtl = DateTime.Now;
                model.NomeDepto = this.txtNomeDepartamento.Text;
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion Pega Dados Tela

        #region Valida Dados Nulos
        /// <summary>
        /// Valida os dados nulos
        /// </summary>
        private void ValidaDadosNulos()
        {
            if (string.IsNullOrEmpty(this.txtNomeDepartamento.Text) == true)
            {
                throw new BUSINESS.Exceptions.Departamento.NomeDepartamentoVazioException();
            }
        }
        #endregion Valida Dados Nulos 

        #endregion Metodos
    }
}
