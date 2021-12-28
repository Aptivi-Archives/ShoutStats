/*
 * MIT License
 * 
 * Copyright (c) 2021 EoflaOE and its companies
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

namespace ShoutStats.WindowsUI
{
    partial class StatsUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.removeServer = new System.Windows.Forms.Button();
            this.addServer = new System.Windows.Forms.Button();
            this.serverList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statsTab = new System.Windows.Forms.TabControl();
            this.general = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalStreamsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.averageStreamTimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activeStreamsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.serverVersionLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalUniqueListenersLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalMaxListenersLabel = new System.Windows.Forms.Label();
            this.currentListenersLabel = new System.Windows.Forms.Label();
            this.totalPeakListenersLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.streams = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.statsBitrateSampleRate = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.statsStreamUptime = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.statsStreamPath = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.statsStreamListed = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.statsStreamBackupStatus = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.statsStreamHits = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.statsServerGenre = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.statsAverageStream = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.statsUniqueListeners = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.statsCurrentListeners = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statsMaxListeners = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.statsPeakListeners = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.streamSelector = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statsVisitHomepage = new System.Windows.Forms.Button();
            this.streamStatus = new System.Windows.Forms.StatusStrip();
            this.serverSong = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statsTab.SuspendLayout();
            this.general.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.streams.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.streamStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 469);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.removeServer);
            this.panel1.Controls.Add(this.addServer);
            this.panel1.Controls.Add(this.serverList);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 447);
            this.panel1.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(176, 412);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // removeServer
            // 
            this.removeServer.Location = new System.Drawing.Point(82, 412);
            this.removeServer.Name = "removeServer";
            this.removeServer.Size = new System.Drawing.Size(67, 23);
            this.removeServer.TabIndex = 2;
            this.removeServer.Text = "Remove";
            this.removeServer.UseVisualStyleBackColor = true;
            // 
            // addServer
            // 
            this.addServer.Location = new System.Drawing.Point(9, 412);
            this.addServer.Name = "addServer";
            this.addServer.Size = new System.Drawing.Size(67, 23);
            this.addServer.TabIndex = 1;
            this.addServer.Text = "Add";
            this.addServer.UseVisualStyleBackColor = true;
            this.addServer.Click += new System.EventHandler(this.addServer_Click);
            // 
            // serverList
            // 
            this.serverList.FormattingEnabled = true;
            this.serverList.ItemHeight = 15;
            this.serverList.Location = new System.Drawing.Point(9, 9);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(242, 394);
            this.serverList.TabIndex = 0;
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.serverList_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.statsTab);
            this.panel2.Location = new System.Drawing.Point(12, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 429);
            this.panel2.TabIndex = 0;
            // 
            // statsTab
            // 
            this.statsTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statsTab.Controls.Add(this.general);
            this.statsTab.Controls.Add(this.streams);
            this.statsTab.Location = new System.Drawing.Point(0, 0);
            this.statsTab.Name = "statsTab";
            this.statsTab.SelectedIndex = 0;
            this.statsTab.Size = new System.Drawing.Size(515, 426);
            this.statsTab.TabIndex = 0;
            // 
            // general
            // 
            this.general.Controls.Add(this.panel3);
            this.general.Location = new System.Drawing.Point(4, 24);
            this.general.Name = "general";
            this.general.Padding = new System.Windows.Forms.Padding(3);
            this.general.Size = new System.Drawing.Size(507, 398);
            this.general.TabIndex = 0;
            this.general.Text = "General";
            this.general.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.serverVersionLabel);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 392);
            this.panel3.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalStreamsLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.averageStreamTimeLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.activeStreamsLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 97);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stream information";
            // 
            // totalStreamsLabel
            // 
            this.totalStreamsLabel.AutoSize = true;
            this.totalStreamsLabel.Location = new System.Drawing.Point(163, 20);
            this.totalStreamsLabel.Name = "totalStreamsLabel";
            this.totalStreamsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalStreamsLabel.Size = new System.Drawing.Size(57, 15);
            this.totalStreamsLabel.TabIndex = 8;
            this.totalStreamsLabel.Text = "0 streams";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total streams:";
            // 
            // averageStreamTimeLabel
            // 
            this.averageStreamTimeLabel.AutoSize = true;
            this.averageStreamTimeLabel.Location = new System.Drawing.Point(163, 70);
            this.averageStreamTimeLabel.Name = "averageStreamTimeLabel";
            this.averageStreamTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.averageStreamTimeLabel.Size = new System.Drawing.Size(49, 15);
            this.averageStreamTimeLabel.TabIndex = 14;
            this.averageStreamTimeLabel.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Active streams:";
            // 
            // activeStreamsLabel
            // 
            this.activeStreamsLabel.AutoSize = true;
            this.activeStreamsLabel.Location = new System.Drawing.Point(163, 45);
            this.activeStreamsLabel.Name = "activeStreamsLabel";
            this.activeStreamsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.activeStreamsLabel.Size = new System.Drawing.Size(57, 15);
            this.activeStreamsLabel.TabIndex = 9;
            this.activeStreamsLabel.Text = "0 streams";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Average stream time:";
            // 
            // serverVersionLabel
            // 
            this.serverVersionLabel.AutoSize = true;
            this.serverVersionLabel.Location = new System.Drawing.Point(172, 370);
            this.serverVersionLabel.Name = "serverVersionLabel";
            this.serverVersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serverVersionLabel.Size = new System.Drawing.Size(54, 15);
            this.serverVersionLabel.TabIndex = 15;
            this.serverVersionLabel.Text = "Version v";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.totalUniqueListenersLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.totalMaxListenersLabel);
            this.groupBox2.Controls.Add(this.currentListenersLabel);
            this.groupBox2.Controls.Add(this.totalPeakListenersLabel);
            this.groupBox2.Location = new System.Drawing.Point(247, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 123);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listener information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total current listeners:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total peak listeners:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total max listeners:";
            // 
            // totalUniqueListenersLabel
            // 
            this.totalUniqueListenersLabel.AutoSize = true;
            this.totalUniqueListenersLabel.Location = new System.Drawing.Point(166, 95);
            this.totalUniqueListenersLabel.Name = "totalUniqueListenersLabel";
            this.totalUniqueListenersLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalUniqueListenersLabel.Size = new System.Drawing.Size(59, 15);
            this.totalUniqueListenersLabel.TabIndex = 13;
            this.totalUniqueListenersLabel.Text = "0 listeners";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total unique listeners:";
            // 
            // totalMaxListenersLabel
            // 
            this.totalMaxListenersLabel.AutoSize = true;
            this.totalMaxListenersLabel.Location = new System.Drawing.Point(166, 70);
            this.totalMaxListenersLabel.Name = "totalMaxListenersLabel";
            this.totalMaxListenersLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalMaxListenersLabel.Size = new System.Drawing.Size(59, 15);
            this.totalMaxListenersLabel.TabIndex = 12;
            this.totalMaxListenersLabel.Text = "0 listeners";
            // 
            // currentListenersLabel
            // 
            this.currentListenersLabel.AutoSize = true;
            this.currentListenersLabel.Location = new System.Drawing.Point(166, 20);
            this.currentListenersLabel.Name = "currentListenersLabel";
            this.currentListenersLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentListenersLabel.Size = new System.Drawing.Size(59, 15);
            this.currentListenersLabel.TabIndex = 10;
            this.currentListenersLabel.Text = "0 listeners";
            // 
            // totalPeakListenersLabel
            // 
            this.totalPeakListenersLabel.AutoSize = true;
            this.totalPeakListenersLabel.Location = new System.Drawing.Point(166, 45);
            this.totalPeakListenersLabel.Name = "totalPeakListenersLabel";
            this.totalPeakListenersLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalPeakListenersLabel.Size = new System.Drawing.Size(59, 15);
            this.totalPeakListenersLabel.TabIndex = 11;
            this.totalPeakListenersLabel.Text = "0 listeners";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Server version:";
            // 
            // streams
            // 
            this.streams.Controls.Add(this.groupBox4);
            this.streams.Controls.Add(this.streamSelector);
            this.streams.Controls.Add(this.label9);
            this.streams.Controls.Add(this.statsVisitHomepage);
            this.streams.Location = new System.Drawing.Point(4, 24);
            this.streams.Name = "streams";
            this.streams.Padding = new System.Windows.Forms.Padding(3);
            this.streams.Size = new System.Drawing.Size(507, 398);
            this.streams.TabIndex = 1;
            this.streams.Text = "Streams";
            this.streams.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.statsBitrateSampleRate);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.statsStreamUptime);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.statsStreamPath);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.statsStreamListed);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.statsStreamBackupStatus);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.statsStreamHits);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.statsServerGenre);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.statsAverageStream);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.statsUniqueListeners);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.statsCurrentListeners);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.statsMaxListeners);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.statsPeakListeners);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(17, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(466, 343);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stream information";
            // 
            // statsBitrateSampleRate
            // 
            this.statsBitrateSampleRate.AutoSize = true;
            this.statsBitrateSampleRate.Location = new System.Drawing.Point(170, 305);
            this.statsBitrateSampleRate.Name = "statsBitrateSampleRate";
            this.statsBitrateSampleRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statsBitrateSampleRate.Size = new System.Drawing.Size(75, 15);
            this.statsBitrateSampleRate.TabIndex = 39;
            this.statsBitrateSampleRate.Text = "0 kbps (0 Hz)";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(18, 305);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(116, 15);
            this.label33.TabIndex = 38;
            this.label33.Text = "Bitrate (sample rate):";
            // 
            // statsStreamUptime
            // 
            this.statsStreamUptime.AutoSize = true;
            this.statsStreamUptime.Location = new System.Drawing.Point(170, 280);
            this.statsStreamUptime.Name = "statsStreamUptime";
            this.statsStreamUptime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statsStreamUptime.Size = new System.Drawing.Size(49, 15);
            this.statsStreamUptime.TabIndex = 37;
            this.statsStreamUptime.Text = "00:00:00";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(18, 280);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 15);
            this.label31.TabIndex = 36;
            this.label31.Text = "Stream uptime:";
            // 
            // statsStreamPath
            // 
            this.statsStreamPath.AutoSize = true;
            this.statsStreamPath.Location = new System.Drawing.Point(170, 255);
            this.statsStreamPath.Name = "statsStreamPath";
            this.statsStreamPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statsStreamPath.Size = new System.Drawing.Size(36, 15);
            this.statsStreamPath.TabIndex = 35;
            this.statsStreamPath.Text = "None";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 255);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(119, 15);
            this.label29.TabIndex = 34;
            this.label29.Text = "Stream path (admin):";
            // 
            // statsStreamListed
            // 
            this.statsStreamListed.AutoSize = true;
            this.statsStreamListed.Location = new System.Drawing.Point(170, 230);
            this.statsStreamListed.Name = "statsStreamListed";
            this.statsStreamListed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statsStreamListed.Size = new System.Drawing.Size(33, 15);
            this.statsStreamListed.TabIndex = 33;
            this.statsStreamListed.Text = "False";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 230);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 15);
            this.label27.TabIndex = 32;
            this.label27.Text = "Stream listed:";
            // 
            // statsStreamBackupStatus
            // 
            this.statsStreamBackupStatus.AutoSize = true;
            this.statsStreamBackupStatus.Location = new System.Drawing.Point(170, 205);
            this.statsStreamBackupStatus.Name = "statsStreamBackupStatus";
            this.statsStreamBackupStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statsStreamBackupStatus.Size = new System.Drawing.Size(63, 15);
            this.statsStreamBackupStatus.TabIndex = 31;
            this.statsStreamBackupStatus.Text = "S: [0] B: [0]";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 205);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(125, 15);
            this.label25.TabIndex = 30;
            this.label25.Text = "Stream status/backup:";
            // 
            // statsStreamHits
            // 
            this.statsStreamHits.AutoSize = true;
            this.statsStreamHits.Location = new System.Drawing.Point(170, 180);
            this.statsStreamHits.Name = "statsStreamHits";
            this.statsStreamHits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statsStreamHits.Size = new System.Drawing.Size(35, 15);
            this.statsStreamHits.TabIndex = 29;
            this.statsStreamHits.Text = "0 hits";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 180);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 15);
            this.label23.TabIndex = 28;
            this.label23.Text = "Stream hits:";
            // 
            // statsServerGenre
            // 
            this.statsServerGenre.AutoSize = true;
            this.statsServerGenre.Location = new System.Drawing.Point(170, 155);
            this.statsServerGenre.Name = "statsServerGenre";
            this.statsServerGenre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statsServerGenre.Size = new System.Drawing.Size(36, 15);
            this.statsServerGenre.TabIndex = 27;
            this.statsServerGenre.Text = "None";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 155);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 15);
            this.label21.TabIndex = 26;
            this.label21.Text = "Server genre:";
            // 
            // statsAverageStream
            // 
            this.statsAverageStream.AutoSize = true;
            this.statsAverageStream.Location = new System.Drawing.Point(170, 130);
            this.statsAverageStream.Name = "statsAverageStream";
            this.statsAverageStream.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statsAverageStream.Size = new System.Drawing.Size(49, 15);
            this.statsAverageStream.TabIndex = 25;
            this.statsAverageStream.Text = "00:00:00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 15);
            this.label19.TabIndex = 24;
            this.label19.Text = "Average stream time:";
            // 
            // statsUniqueListeners
            // 
            this.statsUniqueListeners.AutoSize = true;
            this.statsUniqueListeners.Location = new System.Drawing.Point(170, 105);
            this.statsUniqueListeners.Name = "statsUniqueListeners";
            this.statsUniqueListeners.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statsUniqueListeners.Size = new System.Drawing.Size(59, 15);
            this.statsUniqueListeners.TabIndex = 23;
            this.statsUniqueListeners.Text = "0 listeners";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "Unique listeners:";
            // 
            // statsCurrentListeners
            // 
            this.statsCurrentListeners.AutoSize = true;
            this.statsCurrentListeners.Location = new System.Drawing.Point(170, 30);
            this.statsCurrentListeners.Name = "statsCurrentListeners";
            this.statsCurrentListeners.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statsCurrentListeners.Size = new System.Drawing.Size(59, 15);
            this.statsCurrentListeners.TabIndex = 18;
            this.statsCurrentListeners.Text = "0 listeners";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Current listeners:";
            // 
            // statsMaxListeners
            // 
            this.statsMaxListeners.AutoSize = true;
            this.statsMaxListeners.Location = new System.Drawing.Point(170, 80);
            this.statsMaxListeners.Name = "statsMaxListeners";
            this.statsMaxListeners.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statsMaxListeners.Size = new System.Drawing.Size(59, 15);
            this.statsMaxListeners.TabIndex = 20;
            this.statsMaxListeners.Text = "0 listeners";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "Peak listeners:";
            // 
            // statsPeakListeners
            // 
            this.statsPeakListeners.AutoSize = true;
            this.statsPeakListeners.Location = new System.Drawing.Point(170, 55);
            this.statsPeakListeners.Name = "statsPeakListeners";
            this.statsPeakListeners.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statsPeakListeners.Size = new System.Drawing.Size(59, 15);
            this.statsPeakListeners.TabIndex = 19;
            this.statsPeakListeners.Text = "0 listeners";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "Max listeners:";
            // 
            // streamSelector
            // 
            this.streamSelector.FormattingEnabled = true;
            this.streamSelector.Location = new System.Drawing.Point(70, 10);
            this.streamSelector.Name = "streamSelector";
            this.streamSelector.Size = new System.Drawing.Size(284, 23);
            this.streamSelector.Sorted = true;
            this.streamSelector.TabIndex = 1;
            this.streamSelector.SelectedIndexChanged += new System.EventHandler(this.streamSelector_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Stream:";
            // 
            // statsVisitHomepage
            // 
            this.statsVisitHomepage.Location = new System.Drawing.Point(360, 10);
            this.statsVisitHomepage.Name = "statsVisitHomepage";
            this.statsVisitHomepage.Size = new System.Drawing.Size(123, 23);
            this.statsVisitHomepage.TabIndex = 21;
            this.statsVisitHomepage.Text = "Visit homepage";
            this.statsVisitHomepage.UseVisualStyleBackColor = true;
            // 
            // streamStatus
            // 
            this.streamStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverSong});
            this.streamStatus.Location = new System.Drawing.Point(0, 447);
            this.streamStatus.Name = "streamStatus";
            this.streamStatus.Size = new System.Drawing.Size(800, 22);
            this.streamStatus.TabIndex = 1;
            this.streamStatus.Text = "statusStrip1";
            // 
            // serverSong
            // 
            this.serverSong.Name = "serverSong";
            this.serverSong.Size = new System.Drawing.Size(164, 17);
            this.serverSong.Text = "[server] - Now playing: [song]";
            // 
            // StatsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.streamStatus);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StatsUI";
            this.Text = "ShoutStats";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.statsTab.ResumeLayout(false);
            this.general.ResumeLayout(false);
            this.general.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.streams.ResumeLayout(false);
            this.streams.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.streamStatus.ResumeLayout(false);
            this.streamStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeServer;
        private System.Windows.Forms.Button addServer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl statsTab;
        private System.Windows.Forms.TabPage general;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage streams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label serverVersionLabel;
        private System.Windows.Forms.Label averageStreamTimeLabel;
        private System.Windows.Forms.Label totalUniqueListenersLabel;
        private System.Windows.Forms.Label totalMaxListenersLabel;
        private System.Windows.Forms.Label totalPeakListenersLabel;
        private System.Windows.Forms.Label currentListenersLabel;
        private System.Windows.Forms.Label activeStreamsLabel;
        private System.Windows.Forms.Label totalStreamsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox streamSelector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button refreshButton;
        internal System.Windows.Forms.ListBox serverList;
        private System.Windows.Forms.Label statsCurrentListeners;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label statsMaxListeners;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label statsPeakListeners;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label statsUniqueListeners;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button statsVisitHomepage;
        private System.Windows.Forms.Label statsServerGenre;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label statsAverageStream;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.StatusStrip streamStatus;
        private System.Windows.Forms.ToolStripStatusLabel serverSong;
        private System.Windows.Forms.Label statsBitrateSampleRate;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label statsStreamUptime;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label statsStreamPath;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label statsStreamListed;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label statsStreamBackupStatus;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label statsStreamHits;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel3;
    }
}

