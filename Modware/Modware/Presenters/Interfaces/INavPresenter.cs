using Modware.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modware.Presenters.Interfaces
{
    interface INavPresenter
    {
        void loadData();
        event TreeNodeMouseClickEventHandler navigateRequest;
    }
}
