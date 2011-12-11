using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Controles.MegaMaskedTextBox
{
    public enum TipoMascara
    {
        Rg,
        Numerico
    }
    
    public partial class MegaMaskedTextBox : MaskedTextBox
    {
        TipoMascara _tipoMasc;


        public MegaMaskedTextBox()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(MegaMaskedTextBox_KeyPress);
            this.AtribuiMacaraMaskedTextBox();
        }

        public MegaMaskedTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(MegaMaskedTextBox_KeyPress);
            this.MouseClick += new MouseEventHandler(MegaMaskedTextBox_MouseClick);
            this.MouseLeave += new EventHandler(MegaMaskedTextBox_MouseLeave);
            this.AtribuiMacaraMaskedTextBox();
        }

        void MegaMaskedTextBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        void MegaMaskedTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor.Hide();
        }

        private void AtribuiMacaraMaskedTextBox()
        {
            this.Mask = "0000000000000.00";
            this.ValidatingType = typeof(int);
        }

        void MegaMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tamanhoAtual = this.Text.Length;
            this.Text.Insert(tamanhoAtual, e.KeyChar.ToString());
        }
    }
}
