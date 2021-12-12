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
    public partial class TipoEntidades : Form
    {
        public TipoEntidades()
        {
            InitializeComponent();
        }

        private void TXDescp2_TextChanged(object sender, EventArgs e)
        {
            if (TXDescp2.Text.Trim() == "")
            {
                ErrorProv1.SetError(TXDescp2, "Error, campo vacio");
                TXDescp2.Focus();
            }
            else
            {
                ErrorProv1.Clear();
            }
        }

        private void TXComen2_TextChanged(object sender, EventArgs e)
        {
            if (TXComen2.Text.Trim() == "")
            {
                ErrorProv1.SetError(TXComen2, "Error, campo vacio");
                TXComen2.Focus();
            }
            else
            {
                ErrorProv1.Clear();
            }
        }
    }
}
