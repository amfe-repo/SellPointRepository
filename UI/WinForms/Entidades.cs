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
    public partial class Entidades : Form
    {
        public int id = 0;
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
            if (txtNoDocument.Text.Trim() == "")
            {
                ErrorProv4.SetError(txtNoDocument, "Error, campo vacio");
                txtNoDocument.Focus();
            }
            else
            {
                ErrorProv4.Clear();
            }
        }

        private void TXTel_TextChanged(object sender, EventArgs e)
        {
            if (txtTel.Text.Trim() == "")
            {
                ErrorProv5.SetError(txtTel, "Error, campo vacio");
                txtTel.Focus();
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
        private void reload()
        {
            DAOTableEntities dh = new DAOTableEntities();
            DAOTableEntitiesTypes entitiesType = new DAOTableEntitiesTypes();
            DAOTableEntitiesGroup entitiesGroup = new DAOTableEntitiesGroup();

            dataGridView1.DataSource = dh.GetData();

            tipoIdEntidad.Items.Clear();
            tipoIdGrupo.Items.Clear();

            foreach (DTOEntitiesGroup t in entitiesGroup.GetData())
            {
                tipoIdGrupo.Items.Add(t.IdGroupEntitie);
            }

            foreach (DTOEntitieTypes t in entitiesType.GetData())
            {
                tipoIdEntidad.Items.Add(t.IdTypeEntitie);
            }
        }

        private void Entidades_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void BTAdd3_Click(object sender, EventArgs e)
        {
            DTOEntities ent = new DTOEntities();

            ent.DescriptionEntitie = TXDescrp.Text;
            ent.DirecctionEntitie = TXDirecc.Text;
            ent.LocalityEntitie = TXLoc.Text;
            ent.TypeEntitieEntitie = tipoEntidad.Text;
            ent.TypeDocumentEntitie = tipoDocumento.Text;
            ent.DocumentNumberEntitie = decimal.Parse(txtNoDocument.Text);
            ent.PhoneEntitie = txtTel.Text;
            ent.UrlWebEntitie = TXPageW.Text;
            ent.UrlFacebookEntitie = TXFace.Text;
            ent.UrlInstagramEntitie = TXInsta.Text;
            ent.UrlTikTokEntitie = TXTiktok.Text;
            ent.UrlTwitterEntitie = TXTwitter.Text;
            ent.IdTypeEntitie = int.Parse(tipoIdEntidad.SelectedItem.ToString());
            ent.IdEntitieGroup = int.Parse(tipoIdGrupo.SelectedItem.ToString());
            ent.CrediteLimitEntitie = decimal.Parse(TXLimit.Text);
            ent.UserNameEntitie = TXUserE.Text;
            ent.PasswordEntitie = TXPassE.Text;
            ent.RoleUserEntitie = cmbUserRole.SelectedItem.ToString();
            ent.ComentaryEntitie = TXComent.Text;
            ent.StatusEntitie = cmbStatus.SelectedItem.ToString();
            ent.IsDeletedEntitie = ChF3.Checked;
 
            DAOTableEntities dh = new DAOTableEntities();
            dh.InsertData(ent);
            reload();
        }

        private void BTNRefre3_Click(object sender, EventArgs e)
        {
            DTOEntities ent = new DTOEntities();
            ent.DescriptionEntitie = TXDescrp.Text;
            ent.DirecctionEntitie = TXDirecc.Text;
            ent.LocalityEntitie = TXLoc.Text;
            ent.TypeEntitieEntitie = tipoEntidad.Text;
            ent.TypeDocumentEntitie = tipoDocumento.Text;
            ent.DocumentNumberEntitie = decimal.Parse(txtNoDocument.Text);
            ent.PhoneEntitie = txtTel.Text;
            ent.UrlWebEntitie = TXPageW.Text;
            ent.UrlFacebookEntitie = TXFace.Text;
            ent.UrlInstagramEntitie = TXInsta.Text;
            ent.UrlTikTokEntitie = TXTiktok.Text;
            ent.UrlTwitterEntitie = TXTwitter.Text;
            ent.IdTypeEntitie = int.Parse(tipoIdEntidad.SelectedItem.ToString());
            ent.IdEntitieGroup = int.Parse(tipoIdGrupo.SelectedItem.ToString());
            ent.CrediteLimitEntitie = decimal.Parse(TXLimit.Text);
            ent.UserNameEntitie = TXUserE.Text;
            ent.PasswordEntitie = TXPassE.Text;
            ent.RoleUserEntitie = cmbUserRole.SelectedItem.ToString();
            ent.ComentaryEntitie = TXComent.Text;
            ent.StatusEntitie = cmbStatus.SelectedItem.ToString();
            ent.IsDeletedEntitie = ChF3.Checked;
            ent.IdEntitie = id;

            DAOTableEntities dh = new DAOTableEntities();
            dh.UpdateData(ent);

            reload();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DTOEntities ent = new DTOEntities();
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            TXDescrp.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXDirecc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TXLoc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tipoEntidad.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tipoDocumento.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNoDocument.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtTel.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TXPageW.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            TXFace.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            TXInsta.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            TXTiktok.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            TXTwitter.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            tipoIdGrupo.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            tipoIdEntidad.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            TXLimit.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            TXUserE.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
            TXPassE.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
            cmbUserRole.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
            TXComent.Text = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
            cmbStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
            ChF3.Checked = (bool)dataGridView1.Rows[e.RowIndex].Cells[21].Value;

        }

        private void BTNDel3_Click(object sender, EventArgs e)
        {
            DAOTableEntities dh = new DAOTableEntities();
            dh.DeleteData(id);
            reload();
        }
    }
    
}


