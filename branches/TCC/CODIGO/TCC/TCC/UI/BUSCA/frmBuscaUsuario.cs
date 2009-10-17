using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI.BUSCA
{
    public partial class frmBuscaUsuario : Form
    {
        bool _alteracao;

        mUsuario _model;

        #region Construtor
        public frmBuscaUsuario()
        {
            InitializeComponent();
            this._alteracao = true;
        }

        public frmBuscaUsuario(mUsuario modelUsuario)
        {
            InitializeComponent();
            _model = modelUsuario;
            this._alteracao = false;
        }
        #endregion

        #region Atributos
        TextBox _txtParam;
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rUsuario regraUsuario = new rUsuario();
            DataTable dt = new DataTable();
            try
            {
                dt = regraUsuario.BuscaUsuario(this.txtFiltro.Text);
                dgUsuario.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regraUsuario = null;
                dt = null;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewCell dvC = null;
            DataTable dtSource = new DataTable();
            try
            {
                dtSource = (DataTable)this.dgUsuario.DataSource;
                if (this.dgUsuario.DataSource != null)
                {
                    if (dtSource.Rows.Count > 0)
                    {
                        if (this._alteracao == false)
                        {
                            //Atribui a coluna e a linha que esta selecionada a um objeto do tipo DataGridViewCell
                            //------------------------------------------------------------------------------------
                            dvC = this.dgUsuario["id_usu", this.dgUsuario.CurrentRow.Index];
                            _model.IdUsuario = Convert.ToInt32(dvC.Value);
                            dvC = this.dgUsuario["Usuário", this.dgUsuario.CurrentRow.Index];
                            _model.Login = dvC.Value.ToString();
                            this.Close();
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("É necessário Cadastrar um Usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("É necessário Buscar e Selecionar um Usuário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dvC != null)
                {
                    dvC.Dispose();
                    dvC = null;
                }
                if (dtSource != null)
                {
                    dtSource.Dispose();
                    dtSource = null;
                }
            }
        }
        #endregion
    }
}
