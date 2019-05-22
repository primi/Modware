using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modware.Views;
using Modware.Presenters;
using Modware.Models.Interfaces;
using Modware.Presenters.Interfaces;
using Modware.Models;
using Modware.Views.Interfaces;

namespace Modware
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ISession session = new Session();
            MainForm mainForm = new MainForm();
            INavView navView = new NavView();
            IMainPresenter mainPresenter = new MainPresenter(session, mainForm);
            
            mainPresenter.setNav(navView);
            mainPresenter.LoadViewNavPanel();
            Application.Run(mainForm);

        }
    }
}
