using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modware.Models.Interfaces;
using Modware.Presenters.Interfaces;
using Modware.Services.Interfaces;

namespace Modware.Models.Interfaces
{
    public interface ISession
    {
        event EventHandler notifyChange;
        void notifyUpdate();
        void addNewTCPSlavePresenter();
        List<ITCPSlavePresenter> slavePresenters { get; }
    }
}
