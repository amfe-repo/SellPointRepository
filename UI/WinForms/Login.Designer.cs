namespace UI.WinForms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LBUser = new System.Windows.Forms.Label();
            this.LBPass = new System.Windows.Forms.Label();
            this.TXUser = new System.Windows.Forms.TextBox();
            this.TXPass = new System.Windows.Forms.TextBox();
            this.BTLog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBSP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBUser
            // 
            this.LBUser.AutoSize = true;
            this.LBUser.BackColor = System.Drawing.Color.Transparent;
            this.LBUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBUser.Location = new System.Drawing.Point(247, 188);
            this.LBUser.Name = "LBUser";
            this.LBUser.Size = new System.Drawing.Size(72, 19);
            this.LBUser.TabIndex = 0;
            this.LBUser.Text = "Usuario";
            // 
            // LBPass
            // 
            this.LBPass.AutoSize = true;
            this.LBPass.BackColor = System.Drawing.Color.Transparent;
            this.LBPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBPass.Location = new System.Drawing.Point(231, 252);
            this.LBPass.Name = "LBPass";
            this.LBPass.Size = new System.Drawing.Size(105, 19);
            this.LBPass.TabIndex = 1;
            this.LBPass.Text = "Contraseña";
            // 
            // TXUser
            // 
            this.TXUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXUser.Location = new System.Drawing.Point(174, 215);
            this.TXUser.Multiline = true;
            this.TXUser.Name = "TXUser";
            this.TXUser.Size = new System.Drawing.Size(219, 28);
            this.TXUser.TabIndex = 2;
            // 
            // TXPass
            // 
            this.TXPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXPass.Location = new System.Drawing.Point(174, 279);
            this.TXPass.Multiline = true;
            this.TXPass.Name = "TXPass";
            this.TXPass.PasswordChar = '*';
            this.TXPass.Size = new System.Drawing.Size(219, 28);
            this.TXPass.TabIndex = 3;
            // 
            // BTLog
            // 
            this.BTLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTLog.BackgroundImage")));
            this.BTLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTLog.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTLog.Location = new System.Drawing.Point(205, 333);
            this.BTLog.Name = "BTLog";
            this.BTLog.Size = new System.Drawing.Size(156, 58);
            this.BTLog.TabIndex = 4;
            this.BTLog.Text = "Iniciar Sesión";
            this.BTLog.UseVisualStyleBackColor = true;
            this.BTLog.Click += new System.EventHandler(this.BTLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LBSP
            // 
            this.LBSP.AutoSize = true;
            this.LBSP.BackColor = System.Drawing.Color.Transparent;
            this.LBSP.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBSP.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LBSP.Location = new System.Drawing.Point(248, 145);
            this.LBSP.Name = "LBSP";
            this.LBSP.Size = new System.Drawing.Size(72, 16);
            this.LBSP.TabIndex = 6;
            this.LBSP.Text = "SellPoint";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 453);
            this.Controls.Add(this.LBSP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTLog);
            this.Controls.Add(this.TXPass);
            this.Controls.Add(this.TXUser);
            this.Controls.Add(this.LBPass);
            this.Controls.Add(this.LBUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBUser;
        private System.Windows.Forms.Label LBPass;
        private System.Windows.Forms.TextBox TXUser;
        private System.Windows.Forms.TextBox TXPass;
        private System.Windows.Forms.Button BTLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBSP;
    }
}