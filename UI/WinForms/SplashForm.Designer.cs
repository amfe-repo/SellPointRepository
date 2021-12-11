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
            this.pnlBaseCharge.SuspendLayout();
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
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(672, 398);
            this.Controls.Add(this.pnlBaseCharge);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplashForm_MouseDown);
            this.pnlBaseCharge.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer CmpTemp;
        private System.Windows.Forms.Panel pnlBaseCharge;
        private System.Windows.Forms.Panel pnlCharge;
        private System.Windows.Forms.Timer CmpTempOpacity;
    }
}