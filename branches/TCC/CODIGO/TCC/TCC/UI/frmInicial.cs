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
    public partial class frmInicial : Form
    {
        #region Atributos
        private int childFormNumber = 0;
        /// <summary>
        /// Dicionario de eventos da Classe inicial.
        /// </summary>
        private Dictionary<string, object> dicEventos = new Dictionary<string, object>();
        #endregion Atributos

        #region Construtor
        public frmInicial()
        {
            InitializeComponent();
        }
        #endregion Construtor

        #region Eventos
        #region newToolStripButton Click
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        #endregion newToolStripButton Click

        #region openToolStripButton Click
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        #endregion openToolStripButton Click

        #region SaveAsToolStripMenuItem Click
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        #endregion SaveAsToolStripMenuItem Click

        #region ExitToolsStripMenuItem Click
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion ExitToolsStripMenuItem Click

        #region CutToolStripMenuItem Click
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion CutToolStripMenuItem Click

        #region CopyToolStripMenuItem Click
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion CopyToolStripMenuItem Click

        #region PasteToolStripMenuItem Click
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion PasteToolStripMenuItem Click

        #region CascadeToolStripMenuItem Click
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        #endregion CascadeToolStripMenuItem Click

        #region TileVerticalToolStripMenuItem Click
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion TileVerticalToolStripMenuItem Click

        #region TileHorizontalToolStripMenuItem Click
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        #endregion TileHorizontalToolStripMenuItem Click

        #region ArrangeIconsToolStripMenuItem Click
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        #endregion ArrangeIconsToolStripMenuItem Click

        #region CloseAllToolStripMenuItem Click
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion CloseAllToolStripMenuItem Click
        #endregion Eventos
    }
}
