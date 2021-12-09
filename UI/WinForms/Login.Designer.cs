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
            this.SuspendLayout();
            // 
            // LBUser
            // 
            this.LBUser.AutoSize = true;
            this.LBUser.BackColor = System.Drawing.Color.Transparent;
            this.LBUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBUser.Location = new System.Drawing.Point(219, 204);
            this.LBUser.Name = "LBUser";
            this.LBUser.Size = new System.Drawing.Size(90, 24);
            this.LBUser.TabIndex = 0;
            this.LBUser.Text = "Usuario";
            // 
            // LBPass
            // 
            this.LBPass.AutoSize = true;
            this.LBPass.BackColor = System.Drawing.Color.Transparent;
            this.LBPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBPass.Location = new System.Drawing.Point(204, 285);
            this.LBPass.Name = "LBPass";
            this.LBPass.Size = new System.Drawing.Size(127, 24);
            this.LBPass.TabIndex = 1;
            this.LBPass.Text = "Contraseña";
            // 
            // TXUser
            // 
            this.TXUser.Location = new System.Drawing.Point(157, 231);
            this.TXUser.Multiline = true;
            this.TXUser.Name = "TXUser";
            this.TXUser.Size = new System.Drawing.Size(219, 28);
            this.TXUser.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 542);
            this.Controls.Add(this.TXUser);
            this.Controls.Add(this.LBPass);
            this.Controls.Add(this.LBUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBUser;
        private System.Windows.Forms.Label LBPass;
        private System.Windows.Forms.TextBox TXUser;
    }
}