using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelasDesenvolvedor.MODEL
{
    class mMenu
    {
        private int idMenu;
        private string dscMenu;
        private string endMenu;
        private DateTime datAtl;
        private bool flgAtivo;

        public int IdMenu
        {
            get { return idMenu; }
            set { idMenu = value; }
        }

        public string DscMenu
        {
            get { return dscMenu; }
            set { dscMenu = value; }
        }

        public string EndMenu
        {
            get { return endMenu; }
            set { endMenu = value; }
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
