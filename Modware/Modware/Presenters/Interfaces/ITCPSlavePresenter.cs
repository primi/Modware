using Modware.Models.Interfaces;
using Modware.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modware.Presenters.Interfaces
{
    public interface ITCPSlavePresenter
    {
        ITCPSlave slave
        {
            get;
        }
        ITCPSlaveView view
        {
            get;
            set;
        }

    }
}
