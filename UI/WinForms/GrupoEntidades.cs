using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layers.Data.DAOEntities;

namespace UI.WinForms
{
    public partial class GrupoEntidades : Form
    {
        public GrupoEntidades()
        {
            InitializeComponent();
        }

        private void GrupoEntidades_Load(object sender, EventArgs e)
        {
            DAOTableEntitiesGroup dh = new DAOTableEntitiesGroup();
            dataGridView1.DataSource = dh.GetData();
        }
    }
}
