using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogFileEater.Classes;
using Microsoft.VisualBasic;

namespace LogFileEater
{
    public partial class MainForm : Form
    {
        List<LogReader> readers = new List<LogReader>();
        string defaultName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load defaults
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            defaultName = ActiveForm.Text;
        }

        private void OutputReceived(object sender, DataReceivedEventArgs e, string logFile)
        {

            Invoke(new Action(() =>
            {
                if (cbxAddNewLine.Checked)
                {
                    txtOutput.AppendText(e.Data + Environment.NewLine);
                }
                else
                {
                    txtOutput.AppendText(e.Data);
                }

                foreach (TabPage page in tbcLogFileRenders.TabPages)
                {
                    if (page.Text == logFile)
                    {
                        if (cbxAddNewLine.Checked)
                        {
                            ((TextBox)page.Controls.Find("txtOutput", false).First()).AppendText(e.Data + Environment.NewLine);
                        }
                        else
                        {
                            ((TextBox)page.Controls.Find("txtOutput", false).First()).AppendText(e.Data);
                        }
                        return;
                    }
                }

            }));
        }

        private void RemoteOutputReceived(object sender, DataReceivedEventArgs e, string logFile)
        {
            OutputReceived(sender, e, logFile);
        }

        private void btnOpenFiles_Click(object sender, EventArgs e)
        {
            if (ofdLogFileSelector.ShowDialog() == DialogResult.OK)
            {
                string[] files = ofdLogFileSelector.FileNames;
                foreach (string file in files)
                {
                    readers.Add(new LogReader(RemoteOutputReceived, addPage, file));
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (LogReader reader in readers)
            {
                reader.Dispose();
            }
        }

        private bool CheckFileExists(string fileName)
        {
            foreach (LogReader reader in readers)
            {
                if (reader.LogFileName == fileName)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnAddLabel_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter a label to add to the form name", "Add Label", "", -1, -1);
            if (!string.IsNullOrWhiteSpace(input))
            {
                ActiveForm.Text = input + " - " + defaultName;
            }
            else
            {
                ActiveForm.Text = defaultName;
            }
        }

        public void addPage(string logFile)
        {
            Invoke(new Action(() =>
            {
                TabPage tp = new TabPage(logFile);
                tbcLogFileRenders.TabPages.Add(tp);

                TextBox tb = new TextBox();
                tb.Name = "txtOutput";
                tb.Dock = DockStyle.Fill;
                tb.Multiline = true;
                tb.ReadOnly = true;
                tb.ScrollBars = ScrollBars.Both;

                tb.VisibleChanged += (sender, e) =>
                {
                    if (tb.Visible)
                    {
                        tb.SelectionStart = tb.TextLength;
                        tb.ScrollToCaret();
                    }
                };

                tp.Controls.Add(tb);
            }));
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on \"Open File\" to start." + Environment.NewLine
                + "Once you have opend a log file, click on the different tabs to switch between files." + Environment.NewLine
                + "The \"*\" tab will display results for all of the files" + Environment.NewLine
                + "Additions to the log files will update the text boxes" + Environment.NewLine
                + "You can click on \"Add label\" to name the current window", "Help - Log File Reader");
        }
    }
}
