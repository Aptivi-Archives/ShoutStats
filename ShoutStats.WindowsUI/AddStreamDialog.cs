using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoutStats.WindowsUI;
using ShoutStats.Core;

namespace ShoutStats.WindowsUI
{
    public partial class AddStreamDialog : Form
    {
        private StatsUI formCaller;

        public AddStreamDialog(StatsUI caller)
        {
            InitializeComponent();
            formCaller = caller;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShoutcastServer shoutcastServer = new ShoutcastServer(streamServerInput.Text, Convert.ToInt32(streamPortInput.Text), streamUsesHttps.Checked);
                formCaller.ShoutcastServers.Add(shoutcastServer);
                formCaller.serverList.Items.Add(shoutcastServer.ServerHostFull);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add a Shoutcast server {streamServerInput.Text}: {ex.Message}");
            }
        }

        private void streamPortInput_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(streamPortInput.Text) && !string.IsNullOrWhiteSpace(streamServerInput.Text))
            {
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled = false;
            }
        }
    }
}
