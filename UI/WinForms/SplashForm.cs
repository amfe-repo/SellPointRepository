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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void CmpTemp_Tick(object sender, EventArgs e)
        {
            this.pnlCharge.Width += 20;
            if (pnlCharge.Width >= pnlBaseCharge.Width)
            {
                CmpTemp.Stop();
                this.Close();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            CmpTemp.Start();
        }
    }
}
