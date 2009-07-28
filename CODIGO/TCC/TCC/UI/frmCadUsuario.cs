using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TCC.UI
{
    public partial class frmCadUsuario : Form
    {
        #region Construtor
        public frmCadUsuario()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos

        #region btnLimpar Click
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.LimpaControles();
        }
        #endregion btnLimpar Click

        #endregion Eventos

        #region Metodos

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
                    controle.Text = string.Empty;
                }
            }
            this.chkAdministrador.Checked = false;
        }
        #endregion Limpa Controles

        #endregion Metodos
    }
}
