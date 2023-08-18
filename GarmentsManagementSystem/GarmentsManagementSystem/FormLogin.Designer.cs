namespace GarmentsManagementSystem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pbLoginBG = new System.Windows.Forms.PictureBox();
            this.pnlLoginImg = new System.Windows.Forms.Panel();
            this.pnlLoginInfo = new System.Windows.Forms.Panel();
            this.lblErrorUserId = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblResetPassword = new MaterialSkin.Controls.MaterialLabel();
            this.btnLoginButton = new MaterialSkin.Controls.MaterialButton();
            this.txtLoginPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtLoginUserId = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblLoginText = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginBG)).BeginInit();
            this.pnlLoginImg.SuspendLayout();
            this.pnlLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLoginBG
            // 
            this.pbLoginBG.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLoginBG.Image = ((System.Drawing.Image)(resources.GetObject("pbLoginBG.Image")));
            this.pbLoginBG.Location = new System.Drawing.Point(0, 0);
            this.pbLoginBG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLoginBG.Name = "pbLoginBG";
            this.pbLoginBG.Size = new System.Drawing.Size(531, 564);
            this.pbLoginBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoginBG.TabIndex = 0;
            this.pbLoginBG.TabStop = false;
            // 
            // pnlLoginImg
            // 
            this.pnlLoginImg.Controls.Add(this.pbLoginBG);
            this.pnlLoginImg.Location = new System.Drawing.Point(5, 80);
            this.pnlLoginImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLoginImg.Name = "pnlLoginImg";
            this.pnlLoginImg.Size = new System.Drawing.Size(531, 564);
            this.pnlLoginImg.TabIndex = 1;
            // 
            // pnlLoginInfo
            // 
            this.pnlLoginInfo.Controls.Add(this.lblErrorUserId);
            this.pnlLoginInfo.Controls.Add(this.lblErrorPassword);
            this.pnlLoginInfo.Controls.Add(this.lblResetPassword);
            this.pnlLoginInfo.Controls.Add(this.btnLoginButton);
            this.pnlLoginInfo.Controls.Add(this.txtLoginPassword);
            this.pnlLoginInfo.Controls.Add(this.txtLoginUserId);
            this.pnlLoginInfo.Controls.Add(this.lblLoginText);
            this.pnlLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLoginInfo.Location = new System.Drawing.Point(541, 80);
            this.pnlLoginInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLoginInfo.Name = "pnlLoginInfo";
            this.pnlLoginInfo.Size = new System.Drawing.Size(512, 564);
            this.pnlLoginInfo.TabIndex = 2;
            // 
            // lblErrorUserId
            // 
            this.lblErrorUserId.AutoSize = true;
            this.lblErrorUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUserId.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUserId.Location = new System.Drawing.Point(88, 233);
            this.lblErrorUserId.Name = "lblErrorUserId";
            this.lblErrorUserId.Size = new System.Drawing.Size(0, 13);
            this.lblErrorUserId.TabIndex = 6;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(88, 342);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPassword.TabIndex = 5;
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Depth = 0;
            this.lblResetPassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblResetPassword.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblResetPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResetPassword.Location = new System.Drawing.Point(92, 378);
            this.lblResetPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(116, 17);
            this.lblResetPassword.TabIndex = 2;
            this.lblResetPassword.Text = "Forgot Password?";
            this.lblResetPassword.Click += new System.EventHandler(this.lblResetPassword_Click);
            // 
            // btnLoginButton
            // 
            this.btnLoginButton.AutoSize = false;
            this.btnLoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoginButton.Depth = 0;
            this.btnLoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLoginButton.FlatAppearance.BorderSize = 2;
            this.btnLoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginButton.HighEmphasis = true;
            this.btnLoginButton.Icon = null;
            this.btnLoginButton.Location = new System.Drawing.Point(88, 414);
            this.btnLoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoginButton.Name = "btnLoginButton";
            this.btnLoginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoginButton.Size = new System.Drawing.Size(337, 36);
            this.btnLoginButton.TabIndex = 4;
            this.btnLoginButton.Text = "Login";
            this.btnLoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoginButton.UseAccentColor = false;
            this.btnLoginButton.UseVisualStyleBackColor = true;
            this.btnLoginButton.Click += new System.EventHandler(this.btnLoginButton_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.AnimateReadOnly = false;
            this.txtLoginPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLoginPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLoginPassword.Depth = 0;
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.HideSelection = true;
            this.txtLoginPassword.Hint = "Password";
            this.txtLoginPassword.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtLoginPassword.LeadingIcon")));
            this.txtLoginPassword.Location = new System.Drawing.Point(88, 266);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoginPassword.MaxLength = 32767;
            this.txtLoginPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '●';
            this.txtLoginPassword.PrefixSuffixText = null;
            this.txtLoginPassword.ReadOnly = false;
            this.txtLoginPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLoginPassword.SelectedText = "";
            this.txtLoginPassword.SelectionLength = 0;
            this.txtLoginPassword.SelectionStart = 0;
            this.txtLoginPassword.ShortcutsEnabled = true;
            this.txtLoginPassword.Size = new System.Drawing.Size(337, 48);
            this.txtLoginPassword.TabIndex = 1;
            this.txtLoginPassword.TabStop = false;
            this.txtLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoginPassword.TrailingIcon = null;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginUserId
            // 
            this.txtLoginUserId.AnimateReadOnly = false;
            this.txtLoginUserId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLoginUserId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLoginUserId.Depth = 0;
            this.txtLoginUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUserId.HideSelection = true;
            this.txtLoginUserId.Hint = "User ID";
            this.txtLoginUserId.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtLoginUserId.LeadingIcon")));
            this.txtLoginUserId.Location = new System.Drawing.Point(88, 167);
            this.txtLoginUserId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoginUserId.MaxLength = 32767;
            this.txtLoginUserId.MinimumSize = new System.Drawing.Size(0, 39);
            this.txtLoginUserId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLoginUserId.Name = "txtLoginUserId";
            this.txtLoginUserId.PasswordChar = '\0';
            this.txtLoginUserId.PrefixSuffixText = null;
            this.txtLoginUserId.ReadOnly = false;
            this.txtLoginUserId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLoginUserId.SelectedText = "";
            this.txtLoginUserId.SelectionLength = 0;
            this.txtLoginUserId.SelectionStart = 0;
            this.txtLoginUserId.ShortcutsEnabled = true;
            this.txtLoginUserId.Size = new System.Drawing.Size(337, 48);
            this.txtLoginUserId.TabIndex = 0;
            this.txtLoginUserId.TabStop = false;
            this.txtLoginUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoginUserId.TrailingIcon = null;
            this.txtLoginUserId.UseSystemPasswordChar = false;
            // 
            // lblLoginText
            // 
            this.lblLoginText.AutoSize = true;
            this.lblLoginText.Depth = 0;
            this.lblLoginText.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLoginText.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblLoginText.Location = new System.Drawing.Point(197, 66);
            this.lblLoginText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoginText.Name = "lblLoginText";
            this.lblLoginText.Size = new System.Drawing.Size(119, 58);
            this.lblLoginText.TabIndex = 2;
            this.lblLoginText.Text = "Login";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 650);
            this.Controls.Add(this.pnlLoginInfo);
            this.Controls.Add(this.pnlLoginImg);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Window";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginBG)).EndInit();
            this.pnlLoginImg.ResumeLayout(false);
            this.pnlLoginInfo.ResumeLayout(false);
            this.pnlLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoginBG;
        private System.Windows.Forms.Panel pnlLoginImg;
        private System.Windows.Forms.Panel pnlLoginInfo;
        private MaterialSkin.Controls.MaterialLabel lblLoginText;
        private MaterialSkin.Controls.MaterialTextBox2 txtLoginUserId;
        private MaterialSkin.Controls.MaterialTextBox2 txtLoginPassword;
        private MaterialSkin.Controls.MaterialButton btnLoginButton;
        private MaterialSkin.Controls.MaterialLabel lblResetPassword;
        private System.Windows.Forms.Label lblErrorUserId;
        private System.Windows.Forms.Label lblErrorPassword;
    }
}

