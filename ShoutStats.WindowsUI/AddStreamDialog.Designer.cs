
namespace ShoutStats.WindowsUI
{
    partial class AddStreamDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.streamUsesHttps = new System.Windows.Forms.CheckBox();
            this.streamServerInput = new System.Windows.Forms.TextBox();
            this.streamPortInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provide the below information about your Shoutcast stream.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stream server and port:";
            // 
            // streamUsesHttps
            // 
            this.streamUsesHttps.AutoSize = true;
            this.streamUsesHttps.Checked = true;
            this.streamUsesHttps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.streamUsesHttps.Location = new System.Drawing.Point(12, 78);
            this.streamUsesHttps.Name = "streamUsesHttps";
            this.streamUsesHttps.Size = new System.Drawing.Size(126, 19);
            this.streamUsesHttps.TabIndex = 3;
            this.streamUsesHttps.Text = "Stream uses HTTPS";
            this.streamUsesHttps.UseVisualStyleBackColor = true;
            // 
            // streamServerInput
            // 
            this.streamServerInput.Location = new System.Drawing.Point(147, 30);
            this.streamServerInput.Name = "streamServerInput";
            this.streamServerInput.Size = new System.Drawing.Size(243, 23);
            this.streamServerInput.TabIndex = 4;
            // 
            // streamPortInput
            // 
            this.streamPortInput.Location = new System.Drawing.Point(396, 30);
            this.streamPortInput.Name = "streamPortInput";
            this.streamPortInput.Size = new System.Drawing.Size(75, 23);
            this.streamPortInput.TabIndex = 5;
            this.streamPortInput.TextChanged += new System.EventHandler(this.streamPortInput_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(315, 74);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(396, 74);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddStreamDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 109);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.streamPortInput);
            this.Controls.Add(this.streamServerInput);
            this.Controls.Add(this.streamUsesHttps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStreamDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add stream";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox streamUsesHttps;
        private System.Windows.Forms.TextBox streamServerInput;
        private System.Windows.Forms.TextBox streamPortInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}