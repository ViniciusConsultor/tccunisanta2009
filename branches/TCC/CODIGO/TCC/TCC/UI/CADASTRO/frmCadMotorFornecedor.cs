using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;
using TCC.BUSINESS;

namespace TCC.UI.CADASTRO
{
    public partial class frmCadMotorFornecedor : Form
    {
        #region Atributos
        mMotor _modelMotor;
        List<mMotorFornecedor> _listaModelMotorFornecedor;
        int? _idMotor;
        #endregion Atributos

        #region frmCadMotorFornecedor
        public frmCadMotorFornecedor()
        {
            InitializeComponent();
        }

               
        #endregion frmCadMotorFornecedor

        #region Eventos


        private void btnConfirma_Click(object sender, EventArgs e)
        {

        }

        #endregion Eventos

        #region Metodos

        #endregion Metodos
    }
}
