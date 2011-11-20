using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace TCC.Controle
{
    public enum TipoTexto
    {
        Texto,
        Numerico,
        Decimal,
        Email,
        SoLetra,
        Rg
    }

    public partial class MegaTextBox : TextBox
    {
        private TipoTexto _tipoTexto;

        public TipoTexto TipoTexto
        {
            get { return _tipoTexto; }
            set { _tipoTexto = value; }
        }

        #region Construtores
        public MegaTextBox()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(MegaTextBox_KeyPress);
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public MegaTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.KeyPress += new KeyPressEventHandler(MegaTextBox_KeyPress);
            this.BorderStyle = BorderStyle.FixedSingle;
        }
        #endregion Construtores

        void MegaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica o tipo de Dado que entra no MegaTextBox
            //------------------------------------------------
            switch (this._tipoTexto)
            {
                case TipoTexto.Numerico:
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
                    break;
                case TipoTexto.Decimal:
                    //Verifica se não é "BackSpace", "Virgula"
                    //----------------------------------------
                    if (e.KeyChar.Equals('\b') == false && e.KeyChar.Equals(',') == false)
                    {

                        //Verifica se é numérico
                        //----------------------
                        if (char.IsNumber(e.KeyChar) == false)
                        {
                            //Caso não seja não deixa escrever
                            //--------------------------------
                            e.Handled = true;
                        }
                        else
                        {
                            if (this.Text.IndexOf(',') >= 0)
                            {
                                int local = this.Text.IndexOf(',');
                                string texto = this.Text.Substring(local);
                                if (texto.Length > 2)
                                {
                                    e.Handled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        //Não pode haver mais de um "ponto final" ou "viurgula"
                        //-----------------------------------------------------
                        if (this.Text.IndexOf(',') >= 0 && e.KeyChar.Equals('\b') == false)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
                case TipoTexto.Email:
                    if (e.KeyChar.Equals('\b') == false || e.KeyChar.Equals('.') == false || e.KeyChar.Equals(',') == false)
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
                    break;
                case TipoTexto.SoLetra:
                    //Verifica se não é "BackSpace"
                    //-------------------------
                    if (e.KeyChar.Equals('\b') == false)
                    {
                        //Verifica se é Letra
                        //----------------------
                        if (char.IsLetter(e.KeyChar) == false)
                        {
                            //Caso não seja não deixa escrever
                            //--------------------------------
                            e.Handled = true;
                        }
                    }
                    break;
                case TipoTexto.Rg:
                    //Verifica se não é "BackSpace", "Virgula"
                    //----------------------------------------
                    if (e.KeyChar.Equals('\b') == false && e.KeyChar.Equals('.') == false && e.KeyChar.Equals('-') == false && e.KeyChar.Equals('x') == false && e.KeyChar.Equals('X') == false)
                    {

                        //Verifica se é numérico
                        //----------------------
                        if (char.IsNumber(e.KeyChar) == false)
                        {
                            //Caso não seja não deixa escrever
                            //--------------------------------
                            e.Handled = true;
                        }
                        else
                        {
                            if (this.Text.IndexOf(',') >= 0)
                            {
                                int local = this.Text.IndexOf(',');
                                string texto = this.Text.Substring(local);
                                if (texto.Length > 2)
                                {
                                    e.Handled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (e.KeyChar == 'x')
                        {
                            e.KeyChar = 'X';
                        }
                        if (e.KeyChar.Equals('-') == true && this.Text.IndexOf('-') >= 0 && e.KeyChar.Equals('\b') == false)
                        {
                            e.Handled = true;
                        }
                        if (e.KeyChar.Equals('X') == true && this.Text.IndexOf('X') >= 0 && e.KeyChar.Equals('\b') == false)
                        {
                            e.Handled = true;
                        }
                        else if (e.KeyChar.Equals('.') == true &&this.Text.Split('.').Length >= 3 && e.KeyChar.Equals('\b') == false)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
            }
        }
    }
}
