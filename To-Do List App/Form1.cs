﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_App
{
    public partial class TDL_Form : Form
    {
        public TDL_Form()
        {
            InitializeComponent();

            flowLayoutPanel.SuspendLayout();
            flowLayoutPanel.ResumeLayout();
            flowLayoutPanel.PerformLayout();
        }

        private void TDL_Form_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            checkUpdates();
        }

        private void TDL_notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TDL_Form_Resize(object sender, EventArgs e)
        {
            bool mousePointerTaskbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);
            if (this.WindowState == FormWindowState.Minimized && mousePointerTaskbar)
            {
                this.Hide();
                TDL_notifyIcon.ShowBalloonTip(1000, "Important notice", "To-Do List app has been minimized to system tray.", ToolTipIcon.Info);
            }
        }

        private void Button_Click(object clickedButton, EventArgs e)
        {
            if (clickedButton == addToListButton)
            {
                while(textBox.Text.Length > 0)
                {
                    flowLayoutPanel.Controls.Add(createPanel(textBox.Text));
                    TDL_limit++;
                    break;
                }
            }

            if (clickedButton == remove_Button)
            {
                for (int i = 0; i < checkListArr.Count; i++)
                {
                    if (checkListArr[i].Checked)
                    {
                        panelArr.RemoveAt(i);
                        checkListArr.RemoveAt(i);
                        buttonArr.RemoveAt(i);
                        flowLayoutPanel.Controls.RemoveAt(i);
                        TDL_limit--;
                    }
                }
            }

            for (int i = 0; i < checkListArr.Count; i++)
            {
                if (clickedButton == buttonArr[i])
                {
                    checkListArr[i].Font = new Font("Segoe Print", 15F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point, ((byte)(0)));
                }
            }

            if (TDL_limit == 20)
            {
                addToListButton.Enabled = false;
                textBox.Enabled = false;
                textBox.Text = "Reached max limit of 20 lists";
            }
            else if (TDL_limit >= 0)
            {
                addToListButton.Enabled = true;
                textBox.Enabled = true;
                textBox.Clear();
            }
        }

        private void checkUpdates()
        {
            UpdateCheckInfo info;
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("The new version of the application can't be downloaded at this time.\n\nPlease check your network connection or try again later. Error: " + dde.Message, "Message", MessageBoxButtons.OK);
                    return;
                }
                if (info.UpdateAvailable)
                {
                    if (MessageBox.Show("A newer version of the application is available. Would you like to update it now? ", "Message" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            ad.Update();
                            Application.Restart();
                        }
                        catch(Exception e)
                        {
                            MessageBox.Show(e.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
