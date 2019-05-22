using Modware.Views.Interfaces;
using System.Windows.Forms;

namespace Modware.Views
{
    public partial class NavView : UserControl, INavView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.navTreeView = new System.Windows.Forms.TreeView();
            this.slaveContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSlaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slaveRootContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSlaveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.slaveContextMenuStrip.SuspendLayout();
            this.slaveRootContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // navTreeView
            // 
            this.navTreeView.BackColor = System.Drawing.SystemColors.Window;
            this.navTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.navTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navTreeView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.navTreeView.Location = new System.Drawing.Point(0, 0);
            this.navTreeView.Name = "navTreeView";
            this.navTreeView.Size = new System.Drawing.Size(478, 738);
            this.navTreeView.TabIndex = 0;
            this.navTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.navTreeView_AfterSelect);
            // 
            // slaveContextMenuStrip
            // 
            this.slaveContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSlaveToolStripMenuItem});
            this.slaveContextMenuStrip.Name = "slaveContextMenuStrip";
            this.slaveContextMenuStrip.Size = new System.Drawing.Size(167, 26);
            this.slaveContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.slaveContextMenuStrip_Opening);
            // 
            // addSlaveToolStripMenuItem
            // 
            this.addSlaveToolStripMenuItem.Name = "addSlaveToolStripMenuItem";
            this.addSlaveToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addSlaveToolStripMenuItem.Text = "Add Message List";
            this.addSlaveToolStripMenuItem.Click += new System.EventHandler(this.addSlaveToolStripMenuItem_Click);
            // 
            // slaveRootContextMenuStrip
            // 
            this.slaveRootContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSlaveToolStripMenuItem1});
            this.slaveRootContextMenuStrip.Name = "slaveContextMenuStrip";
            this.slaveRootContextMenuStrip.Size = new System.Drawing.Size(127, 26);
            this.slaveRootContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.slaveContextMenuStrip_Opening);
            // 
            // addSlaveToolStripMenuItem1
            // 
            this.addSlaveToolStripMenuItem1.Name = "addSlaveToolStripMenuItem1";
            this.addSlaveToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.addSlaveToolStripMenuItem1.Text = "Add Slave";
            this.addSlaveToolStripMenuItem1.Click += new System.EventHandler(this.addSlaveToolStripMenuItem1_Click);
            // 
            // NavView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navTreeView);
            this.Name = "NavView";
            this.Size = new System.Drawing.Size(478, 738);
            this.slaveContextMenuStrip.ResumeLayout(false);
            this.slaveRootContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView navTreeView;

        public TreeNode addTCPSlaveNode(string text, object leafObject, ContextMenuType type, TreeNode node = null)
        {
            TreeNode retVal;

            if (node == null)
            {
                retVal = navTreeView.Nodes.Add(text);
                retVal.Tag = leafObject;
            }
            else
            {
                retVal = node.Nodes.Add(text);
                retVal.Tag = leafObject;
            }

            //add Context Menu
            switch(type)
            {
                case ContextMenuType.master:
                    
                    break;
                case ContextMenuType.slave:
                    retVal.ContextMenuStrip = slaveContextMenuStrip;
                    break;
                case ContextMenuType.slaveRoot:
                    retVal.ContextMenuStrip = slaveRootContextMenuStrip;
                    break;
                case ContextMenuType.masterRoot:
                    break;
            }

            

            return retVal;
        }

        public void clear()
        {
            navTreeView.Nodes.Clear();
        }

        private ContextMenuStrip slaveContextMenuStrip;
        private ToolStripMenuItem addSlaveToolStripMenuItem;
        private ContextMenuStrip slaveRootContextMenuStrip;
        private ToolStripMenuItem addSlaveToolStripMenuItem1;
    }
}
