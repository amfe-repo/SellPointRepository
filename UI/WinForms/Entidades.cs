using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.WinForms
{
    public partial class Entidades : Form
    {
        public Entidades()
        {
            InitializeComponent();
        }

        private void TXDescrp_TextChanged(object sender, EventArgs e)
        {
            if (TXDescrp.Text.Trim() == "")
            {
                ErrorProv1.SetError(TXDescrp, "Error, campo vacio");
                TXDescrp.Focus();
            }
            else
            {
                ErrorProv1.Clear();
            }
        }

        private void TXDirecc_TextChanged(object sender, EventArgs e)
        {
            if (TXDirecc.Text.Trim() == "")
            {
                ErrorProv2.SetError(TXDirecc, "Error, campo vacio");
                TXDirecc.Focus();
            }
            else
            {
                ErrorProv2.Clear();
            }
        }

        private void TXLoc_TextChanged(object sender, EventArgs e)
        {
            if (TXLoc.Text.Trim() == "")
            {
                ErrorProv3.SetError(TXLoc, "Error, campo vacio");
                TXLoc.Focus();
            }
            else
            {
                ErrorProv3.Clear();
            }
        }

        private void TXND_TextChanged(object sender, EventArgs e)
        {
            if (TXND.Text.Trim() == "")
            {
                ErrorProv4.SetError(TXND, "Error, campo vacio");
                TXND.Focus();
            }
            else
            {
                ErrorProv4.Clear();
            }
        }

        private void TXTel_TextChanged(object sender, EventArgs e)
        {
            if (TXTel.Text.Trim() == "")
            {
                ErrorProv5.SetError(TXTel, "Error, campo vacio");
                TXTel.Focus();
            }
            else
            {
                ErrorProv5.Clear();
            }
        }

        private void TXPageW_TextChanged(object sender, EventArgs e)
        {
            if (TXPageW.Text.Trim() == "")
            {
                ErrorProv6.SetError(TXPageW, "Error, campo vacio");
                TXPageW.Focus();
            }
            else
            {
                ErrorProv6.Clear();
            }
        }
    }
}
