namespace Server
{
    partial class Form1
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
            this.lstUser = new System.Windows.Forms.ListBox();
            this.btnStartStop = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lstUser
            // 
            this.lstUser.BackColor = System.Drawing.Color.Black;
            this.lstUser.ForeColor = System.Drawing.Color.White;
            this.lstUser.FormattingEnabled = true;
            this.lstUser.ItemHeight = 24;
            this.lstUser.Location = new System.Drawing.Point(48, 142);
            this.lstUser.Margin = new System.Windows.Forms.Padding(6);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(383, 244);
            this.lstUser.TabIndex = 3;
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.Black;
            this.btnStartStop.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Highlight = true;
            this.btnStartStop.Location = new System.Drawing.Point(48, 408);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(178, 57);
            this.btnStartStop.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnStartStop.TabIndex = 4;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnStartStop.UseSelectable = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Highlight = true;
            this.btnExit.Location = new System.Drawing.Point(253, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 57);
            this.btnExit.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(48, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Online Users";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 538);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lstUser);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Server Side";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstUser;
        private MetroFramework.Controls.MetroButton btnStartStop;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

