using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
                CmpTempOpacity.Start();
                CmpTemp.Stop();  
            }
        }
        private void CmpTempOpacity_Tick(object sender, EventArgs e)
        {
            
            while(this.Opacity > 0)
            {
                this.Opacity -= 0.0001;
            }
                CmpTempOpacity.Stop();
                this.Close();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            CmpTemp.Start();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void SplashForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
