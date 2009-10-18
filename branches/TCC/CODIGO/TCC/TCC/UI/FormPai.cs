using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TCC.MODEL;

namespace TCC.UI
{
    public class FormPai : Form
    {
        protected virtual void BuscaIdMaximo()
        {
        }

        protected void FechaTela(FormPai form)
        {
            frmInicial.listaTelasAbertas.Remove(form.Name);
            form.Close();
        }

        protected void LimpaDadosTela(FormPai form)
        {
            Type tipo = null;
            ComboBox combo = null;
            try
            {
                foreach (Control controle in form.Controls)
                {
                    tipo = controle.GetType();
                    if (tipo.Equals(new TextBox().GetType()) == true)
                    {
                        controle.Text = string.Empty;
                    }
                    else if (tipo.Equals(new ComboBox().GetType()) == true)
                    {
                        ((ComboBox)controle).SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tipo = null;
                if (combo != null)
                {
                    combo.Dispose();
                    combo = null;
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormPai
            // 
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.ControlBox = false;
            this.Name = "FormPai";
            this.ResumeLayout(false);

        }
    }
}
