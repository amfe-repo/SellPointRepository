namespace UI.WinForms
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.CmpTemp = new System.Windows.Forms.Timer(this.components);
            this.pnlBaseCharge = new System.Windows.Forms.Panel();
            this.pnlCharge = new System.Windows.Forms.Panel();
            this.CmpTempOpacity = new System.Windows.Forms.Timer(this.components);
            this.LBSP = new System.Windows.Forms.Label();
            this.PBAD = new System.Windows.Forms.PictureBox();
            this.pnlBaseCharge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAD)).BeginInit();
            this.SuspendLayout();
            // 
            // CmpTemp
            // 
            this.CmpTemp.Enabled = true;
            this.CmpTemp.Tick += new System.EventHandler(this.CmpTemp_Tick);
            // 
            // pnlBaseCharge
            // 
            this.pnlBaseCharge.BackColor = System.Drawing.Color.Indigo;
            this.pnlBaseCharge.Controls.Add(this.pnlCharge);
            this.pnlBaseCharge.Location = new System.Drawing.Point(-1, 383);
            this.pnlBaseCharge.Name = "pnlBaseCharge";
            this.pnlBaseCharge.Size = new System.Drawing.Size(674, 15);
            this.pnlBaseCharge.TabIndex = 0;
            // 
            // pnlCharge
            // 
            this.pnlCharge.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlCharge.Location = new System.Drawing.Point(0, 0);
            this.pnlCharge.Name = "pnlCharge";
            this.pnlCharge.Size = new System.Drawing.Size(48, 21);
            this.pnlCharge.TabIndex = 0;
            // 
            // CmpTempOpacity
            // 
            this.CmpTempOpacity.Tick += new System.EventHandler(this.CmpTempOpacity_Tick);
            // 
            // LBSP
            // 
            this.LBSP.AutoSize = true;
            this.LBSP.BackColor = System.Drawing.Color.Transparent;
            this.LBSP.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBSP.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LBSP.Location = new System.Drawing.Point(267, 277);
            this.LBSP.Name = "LBSP";
            this.LBSP.Size = new System.Drawing.Size(123, 29);
            this.LBSP.TabIndex = 6;
            this.LBSP.Text = "SellPoint";
            // 
            // PBAD
            // 
            this.PBAD.BackColor = System.Drawing.Color.Transparent;
            this.PBAD.Image = ((System.Drawing.Image)(resources.GetObject("PBAD.Image")));
            this.PBAD.Location = new System.Drawing.Point(149, 57);
            this.PBAD.Name = "PBAD";
            this.PBAD.Size = new System.Drawing.Size(362, 249);
            this.PBAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBAD.TabIndex = 5;
            this.PBAD.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(672, 398);
            this.Controls.Add(this.LBSP);
            this.Controls.Add(this.PBAD);
            this.Controls.Add(this.pnlBaseCharge);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplashForm_MouseDown);
            this.pnlBaseCharge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer CmpTemp;
        private System.Windows.Forms.Panel pnlBaseCharge;
        private System.Windows.Forms.Panel pnlCharge;
        private System.Windows.Forms.Timer CmpTempOpacity;
        private System.Windows.Forms.Label LBSP;
        private System.Windows.Forms.PictureBox PBAD;
    }
}