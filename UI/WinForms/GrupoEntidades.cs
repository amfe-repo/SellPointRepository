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
    public partial class GrupoEntidades : Form
    {
        public int id = 0;
        public GrupoEntidades()
        {
            InitializeComponent();
        }

        private void GrupoEntidades_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload() 
        {
            DAOTableEntitieType dh = new DAOTableEntitieType();
            dataGridView1.DataSource = dh.GetData();
        }

        private void BTAdd_Click(object sender, EventArgs e)
        {
            DTOEntitiesGroup ent = new DTOEntitiesGroup();
            ent.DescriptionGroupEntitie = TXDescp.Text;
            ent.ComentaryGroupEntitie = TXComen.Text;
            ent.StatusGroupEntitie = comboBox1.SelectedItem.ToString();
            ent.IsDeletedGroupEntitie = ChF.Checked;

            DAOTableEntitieType dh = new DAOTableEntitieType();
            dh.InsertData(ent);
            reload();
        }

        private void BTNRefre_Click(object sender, EventArgs e)
        {
            DTOEntitiesGroup ent = new DTOEntitiesGroup();
            ent.DescriptionGroupEntitie = TXDescp.Text;
            ent.ComentaryGroupEntitie = TXComen.Text;
            ent.StatusGroupEntitie = comboBox1.SelectedItem.ToString();
            ent.IsDeletedGroupEntitie = ChF.Checked;
            ent.IdGroupEntitie = id;

            DAOTableEntitieType dh = new DAOTableEntitieType();
            dh.UpdateData(ent);
            reload();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXDescp.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXComen.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            ChF.Checked = (bool)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }

        private void BTNDel_Click(object sender, EventArgs e)
        {
            DAOTableEntitieType dh = new DAOTableEntitieType();
            dh.DeleteData(id);
            reload();
        }

        private void TXDescp_TextChanged(object sender, EventArgs e)
        {
            if (TXDescp.Text.Trim() == "")
            {
                ErrorProv1.SetError(TXDescp, "Error, campo vacio");
                TXDescp.Focus();
            }
            else
            {
                ErrorProv1.Clear();
            }
        }

        private void TXComen_TextChanged(object sender, EventArgs e)
        {
            if (TXComen.Text.Trim() == "")
            {
                ErrorProv3.SetError(TXComen, "Error, campo vacio");
                TXComen.Focus();
            }
            else
            {
                ErrorProv3.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                ErrorProv2.SetError(comboBox1, "Error, campo vacio");
                comboBox1.Focus();
            }
            else
            {
                ErrorProv2.Clear();
            }
        }
    }
}
