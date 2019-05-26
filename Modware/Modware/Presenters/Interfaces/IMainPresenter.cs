using Modware.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modware.Presenters.Interfaces
{
    public interface IMainPresenter
    {
        void LoadViewNavPanel();
        void setNav(INavView navView);
    }
}
