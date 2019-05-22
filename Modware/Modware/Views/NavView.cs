using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modware.Views.Interfaces;

namespace Modware.Views
{
    public partial class NavView : UserControl
    {
        public event EventHandler addSlaveRequest;
        public event TreeNodeMouseClickEventHandler nodeDoubleClicked;

        public NavView()
        {
            InitializeComponent();
            navTreeView.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(nodeDoubleClick);
        }

        private void nodeDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            nodeDoubleClicked(sender, e);
        }

        private void navTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void slaveContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void addSlaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addSlaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addSlaveRequest.Invoke(sender, e);
        }
    }
}
