using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modware.Models.Interfaces;
using Modware.Presenters.Interfaces;
using Modware.Services;
using Modware.Views.Interfaces;

namespace Modware.Presenters.Navigation
{
    class NavPresenter : INavPresenter
    {
        private INavView _navView;
        private ISession _session;
        public event TreeNodeMouseClickEventHandler navigateRequest;

        public NavPresenter(ISession session, INavView navView)
        {
            _navView = navView;
            _session = session;
            navView.addSlaveRequest += NavView_addSlave;
            navView.nodeDoubleClicked += NavView_nodeDoubleClicked;
        }

        private void NavView_nodeDoubleClicked(object sender, TreeNodeMouseClickEventArgs e)
        {
            navigateRequest(sender, e);
        }

        public void loadData()
        {
            _navView.clear();
            TreeNode slaveNode = _navView.addTCPSlaveNode("Slaves", null, ContextMenuType.slaveRoot);

            foreach (ITCPSlavePresenter slavePresenter in _session.slavePresenters)
            {
                _navView.addTCPSlaveNode(slavePresenter.slave.name, slavePresenter, ContextMenuType.slave, slaveNode);
            }
        }

        public void NavView_addSlave(object sender, EventArgs e)
        {
            _session.addNewTCPSlavePresenter();
            loadData();
        }
        
    }
}
