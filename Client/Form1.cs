using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using Client.ChatService;
using MetroFramework.Forms;

namespace Client
{
    public partial class frmClient : MetroForm
    {
        ReceiveClient rc = null;
        string myName;

        public frmClient()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(frmClient_FormClosing);

        }

        private void frmClient_FormClosing(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            txtMsgs.Enabled = false;
            txtSend.Enabled = false;
            btnSend.Enabled = false;
            btnSendEveryOne.Enabled = false;
        }

        void rc_ReceiveMsg(string sender, string msg)
        {
            if (msg.Length > 0)
            {
                if (txtMsgs.Text.Length > 0)
                {
                    txtMsgs.Text += Environment.NewLine + sender + ">" + msg;
                }
                else
                {
                    txtMsgs.Text += sender + ">" + msg;
                }
            }
        }

        void rc_NewNames(object sender, List<string> names)
        {
            lstClients.Items.Clear();
            foreach (string name in names)
            {
                if (name != myName)
                    lstClients.Items.Add(name);
            }
            if (lstClients.Items.Count > 0)
            {
                lstClients.SelectedIndex = 0;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            if (lstClients.Items.Count != 0)
            {
                if (txtSend.Text.Length > 0)
                {
                    if (txtMsgs.Text.Length > 0)
                    {
                        txtMsgs.Text += Environment.NewLine + myName + ">" + txtSend.Text;
                    }
                    else
                    {
                        txtMsgs.Text += myName + ">" + txtSend.Text;
                    }
                    if (lstClients.SelectedItems.Count == 0)
                        rc.SendMessage(txtSend.Text, myName, lstClients.Items[0].ToString());
                    else
                        if (!string.IsNullOrEmpty(lstClients.SelectedItem.ToString()))
                        rc.SendMessage(txtSend.Text, myName, lstClients.SelectedItem.ToString());

                    txtSend.Clear();
                }
                else
                    MessageBox.Show("Please Enter Message!", "Null Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("No One To Chat!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.Length > 0)
                {

                    myName = txtUserName.Text.Trim();

                    rc = new ReceiveClient();
                    rc.Start(rc, myName);

                    rc.NewNames += new GotNames(rc_NewNames);
                    rc.ReceiveMsg += new ReceviedMessage(rc_ReceiveMsg);

                    txtEnabled(true);
                    txtUserName.Enabled = false;
                    btnLogin.Enabled = false;
                }
                else
                {
                    txtEnabled(false);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata : " + ex.Message);
                //txtEnabled(false);
            }

        }

        void txtEnabled(bool TF)
        {
            txtMsgs.Enabled = TF;
            txtSend.Enabled = TF;
            btnSend.Enabled = TF;
            btnSendEveryOne.Enabled = TF;
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                txtUserName.Text = null;
            }
        }

        private void btnSendEveryOne_Click(object sender, EventArgs e)
        {
            if (lstClients.Items.Count != 0)
            {
                if (txtSend.Text.Length > 0)
                {
                    if (txtMsgs.Text.Length > 0)
                    {
                        txtMsgs.Text += Environment.NewLine + myName + ">" + txtSend.Text;
                    }
                    else
                    {
                        txtMsgs.Text += myName + ">" + txtSend.Text;
                    }
                    for (int i = 0; i < lstClients.Items.Count; i++)
                    {
                        rc.SendMessage(txtSend.Text, myName, lstClients.Items[i].ToString());
                    }

                    txtSend.Clear();
                }
                else
                    MessageBox.Show("Please Enter Message!", "Null Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("No One To Chat!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnkExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}
