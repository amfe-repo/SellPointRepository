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

        private void TXFace_TextChanged(object sender, EventArgs e)
        {
            if (TXFace.Text.Trim() == "")
            {
                ErrorProv7.SetError(TXFace, "Error, campo vacio");
                TXFace.Focus();
            }
            else
            {
                ErrorProv7.Clear();
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

        private void TXInsta_TextChanged(object sender, EventArgs e)
        {
            if (TXInsta.Text.Trim() == "")
            {
                ErrorProv8.SetError(TXInsta, "Error, campo vacio");
                TXInsta.Focus();
            }
            else
            {
                ErrorProv8.Clear();
            }
        }

        private void TXTwitter_TextChanged(object sender, EventArgs e)
        {
            if (TXTwitter.Text.Trim() == "")
            {
                ErrorProv9.SetError(TXTwitter, "Error, campo vacio");
                TXTwitter.Focus();
            }
            else
            {
                ErrorProv9.Clear();
            }
        }

        private void TXTiktok_TextChanged(object sender, EventArgs e)
        {
            if (TXTiktok.Text.Trim() == "")
            {
                ErrorProv10.SetError(TXTiktok, "Error, campo vacio");
                TXTiktok.Focus();
            }
            else
            {
                ErrorProv10.Clear();
            }
        }

        private void TXLimit_TextChanged(object sender, EventArgs e)
        {
            if (TXLimit.Text.Trim() == "")
            {
                ErrorProv11.SetError(TXLimit, "Error, campo vacio");
                TXLimit.Focus();
            }
            else
            {
                ErrorProv11.Clear();
            }
        }

        private void TXUserE_TextChanged(object sender, EventArgs e)
        {
            if (TXUserE.Text.Trim() == "")
            {
                ErrorProv12.SetError(TXUserE, "Error, campo vacio");
                TXUserE.Focus();
            }
            else
            {
                ErrorProv12.Clear();
            }
        }

        private void TXPassE_TextChanged(object sender, EventArgs e)
        {
            if (TXPassE.Text.Trim() == "")
            {
                ErrorProv13.SetError(TXPassE, "Error, campo vacio");
                TXPassE.Focus();
            }
            else
            {
                ErrorProv13.Clear();
            }
        }

        private void TXComent_TextChanged(object sender, EventArgs e)
        {
            if (TXComent.Text.Trim() == "")
            {
                ErrorProv14.SetError(TXComent, "Error, campo vacio");
                TXComent.Focus();
            }
            else
            {
                ErrorProv14.Clear();
            }
        }
    }
    
}


