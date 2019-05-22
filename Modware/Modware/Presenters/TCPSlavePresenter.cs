using Modware.Models.Interfaces;
using Modware.Presenters.Interfaces;
using Modware.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modware.Presenters
{
    class TCPSlavePresenter: ITCPSlavePresenter
    {
        private ITCPSlaveView _view;
        private ITCPSlave _slave;

        public ITCPSlave slave
        {
            get
            {
                return _slave;
            }
        }

        public ITCPSlaveView view
        {
            get
            {
                return _view;
            }
            set
            {
                _view = value;
            }
        }

        

        public TCPSlavePresenter(ITCPSlave _slave, ITCPSlaveView _view)
        {
            this._slave = _slave;
            this._view = _view;
        }

    }
}
