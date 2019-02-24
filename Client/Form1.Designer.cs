namespace Client
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.lstClients = new System.Windows.Forms.ListBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.txtSend = new MetroFramework.Controls.MetroTextBox();
            this.txtMsgs = new MetroFramework.Controls.MetroTextBox();
            this.btnSendEveryOne = new MetroFramework.Controls.MetroButton();
            this.lnkExit = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // lstClients
            // 
            this.lstClients.BackColor = System.Drawing.Color.Black;
            this.lstClients.ForeColor = System.Drawing.Color.White;
            this.lstClients.FormattingEnabled = true;
            this.lstClients.ItemHeight = 24;
            this.lstClients.Location = new System.Drawing.Point(659, 155);
            this.lstClients.Margin = new System.Windows.Forms.Padding(6);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(217, 292);
            this.lstClients.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin.Highlight = true;
            this.btnLogin.Location = new System.Drawing.Point(659, 95);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(217, 42);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(567, 2);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.DisplayIcon = true;
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUserName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtUserName.Icon = ((System.Drawing.Image)(resources.GetObject("txtUserName.Icon")));
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(38, 95);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShowClearButton = true;
            this.txtUserName.Size = new System.Drawing.Size(607, 42);
            this.txtUserName.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtUserName.TabIndex = 8;
            this.txtUserName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "Enter User Name";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSend
            // 
            this.btnSend.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSend.Highlight = true;
            this.btnSend.Location = new System.Drawing.Point(659, 465);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 64);
            this.btnSend.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send\r\nPrivate";
            this.btnSend.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            // 
            // 
            // 
            this.txtSend.CustomButton.Image = null;
            this.txtSend.CustomButton.Location = new System.Drawing.Point(545, 2);
            this.txtSend.CustomButton.Name = "";
            this.txtSend.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.txtSend.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSend.CustomButton.TabIndex = 1;
            this.txtSend.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSend.CustomButton.UseSelectable = true;
            this.txtSend.CustomButton.Visible = false;
            this.txtSend.DisplayIcon = true;
            this.txtSend.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSend.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtSend.Icon = ((System.Drawing.Image)(resources.GetObject("txtSend.Icon")));
            this.txtSend.Lines = new string[0];
            this.txtSend.Location = new System.Drawing.Point(38, 465);
            this.txtSend.MaxLength = 32767;
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.PasswordChar = '\0';
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSend.SelectedText = "";
            this.txtSend.SelectionLength = 0;
            this.txtSend.SelectionStart = 0;
            this.txtSend.Size = new System.Drawing.Size(607, 64);
            this.txtSend.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtSend.TabIndex = 10;
            this.txtSend.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSend.UseSelectable = true;
            this.txtSend.WaterMark = "Enter Your Message";
            this.txtSend.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSend.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // txtMsgs
            // 
            // 
            // 
            // 
            this.txtMsgs.CustomButton.Image = null;
            this.txtMsgs.CustomButton.Location = new System.Drawing.Point(317, 2);
            this.txtMsgs.CustomButton.Name = "";
            this.txtMsgs.CustomButton.Size = new System.Drawing.Size(287, 287);
            this.txtMsgs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMsgs.CustomButton.TabIndex = 1;
            this.txtMsgs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMsgs.CustomButton.UseSelectable = true;
            this.txtMsgs.CustomButton.Visible = false;
            this.txtMsgs.DisplayIcon = true;
            this.txtMsgs.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMsgs.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtMsgs.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMsgs.Icon = ((System.Drawing.Image)(resources.GetObject("txtMsgs.Icon")));
            this.txtMsgs.Lines = new string[0];
            this.txtMsgs.Location = new System.Drawing.Point(38, 155);
            this.txtMsgs.MaxLength = 999999999;
            this.txtMsgs.Multiline = true;
            this.txtMsgs.Name = "txtMsgs";
            this.txtMsgs.PasswordChar = '\0';
            this.txtMsgs.ReadOnly = true;
            this.txtMsgs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsgs.SelectedText = "";
            this.txtMsgs.SelectionLength = 0;
            this.txtMsgs.SelectionStart = 0;
            this.txtMsgs.Size = new System.Drawing.Size(607, 292);
            this.txtMsgs.TabIndex = 11;
            this.txtMsgs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtMsgs.UseCustomForeColor = true;
            this.txtMsgs.UseSelectable = true;
            this.txtMsgs.WaterMark = "Chat Window";
            this.txtMsgs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMsgs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSendEveryOne
            // 
            this.btnSendEveryOne.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSendEveryOne.Highlight = true;
            this.btnSendEveryOne.Location = new System.Drawing.Point(776, 465);
            this.btnSendEveryOne.Name = "btnSendEveryOne";
            this.btnSendEveryOne.Size = new System.Drawing.Size(100, 64);
            this.btnSendEveryOne.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSendEveryOne.TabIndex = 9;
            this.btnSendEveryOne.Text = "Send\r\nEveryone";
            this.btnSendEveryOne.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSendEveryOne.UseSelectable = true;
            this.btnSendEveryOne.Click += new System.EventHandler(this.btnSendEveryOne_Click);
            // 
            // lnkExit
            // 
            this.lnkExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkExit.Image = ((System.Drawing.Image)(resources.GetObject("lnkExit.Image")));
            this.lnkExit.ImageSize = 32;
            this.lnkExit.Location = new System.Drawing.Point(824, 21);
            this.lnkExit.Margin = new System.Windows.Forms.Padding(6);
            this.lnkExit.Name = "lnkExit";
            this.lnkExit.Size = new System.Drawing.Size(64, 65);
            this.lnkExit.TabIndex = 12;
            this.lnkExit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnkExit.UseSelectable = true;
            this.lnkExit.Click += new System.EventHandler(this.lnkExit_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 613);
            this.ControlBox = false;
            this.Controls.Add(this.lnkExit);
            this.Controls.Add(this.txtMsgs);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.btnSendEveryOne);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lstClients);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmClient";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Client Side";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstClients;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroTextBox txtSend;
        private MetroFramework.Controls.MetroTextBox txtMsgs;
        private MetroFramework.Controls.MetroButton btnSendEveryOne;
        private MetroFramework.Controls.MetroLink lnkExit;
    }
}

