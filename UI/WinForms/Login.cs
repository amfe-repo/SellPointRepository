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
    public partial class Login : Form
    {
        public static string user = "admin";
        public static string password = "admin";
        public Login()
        {
            InitializeComponent();
        }

        private void BTLog_Click(object sender, EventArgs e)
        {
            
        }

        private void TXUser_TextChanged(object sender, EventArgs e)
        {
            if (TXUser.Text.Trim() == "") 
            {
                ErrorProv1.SetError(TXUser, "Error, Introduzca el Usuario Correcto");
                TXUser.Focus();
            }
            else 
            {
                ErrorProv1.Clear();
            }
        }

        private void TXPass_TextChanged(object sender, EventArgs e)
        {
            if (TXPass.Text.Trim() == "")
            {
                ErrorProv2.SetError(TXPass, "Error, Introduzca la Contraseña Correcto");
                TXPass.Focus();
            }
            else
            {
                ErrorProv2.Clear();
            }
        }
    }
}
