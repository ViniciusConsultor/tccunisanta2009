using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCC.UI.Resumo
{
    public partial class frmResumoOrdemProducao : Form
    {
        #region Atributos
        private int _idVenda;
        #endregion Atributos

        #region Construtor
        public frmResumoOrdemProducao()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos
        #region btnVoltar Click
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion btnVoltar Click

        #region btnGerarArquivo Click
        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {

        }
        #endregion btnGerarArquivo Click

        #region Form Load
        private void frmResumoOrdemProducao_Load(object sender, EventArgs e)
        {

        }
        #endregion Form Load 
        #endregion Eventos

        #region Cria Nos Tree View
        /// <summary>
        /// Cria os nós que apareceram no TreeView
        /// </summary>
        private void CriaNosTreeView()
        {

        }
        #endregion Cria Nos Tree View
    }
}