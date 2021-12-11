
namespace UI.WinForms
{
    partial class GrupoEntidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrupoEntidades));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNDel = new System.Windows.Forms.Button();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.BTNRefre = new System.Windows.Forms.Button();
            this.BTAdd = new System.Windows.Forms.Button();
            this.LBDesc = new System.Windows.Forms.Label();
            this.TXDescp = new System.Windows.Forms.TextBox();
            this.TXComen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXEsta = new System.Windows.Forms.TextBox();
            this.ChF = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BTNDel);
            this.panel1.Controls.Add(this.BTNSearch);
            this.panel1.Controls.Add(this.BTNRefre);
            this.panel1.Controls.Add(this.BTAdd);
            this.panel1.Location = new System.Drawing.Point(544, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 373);
            this.panel1.TabIndex = 0;
            // 
            // BTNDel
            // 
            this.BTNDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNDel.BackgroundImage")));
            this.BTNDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNDel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNDel.Location = new System.Drawing.Point(30, 297);
            this.BTNDel.Name = "BTNDel";
            this.BTNDel.Size = new System.Drawing.Size(134, 48);
            this.BTNDel.TabIndex = 3;
            this.BTNDel.Text = "Borrar";
            this.BTNDel.UseVisualStyleBackColor = true;
            // 
            // BTNSearch
            // 
            this.BTNSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNSearch.BackgroundImage")));
            this.BTNSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNSearch.Location = new System.Drawing.Point(30, 206);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(134, 48);
            this.BTNSearch.TabIndex = 2;
            this.BTNSearch.Text = "Buscar";
            this.BTNSearch.UseVisualStyleBackColor = true;
            // 
            // BTNRefre
            // 
            this.BTNRefre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNRefre.BackgroundImage")));
            this.BTNRefre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNRefre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRefre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNRefre.Location = new System.Drawing.Point(30, 115);
            this.BTNRefre.Name = "BTNRefre";
            this.BTNRefre.Size = new System.Drawing.Size(134, 48);
            this.BTNRefre.TabIndex = 1;
            this.BTNRefre.Text = "Modificar";
            this.BTNRefre.UseVisualStyleBackColor = true;
            // 
            // BTAdd
            // 
            this.BTAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTAdd.BackgroundImage")));
            this.BTAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BTAdd.Location = new System.Drawing.Point(30, 25);
            this.BTAdd.Name = "BTAdd";
            this.BTAdd.Size = new System.Drawing.Size(134, 48);
            this.BTAdd.TabIndex = 0;
            this.BTAdd.Text = "Agregar";
            this.BTAdd.UseVisualStyleBackColor = true;
            // 
            // LBDesc
            // 
            this.LBDesc.AutoSize = true;
            this.LBDesc.BackColor = System.Drawing.Color.Transparent;
            this.LBDesc.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBDesc.Location = new System.Drawing.Point(86, 49);
            this.LBDesc.Name = "LBDesc";
            this.LBDesc.Size = new System.Drawing.Size(93, 16);
            this.LBDesc.TabIndex = 1;
            this.LBDesc.Text = "Descripcion";
            // 
            // TXDescp
            // 
            this.TXDescp.Location = new System.Drawing.Point(45, 68);
            this.TXDescp.Name = "TXDescp";
            this.TXDescp.Size = new System.Drawing.Size(187, 20);
            this.TXDescp.TabIndex = 2;
            // 
            // TXComen
            // 
            this.TXComen.Location = new System.Drawing.Point(296, 68);
            this.TXComen.Name = "TXComen";
            this.TXComen.Size = new System.Drawing.Size(187, 20);
            this.TXComen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(340, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Comentario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(102, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estatus";
            // 
            // TXEsta
            // 
            this.TXEsta.Location = new System.Drawing.Point(45, 128);
            this.TXEsta.Name = "TXEsta";
            this.TXEsta.Size = new System.Drawing.Size(187, 20);
            this.TXEsta.TabIndex = 7;
            // 
            // ChF
            // 
            this.ChF.AutoSize = true;
            this.ChF.BackColor = System.Drawing.Color.Transparent;
            this.ChF.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChF.Location = new System.Drawing.Point(61, 3);
            this.ChF.Name = "ChF";
            this.ChF.Size = new System.Drawing.Size(65, 20);
            this.ChF.TabIndex = 9;
            this.ChF.Text = "Falso";
            this.ChF.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(340, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "NoEliminable";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ChF);
            this.panel2.Location = new System.Drawing.Point(295, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 28);
            this.panel2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 214);
            this.dataGridView1.TabIndex = 12;
            // 
            // GrupoEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXEsta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXComen);
            this.Controls.Add(this.TXDescp);
            this.Controls.Add(this.LBDesc);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrupoEntidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GruposEntidades";
            this.Load += new System.EventHandler(this.GrupoEntidades_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNDel;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Button BTNRefre;
        private System.Windows.Forms.Button BTAdd;
        private System.Windows.Forms.Label LBDesc;
        private System.Windows.Forms.TextBox TXDescp;
        private System.Windows.Forms.TextBox TXComen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXEsta;
        private System.Windows.Forms.CheckBox ChF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}