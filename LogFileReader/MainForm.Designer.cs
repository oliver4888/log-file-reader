namespace LogFileEater
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.All = new System.Windows.Forms.TabPage();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.tbcLogFileRenders = new System.Windows.Forms.TabControl();
            this.btnOpenFiles = new System.Windows.Forms.Button();
            this.ofdLogFileSelector = new System.Windows.Forms.OpenFileDialog();
            this.btnAddLabel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.All.SuspendLayout();
            this.tbcLogFileRenders.SuspendLayout();
            this.SuspendLayout();
            // 
            // All
            // 
            this.All.Controls.Add(this.txtOutput);
            this.All.Location = new System.Drawing.Point(4, 22);
            this.All.Name = "All";
            this.All.Padding = new System.Windows.Forms.Padding(3);
            this.All.Size = new System.Drawing.Size(748, 431);
            this.All.TabIndex = 0;
            this.All.Text = "*";
            this.All.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.Silver;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(748, 431);
            this.txtOutput.TabIndex = 0;
            // 
            // tbcLogFileRenders
            // 
            this.tbcLogFileRenders.Controls.Add(this.All);
            this.tbcLogFileRenders.Location = new System.Drawing.Point(93, 12);
            this.tbcLogFileRenders.Name = "tbcLogFileRenders";
            this.tbcLogFileRenders.SelectedIndex = 0;
            this.tbcLogFileRenders.Size = new System.Drawing.Size(756, 457);
            this.tbcLogFileRenders.TabIndex = 1;
            // 
            // btnOpenFiles
            // 
            this.btnOpenFiles.Location = new System.Drawing.Point(7, 12);
            this.btnOpenFiles.Name = "btnOpenFiles";
            this.btnOpenFiles.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFiles.TabIndex = 2;
            this.btnOpenFiles.Text = "Open File";
            this.toolTip1.SetToolTip(this.btnOpenFiles, "Click to open a file");
            this.btnOpenFiles.UseVisualStyleBackColor = true;
            this.btnOpenFiles.Click += new System.EventHandler(this.btnOpenFiles_Click);
            // 
            // ofdLogFileSelector
            // 
            this.ofdLogFileSelector.Filter = "Log Files|*.log";
            this.ofdLogFileSelector.InitialDirectory = "C:\\";
            this.ofdLogFileSelector.Multiselect = true;
            this.ofdLogFileSelector.Title = "Select Log File";
            // 
            // btnAddLabel
            // 
            this.btnAddLabel.Location = new System.Drawing.Point(7, 442);
            this.btnAddLabel.Name = "btnAddLabel";
            this.btnAddLabel.Size = new System.Drawing.Size(75, 23);
            this.btnAddLabel.TabIndex = 4;
            this.btnAddLabel.Text = "Add Label";
            this.toolTip1.SetToolTip(this.btnAddLabel, "Click to add a label to the window");
            this.btnAddLabel.UseVisualStyleBackColor = true;
            this.btnAddLabel.Click += new System.EventHandler(this.btnAddLabel_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(774, 5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Visible = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 481);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAddLabel);
            this.Controls.Add(this.btnOpenFiles);
            this.Controls.Add(this.tbcLogFileRenders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Log File Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.All.ResumeLayout(false);
            this.All.PerformLayout();
            this.tbcLogFileRenders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage All;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TabControl tbcLogFileRenders;
        private System.Windows.Forms.Button btnOpenFiles;
        private System.Windows.Forms.OpenFileDialog ofdLogFileSelector;
        private System.Windows.Forms.Button btnAddLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnHelp;
    }
}

