
namespace UI.WinForms
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.PN_Datos = new System.Windows.Forms.Panel();
            this.LBY = new System.Windows.Forms.Label();
            this.LBA = new System.Windows.Forms.Label();
            this.LBR = new System.Windows.Forms.Label();
            this.PBAD = new System.Windows.Forms.PictureBox();
            this.LBSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PN_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAD)).BeginInit();
            this.SuspendLayout();
            // 
            // PN_Datos
            // 
            this.PN_Datos.BackColor = System.Drawing.Color.Transparent;
            this.PN_Datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PN_Datos.Controls.Add(this.label1);
            this.PN_Datos.Controls.Add(this.LBSP);
            this.PN_Datos.Controls.Add(this.PBAD);
            this.PN_Datos.Controls.Add(this.LBR);
            this.PN_Datos.Controls.Add(this.LBA);
            this.PN_Datos.Controls.Add(this.LBY);
            this.PN_Datos.Location = new System.Drawing.Point(50, 38);
            this.PN_Datos.Name = "PN_Datos";
            this.PN_Datos.Size = new System.Drawing.Size(322, 367);
            this.PN_Datos.TabIndex = 0;
            // 
            // LBY
            // 
            this.LBY.AutoSize = true;
            this.LBY.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBY.Location = new System.Drawing.Point(42, 175);
            this.LBY.Name = "LBY";
            this.LBY.Size = new System.Drawing.Size(235, 16);
            this.LBY.TabIndex = 0;
            this.LBY.Text = "Yolainee Portorreal - 20198298";
            // 
            // LBA
            // 
            this.LBA.AutoSize = true;
            this.LBA.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBA.Location = new System.Drawing.Point(46, 209);
            this.LBA.Name = "LBA";
            this.LBA.Size = new System.Drawing.Size(226, 16);
            this.LBA.TabIndex = 1;
            this.LBA.Text = "Angel Fernandez - 202010603";
            // 
            // LBR
            // 
            this.LBR.AutoSize = true;
            this.LBR.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBR.Location = new System.Drawing.Point(47, 241);
            this.LBR.Name = "LBR";
            this.LBR.Size = new System.Drawing.Size(225, 16);
            this.LBR.TabIndex = 2;
            this.LBR.Text = "Raymond Suarez - 202010427";
            // 
            // PBAD
            // 
            this.PBAD.Image = ((System.Drawing.Image)(resources.GetObject("PBAD.Image")));
            this.PBAD.Location = new System.Drawing.Point(84, 25);
            this.PBAD.Name = "PBAD";
            this.PBAD.Size = new System.Drawing.Size(151, 114);
            this.PBAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBAD.TabIndex = 3;
            this.PBAD.TabStop = false;
            // 
            // LBSP
            // 
            this.LBSP.AutoSize = true;
            this.LBSP.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBSP.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LBSP.Location = new System.Drawing.Point(123, 121);
            this.LBSP.Name = "LBSP";
            this.LBSP.Size = new System.Drawing.Size(73, 16);
            this.LBSP.TabIndex = 4;
            this.LBSP.Text = "SellPoint";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(105, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version 0.0.1";
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.PN_Datos);
            this.Name = "AcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PN_Datos.ResumeLayout(false);
            this.PN_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PN_Datos;
        private System.Windows.Forms.Label LBR;
        private System.Windows.Forms.Label LBA;
        private System.Windows.Forms.Label LBY;
        private System.Windows.Forms.PictureBox PBAD;
        private System.Windows.Forms.Label LBSP;
        private System.Windows.Forms.Label label1;
    }
}