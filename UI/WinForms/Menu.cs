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
    public partial class Menu : Form
    {
        private GrupoEntidades GE;
        private TipoEntidades TE;
        private AcercaDe AcerDe;
        private Login LG;
        public Menu()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void GrupoE_Click(object sender, EventArgs e)
        {
            if (GE == null) 
            {
                GE = new GrupoEntidades();
                GE.MdiParent = this;
                GE.FormClosed += new FormClosedEventHandler(CerrarGE);
                GE.Show();
            }
            else 
            {
                GE.Activate();
            }
        }

        void CerrarGE(object sender, FormClosedEventArgs e)
        {
            GE = null;
        }

        private void GE_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TipoE_Click(object sender, EventArgs e)
        {
            if (TE == null)
            {
                TE = new TipoEntidades();
                TE.MdiParent = this;
                TE.FormClosed += new FormClosedEventHandler(CerrarTE);
                TE.Show();
            }
            else
            {
                TE.Activate();
            }
        }

        void CerrarTE(object sender, FormClosedEventArgs e)
        {
            TE = null;
        }

        private void AcercaD_Click(object sender, EventArgs e)
        {
            if (AcerDe == null)
            {
                AcerDe = new AcercaDe();
                AcerDe.MdiParent = this;
                AcerDe.FormClosed += new FormClosedEventHandler(CerrarAcerDe);
                AcerDe.Show();
            }
            else
            {
                AcerDe.Activate();
            }
        }

        void CerrarAcerDe(object sender, FormClosedEventArgs e)
        {
            AcerDe = null;
        }

        private void Log_Click(object sender, EventArgs e)
        {
            if (LG == null)
            {
                LG = new Login();
                LG.MdiParent = this;
                LG.FormClosed += new FormClosedEventHandler(CerrarLG);
                LG.Show();
            }
            else
            {
                LG.Activate();
            }
        }

        void CerrarLG(object sender, FormClosedEventArgs e)
        {
            LG = null;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
