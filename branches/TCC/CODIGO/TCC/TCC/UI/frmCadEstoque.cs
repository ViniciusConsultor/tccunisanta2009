﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCC.BUSINESS;
using TCC.MODEL;

namespace TCC.UI
{
    public partial class frmCadEstoque : Form
    {
        public frmCadEstoque()
        {
            InitializeComponent();
        }
        private void BuscaIdMaximo()
        {
            rEstoque regra = new rEstoque();
            try
            {
                this.txtCdEstoque.Text = regra.BuscaIdMaximoEstoque().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
            }
        }
        private mEstoque PegaDadosTela()
        {
            mEstoque model = new mEstoque();
            try
            {
                model.Id_estoque = Convert.ToInt32(this.txtCdEstoque.Text);
                model.Id_depto = Convert.ToInt32(this.txtCdDepartamento.Text);
                model.Nom_estoque = this.txtNome.Text;
                model.Dat_alt = DateTime.Now;
                model.Flg_ativo = true;
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
        private void ApagaControles()
        {
            foreach (Control controle in this.Controls)
            {
                if (controle.GetType().Equals(new TextBox().GetType()) == true)
                {
                    if (controle.Name.Equals("txtCdEstoque") == false)
                    {
                        controle.Text = string.Empty;
                    }
                }
            }
        }
        private void btnInsere_Click(object sender, EventArgs e)
        {
            rEstoque regra = new rEstoque();
            mEstoque model;
            try
            {
                model = this.PegaDadosTela();
                regra.cadstraEstoque(model);
                this.ApagaControles();
                this.BuscaIdMaximo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                regra = null;
                model = null;
            }
        }

        private void frmCadEstoque_Load(object sender, EventArgs e)
        {
            this.BuscaIdMaximo();
        }

        private void btnBuscaDepartamento_Click(object sender, EventArgs e)
        {
            BUSCA.frmBuscaDepartamento objFormBuscaDep = new BUSCA.frmBuscaDepartamento(this.txtCdDepartamento);
            try
            {
                objFormBuscaDep.MdiParent = this.MdiParent;
                objFormBuscaDep.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objFormBuscaDep = null;
            }
        }
    }
}