using Modware.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modware.Views.Interfaces
{
    interface IMainView
    {
        void setNavPanel(INavView navView);
        void showForm(Form form);
    }
}
