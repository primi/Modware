using Modware.Presenters.Interfaces;
using Modware.Models.Interfaces;
using Modware.Models;
using Modware.Presenters.Navigation;
using Modware.Views.Interfaces;
using Modware.Views;
using System;
using System.Windows.Forms;

namespace Modware.Presenters
{
    internal class MainPresenter : IMainPresenter
    {
        private INavPresenter _navPresenter;
        private ISession _session;
        private IMainView _mainView;
        private INavView _navView;

        public MainPresenter(ISession session, IMainView mainView)
        {
            _session = session;
            _mainView = mainView;
        }

        public MainPresenter()
        {
            
        }

        public void setNav(INavView navView)
        {
            _navView = navView;
            _navPresenter = new NavPresenter(_session, _navView);
            _mainView.setNavPanel(_navView);
            _navPresenter.navigateRequest += navigate;
        }

        private void navigate(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {

                //get the type of the attached object
                switch (e.Node.Tag.GetType().ToString())
                {
                    case "Modware.Presenters.TCPSlavePresenter":
                        //if the form was disposed, create a new one
                        if (((Form)((ITCPSlavePresenter)e.Node.Tag).view) == null || ((Form)((ITCPSlavePresenter)e.Node.Tag).view).IsDisposed || ((Form)((ITCPSlavePresenter)e.Node.Tag).view).Disposing)
                        {
                            ((ITCPSlavePresenter)e.Node.Tag).view = new TCPSlaveForm();
                        }

                        //open the view
                        _mainView.showForm(((Form)((ITCPSlavePresenter)e.Node.Tag).view));
                        break;
                }
            }
        }

        public void LoadViewNavPanel()
        {
            _navPresenter.loadData();
        }
    }
}