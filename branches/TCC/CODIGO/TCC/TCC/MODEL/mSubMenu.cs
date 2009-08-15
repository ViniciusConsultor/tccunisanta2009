using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCC.MODEL
{
    class mSubMenu
    {
        private int idSubMenu;
        private string dscSubMenu;
        private string endSubMenu;
        private bool flgAtivo;
        private DateTime datAtl;


        public int IdSubMenu
        {
            get { return idSubMenu; }
            set { idSubMenu = value; }
        }


        public string DscSubMenu
        {
            get { return dscSubMenu; }
            set { dscSubMenu = value; }
        }


        public string EndSubMenu
        {
            get { return endSubMenu; }
            set { endSubMenu = value; }
        }


        public DateTime DatAtl
        {
            get { return datAtl = DateTime.Now; }
            set { datAtl = value; }
        }


        public bool FlgAtivo
        {
            get { return flgAtivo = true; }
            set { flgAtivo = value; }
        }
    }
}
