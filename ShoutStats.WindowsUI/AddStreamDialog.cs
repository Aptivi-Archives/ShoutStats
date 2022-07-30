/*
 * MIT License
 * 
 * Copyright (c) 2021 Aptivi
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

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
