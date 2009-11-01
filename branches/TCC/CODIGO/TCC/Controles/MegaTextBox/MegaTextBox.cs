using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Controles.MegaTextBox
{
    public enum TipoTexto
    {
        Texto,
        Numerico,
        Decimal
    }

    public partial class MegaTextBox : TextBox
    {
        public TipoTexto _tipoTexto = TipoTexto.Texto;

        public MegaTextBox()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(MegaTextBox_KeyPress);
        }

        public MegaTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.KeyPress += new KeyPressEventHandler(MegaTextBox_KeyPress);
        }

        void MegaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica o tipo de Dado que entra no MegaTextBox
            //------------------------------------------------
            if (this._tipoTexto == TipoTexto.Numerico)
            {
                //Verifica se não é "BackSpace"
                //-------------------------
                if (e.KeyChar.Equals('\b') == false)
                {
                    //Verifica se é numérico
                    //----------------------
                    if (char.IsNumber(e.KeyChar) == false)
                    {
                        //Caso não seja não deixa escrever
                        //--------------------------------
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
