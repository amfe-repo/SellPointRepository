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
using Layers.Data.DTOStructData;

namespace UI.WinForms
{
    public partial class TipoEntidades : Form
    {
        public int id = 0;
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

        private void reload()
        {
            DAOTableEntitiesTypes dh = new DAOTableEntitiesTypes();
            DAOTableEntitieType entitiesGroup = new DAOTableEntitieType();
            
            DGV2.DataSource = dh.GetData();
            
            CBT.Items.Clear();

            foreach (DTOEntitiesGroup t in entitiesGroup.GetData()) 
            {
                CBT.Items.Add(t.IdGroupEntitie);
            }

        }

        private void BTAdd2_Click(object sender, EventArgs e)
        {
            DTOEntitieTypes ent = new DTOEntitieTypes();
            ent.DescriptionTypeEntitie = TXDescp2.Text;
            ent.ComentaryTypeEntitie = TXComen2.Text;
            ent.StatusTypeEntitie = comboBox1.SelectedItem.ToString();
            ent.IsDeletedTypeEntitie = ChF2.Checked;
            ent.IdEntitieGroup = int.Parse(CBT.Text);

            DAOTableEntitiesTypes dh = new DAOTableEntitiesTypes();
            dh.InsertData(ent);
            reload();
        }

        private void DGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)DGV2.Rows[e.RowIndex].Cells[0].Value;
            TXDescp2.Text = DGV2.Rows[e.RowIndex].Cells[1].Value.ToString();
            CBT.Text = DGV2.Rows[e.RowIndex].Cells[2].Value.ToString();
            TXComen2.Text = DGV2.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox1.Text = DGV2.Rows[e.RowIndex].Cells[4].Value.ToString();
            ChF2.Checked = (bool)DGV2.Rows[e.RowIndex].Cells[5].Value;
        }

        private void TipoEntidades_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void BTNDel2_Click(object sender, EventArgs e)
        {
            DAOTableEntitieType dh = new DAOTableEntitieType();
            dh.DeleteData(id);
            reload();
        }

        private void BTNRefre2_Click(object sender, EventArgs e)
        {
            DTOEntitieTypes ent = new DTOEntitieTypes();
            ent.DescriptionTypeEntitie = TXDescp2.Text;
            ent.ComentaryTypeEntitie = TXComen2.Text;
            ent.StatusTypeEntitie = comboBox1.SelectedItem.ToString();
            ent.IsDeletedTypeEntitie = ChF2.Checked;
            ent.IdEntitieGroup = int.Parse(CBT.SelectedItem.ToString());
            ent.IdTypeEntitie = id;

            DAOTableEntitiesTypes dh = new DAOTableEntitiesTypes();
            dh.UpdateData(ent);
            reload();
        }
    }
}
