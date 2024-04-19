using System.Collections.Generic;
using System.Windows.Forms;

namespace To_Do_List_App
{
    partial class TDL_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TDL_Form));
            this.TDL_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TDL_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.addToListButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.remove_Button = new System.Windows.Forms.Button();
            this.TDL_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TDL_notifyIcon
            // 
            this.TDL_notifyIcon.ContextMenuStrip = this.TDL_contextMenuStrip;
            this.TDL_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TDL_notifyIcon.Icon")));
            this.TDL_notifyIcon.Text = "To-Do List";
            this.TDL_notifyIcon.Visible = true;
            this.TDL_notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TDL_notifyIcon_MouseDoubleClick);
            // 
            // TDL_contextMenuStrip
            // 
            this.TDL_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.TDL_contextMenuStrip.Name = "TDL_contextMenuStrip";
            this.TDL_contextMenuStrip.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "To-Do List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(120, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "DAILY";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(33, 115);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(219, 31);
            this.textBox.TabIndex = 5;
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(267, 119);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(69, 23);
            this.addToListButton.TabIndex = 7;
            this.addToListButton.Text = "Add to list";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.AutoScrollMinSize = new System.Drawing.Size(3, 0);
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(33, 163);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(303, 319);
            this.flowLayoutPanel.TabIndex = 8;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // remove_Button
            // 
            this.remove_Button.Location = new System.Drawing.Point(130, 500);
            this.remove_Button.Name = "remove_Button";
            this.remove_Button.Size = new System.Drawing.Size(107, 23);
            this.remove_Button.TabIndex = 9;
            this.remove_Button.Text = "Remove from list";
            this.remove_Button.UseVisualStyleBackColor = true;
            this.remove_Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // TDL_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 536);
            this.Controls.Add(this.remove_Button);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TDL_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do List";
            this.Load += new System.EventHandler(this.TDL_Form_Load);
            this.Resize += new System.EventHandler(this.TDL_Form_Resize);
            this.TDL_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel createPanel(string TDL_checkList)
        {
            System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel();
            System.Windows.Forms.Button done_Button = new System.Windows.Forms.Button();
            System.Windows.Forms.CheckBox TDL_checkBox = new System.Windows.Forms.CheckBox();

            done_Button.Location = new System.Drawing.Point(222, 17);
            done_Button.Name = "done_Button";
            done_Button.Size = new System.Drawing.Size(52, 23);
            done_Button.TabIndex = 6;
            done_Button.Text = "Done";
            done_Button.UseVisualStyleBackColor = true;
            done_Button.Click += new System.EventHandler(this.Button_Click);
            buttonArr.Add(done_Button);

            TDL_checkBox.AutoSize = true;
            TDL_checkBox.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TDL_checkBox.Location = new System.Drawing.Point(7, 7);
            TDL_checkBox.Name = "TDL_checkBox";
            TDL_checkBox.Size = new System.Drawing.Size(167, 42);
            TDL_checkBox.TabIndex = 5;
            TDL_checkBox.Text = TDL_checkList;
            TDL_checkBox.UseVisualStyleBackColor = true;
            TDL_checkBox.Click += new System.EventHandler(this.Button_Click);
            checkListArr.Add(TDL_checkBox);

            panel.Controls.Add(buttonArr[TDL_limit]);
            panel.Controls.Add(checkListArr[TDL_limit]);
            panel.Location = new System.Drawing.Point(38, 166);
            panel.Name = "panel1";
            panel.Size = new System.Drawing.Size(282, 56);
            panel.TabIndex = 4;
            panelArr.Add(panel);

            return panelArr[TDL_limit];
        }

        #endregion

        private int TDL_limit = 0;
        private List<Button> buttonArr = new List<Button>();
        private List<CheckBox> checkListArr = new List<CheckBox>();
        private List<Panel> panelArr = new List<Panel>();
        private System.Windows.Forms.NotifyIcon TDL_notifyIcon;
        private System.Windows.Forms.ContextMenuStrip TDL_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button remove_Button;
    }
}

