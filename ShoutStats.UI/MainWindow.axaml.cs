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
using System.Linq;
using Avalonia.Controls;
using ShoutStats.Core;

namespace ShoutStats.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new StatsData(this);
            InitializeComponent();
        }
    }

    public class StatsData
    {
        private Window view;
        private List<StreamInfo> streams;
        private ShoutcastServer shout;
        private string selectedStream;

        public void PopulateData()
        {
            try
            {
                var thisView = (MainWindow)view;
                bool secure = thisView.statsURL.Text.StartsWith("+");
                string shoutUrl = thisView.statsURL.Text.TrimStart('+');
                int shoutPort = Convert.ToInt32(thisView.statsPort.Text);
                shout = new ShoutcastServer(shoutUrl, shoutPort, secure);

                // Populate server info
                thisView.stats.Text = $"Showing statistics for {shout.ServerHostFull}";
                thisView.ServerInfo.Text =
                    $"Server version: {shout.ServerVersion}\n" +
                    $"Total streams: {shout.TotalStreams}\n" +
                    $"Active streams: {shout.ActiveStreams}\n" +
                    $"Current listeners: {shout.CurrentListeners}\n" +
                    $"Peak listeners: {shout.PeakListeners} \n" +
                    $"Max listeners: {shout.MaxListeners} \n" +
                    $"Unique listeners: {shout.UniqueListeners} \n" +
                    $"Average time: {shout.AverageTime} seconds\n" +
                    $"Average time (span): {shout.AverageTimeSpan}"
                ;

                // Get streams
                streams = shout.Streams;
                thisView.StreamCombo.Items = streams.Select((si) => si.StreamId);
            }
            catch (Exception ex)
            {
                var dialog = new DialogBoxWindow();
                dialog.DialogContent.Text = ex.ToString();
                dialog.Show(view);
            }
        }

        public string SelectedStream
        {
            get { return selectedStream; }
            set
            {
                GetStreamInfo(value);
                selectedStream = value;
            }
        }

        public void GetStreamInfo(string stream)
        {
            if (shout is null)
                return;

            var thisView = (MainWindow)view;
            int streamIdx = Convert.ToInt32(stream) - 1;
            var shoutStream = streams[streamIdx];
            thisView.StreamInfo.Text =
                $"Stream ID: {shoutStream.StreamId}\n" +
                $"Stream title: {shoutStream.StreamTitle}\n" +
                $"Current song: {shoutStream.SongTitle}\n" +
                $"Current listeners: {shoutStream.CurrentListeners}\n" +
                $"Peak listeners: {shoutStream.PeakListeners}\n" +
                $"Max listeners: {shoutStream.MaxListeners}\n" +
                $"Unique listeners: {shoutStream.UniqueListeners}\n" +
                $"Average time (s): {shoutStream.AverageTime}\n" +
                $"Average time (span): {shoutStream.AverageTimeSpan}\n" +
                $"Stream genre: {shoutStream.StreamGenre}\n" +
                $"Stream homepage: {shoutStream.StreamHomepage}\n" +
                $"Stream hits: {shoutStream.StreamHits}\n" +
                $"Stream status: {shoutStream.StreamStatus}\n" +
                $"Backup status: {shoutStream.BackupStatus}\n" +
                $"Stream listed: {shoutStream.StreamListed}\n" +
                $"Stream path: {shoutStream.StreamPath}\n" +
                $"Stream uptime (s): {shoutStream.StreamUptime}\n" +
                $"Stream uptime (span): {shoutStream.StreamUptimeSpan}\n" +
                $"Stream bitrate: {shoutStream.BitRate}\n" +
                $"Stream sample rate: {shoutStream.SampleRate}\n" +
                $"MIME info: {shoutStream.MimeInfo}";
            ;
        }

        public StatsData(Window view)
        {
            this.view = view;
        }
    }
}
