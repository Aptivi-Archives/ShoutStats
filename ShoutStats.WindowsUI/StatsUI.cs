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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoutStats.Core;

namespace ShoutStats.WindowsUI
{
    public partial class StatsUI : Form
    {
        public List<ShoutcastServer> ShoutcastServers = new();

        public StatsUI()
        {
            InitializeComponent();
        }

        private void addServer_Click(object sender, EventArgs e)
        {
            Form addForm = new AddStreamDialog(this);
            addForm.ShowDialog();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void serverList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDisplayGeneral();
        }

        private void streamSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDisplayStream();
        }

        public void RefreshAll()
        {
            foreach (ShoutcastServer server in ShoutcastServers)
            {
                server.Refresh();
            }
            RefreshDisplayGeneral();
            RefreshDisplayStream();
        }

        public void RefreshDisplayGeneral()
        {
            ShoutcastServer selectedServer = ShoutcastServers[serverList.SelectedIndex];
            totalStreamsLabel.Text = $"{selectedServer.TotalStreams} streams";
            activeStreamsLabel.Text = $"{selectedServer.ActiveStreams} streams";
            averageStreamTimeLabel.Text = $"{selectedServer.AverageTimeSpan}";

            currentListenersLabel.Text = $"{selectedServer.CurrentListeners} listeners";
            totalMaxListenersLabel.Text = $"{selectedServer.MaxListeners} listeners";
            totalPeakListenersLabel.Text = $"{selectedServer.PeakListeners} listeners";
            totalUniqueListenersLabel.Text = $"{selectedServer.UniqueListeners} listeners";

            serverVersionLabel.Text = $"{selectedServer.ServerVersion}";

            foreach (var stream in selectedServer.Streams)
            {
                if (!streamSelector.Items.Contains($"[{stream.StreamId}] {stream.StreamTitle}"))
                    streamSelector.Items.Add($"[{stream.StreamId}] {stream.StreamTitle}");
            }
            if (streamSelector.Items.Count != 0)
            {
                streamSelector.SelectedIndex = 0;
                streamStatus.Items[0].Text = $"{selectedServer.ServerHost} - Now playing: {selectedServer.Streams[streamSelector.SelectedIndex].SongTitle}";
            }
        }

        public void RefreshDisplayStream()
        {
            StreamInfo selectedStream = ShoutcastServers[serverList.SelectedIndex].Streams[streamSelector.SelectedIndex];
            statsCurrentListeners.Text = $"{selectedStream.CurrentListeners} listeners";
            statsMaxListeners.Text = $"{selectedStream.MaxListeners} listeners";
            statsPeakListeners.Text = $"{selectedStream.PeakListeners} listeners";
            statsUniqueListeners.Text = $"{selectedStream.UniqueListeners} listeners";
            statsAverageStream.Text = $"{selectedStream.AverageTimeSpan}";

            statsServerGenre.Text = selectedStream.StreamGenre;
            statsStreamHits.Text = $"{selectedStream.StreamHits} hits";
            statsStreamListed.Text = $"{selectedStream.StreamListed}";
            statsStreamPath.Text = selectedStream.StreamPath;
            statsStreamUptime.Text = $"{selectedStream.StreamUptimeSpan}";

            statsStreamBackupStatus.Text = $"S: [{selectedStream.StreamStatus}] B: [{selectedStream.BackupStatus}]";
            statsBitrateSampleRate.Text = $"{selectedStream.BitRate} kbps ({selectedStream.SampleRate} Hz)";

            streamStatus.Items[0].Text = $"{ShoutcastServers[serverList.SelectedIndex].ServerHost} - Now playing: {selectedStream.SongTitle}";
        }
    }
}
