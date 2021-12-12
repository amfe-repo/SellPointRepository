
namespace UI.WinForms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MS = new System.Windows.Forms.MenuStrip();
            this.MenuA = new System.Windows.Forms.ToolStripMenuItem();
            this.GrupoE = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoE = new System.Windows.Forms.ToolStripMenuItem();
            this.Ent = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuS = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaD = new System.Windows.Forms.ToolStripMenuItem();
            this.Log = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.LBS1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MS.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS
            // 
            this.MS.BackColor = System.Drawing.Color.White;
            this.MS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MS.BackgroundImage")));
            this.MS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MS.Dock = System.Windows.Forms.DockStyle.Left;
            this.MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuA,
            this.MenuS});
            this.MS.Location = new System.Drawing.Point(0, 0);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(126, 598);
            this.MS.TabIndex = 0;
            this.MS.Text = "Menu";
            // 
            // MenuA
            // 
            this.MenuA.BackColor = System.Drawing.Color.Transparent;
            this.MenuA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GrupoE,
            this.TipoE,
            this.Ent});
            this.MenuA.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuA.Image = ((System.Drawing.Image)(resources.GetObject("MenuA.Image")));
            this.MenuA.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MenuA.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.MenuA.Name = "MenuA";
            this.MenuA.Size = new System.Drawing.Size(113, 20);
            this.MenuA.Text = "Archivos";
            // 
            // GrupoE
            // 
            this.GrupoE.Name = "GrupoE";
            this.GrupoE.Size = new System.Drawing.Size(206, 22);
            this.GrupoE.Text = "Grupos Entidades";
            this.GrupoE.Click += new System.EventHandler(this.GrupoE_Click);
            // 
            // TipoE
            // 
            this.TipoE.Name = "TipoE";
            this.TipoE.Size = new System.Drawing.Size(206, 22);
            this.TipoE.Text = "Tipos Entidades";
            this.TipoE.Click += new System.EventHandler(this.TipoE_Click);
            // 
            // Ent
            // 
            this.Ent.Name = "Ent";
            this.Ent.Size = new System.Drawing.Size(206, 22);
            this.Ent.Text = "Entidades";
            this.Ent.Click += new System.EventHandler(this.Ent_Click);
            // 
            // MenuS
            // 
            this.MenuS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcercaD,
            this.Log,
            this.Exit});
            this.MenuS.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuS.Image = ((System.Drawing.Image)(resources.GetObject("MenuS.Image")));
            this.MenuS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuS.Name = "MenuS";
            this.MenuS.Size = new System.Drawing.Size(113, 20);
            this.MenuS.Text = "Sistema";
            // 
            // AcercaD
            // 
            this.AcercaD.Name = "AcercaD";
            this.AcercaD.Size = new System.Drawing.Size(153, 22);
            this.AcercaD.Text = "Acerca De";
            this.AcercaD.Click += new System.EventHandler(this.AcercaD_Click);
            // 
            // Log
            // 
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(153, 22);
            this.Log.Text = "Login";
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(153, 22);
            this.Exit.Text = "Salir";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Black;
            this.Status.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Status.BackgroundImage")));
            this.Status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBS1,
            this.toolStripStatusLabel1});
            this.Status.Location = new System.Drawing.Point(126, 576);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(844, 22);
            this.Status.TabIndex = 1;
            this.Status.Text = "statusStrip1";
            // 
            // LBS1
            // 
            this.LBS1.BackColor = System.Drawing.Color.Transparent;
            this.LBS1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBS1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBS1.Name = "LBS1";
            this.LBS1.Size = new System.Drawing.Size(34, 17);
            this.LBS1.Text = "LB1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel1.Text = "LB2";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 598);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.MS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MS;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MS.ResumeLayout(false);
            this.MS.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS;
        private System.Windows.Forms.ToolStripMenuItem MenuA;
        private System.Windows.Forms.ToolStripMenuItem GrupoE;
        private System.Windows.Forms.ToolStripMenuItem TipoE;
        private System.Windows.Forms.ToolStripMenuItem Ent;
        private System.Windows.Forms.ToolStripMenuItem MenuS;
        private System.Windows.Forms.ToolStripMenuItem AcercaD;
        private System.Windows.Forms.ToolStripMenuItem Log;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel LBS1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}