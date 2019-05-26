using Modware.Models.Interfaces;
using Modware.Presenters.Interfaces;
using Modware.Services;
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
        private ISession _session;
        private string ipAddress;
        private string port;
        private string slaveID;
        private string name;
        private string timeout;
        private bool _isdirty;

        private bool isDirty
        {
            get
            {
                return _isdirty;
            }
            set
            {
                _isdirty = value;
                _view.setDirty(_isdirty);
            }
        }

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
                if (_view != null)
                {
                    initView();
                }
            }
        }

        public TCPSlavePresenter(ITCPSlave _slave, ITCPSlaveView _view, ISession _session)
        {
            this._slave = _slave;
            this._view = _view;
            this._session = _session;
            _session.notifyChange += refresh;
            _slave.logUpdated += addLogEntry;
            initView();
        }

        private void connectAction(object sender, EventArgs e)
        {
            _slave.connect();
        }

        private void addLogEntry(object sender, LogElement logElement)
        {
            _view.addLog(logElement);
        }

        private void refresh(object sender, EventArgs e)
        {
            populateData();
        }

        private void initView()
        {
            if (_view != null)
            {
                //add all event listeners
                _view.IPChanged += IPChanged;
                _view.NameChanged += NameChanged;
                _view.PortChanged += PortChanged;
                _view.SlaveIDChanged += SlaveIDChanged;
                _view.TimeoutChanged += TimeoutChanged;
                _view.ApplyClicked += ApplyChanges;
                _view.ConnectClicked += connectAction;

                populateData();

                //set dirty to false since the form only just loaded
                isDirty = false;
            }

        }

        private void populateData()
        {
            //initiate the form with data
            if (_slave != null)
            {
                _view.setFields(_slave.name, _slave.connectionParams.ipaddress, _slave.connectionParams.port.ToString(), _slave.connectionParams.nodeID.ToString(), _slave.connectionParams.timeout.ToString());
            }

            //populate list box with logs
            _view.setAllLogs(slave.logs);
        }

        private void ApplyChanges(object sender, EventArgs e)
        {
            if(validate())
            {
                ModbusTCPConnectionParameters parameters;

                _slave.name = name;

                parameters.ipaddress = ipAddress;
                parameters.port = Int16.Parse(port);
                parameters.nodeID = Byte.Parse(slaveID);
                parameters.timeout = int.Parse(timeout);

                _slave.connectionParams = parameters;
                isDirty = false;
                _session.notifyUpdate();
            }
        }

        private bool validate()
        {
            bool retVal = false ;
            bool retVal2 = false;
            bool retVal3 = false;
            bool retVal4 = false;

            if (System.Net.IPAddress.TryParse(ipAddress, out var outVal) )
            {
                retVal = true;
            }
            else
            {
                _view.setInvalidIPAddress();
            }
            if (UInt16.TryParse(port, out var outVal2) && outVal2 > 0)
            {
                retVal2 = true;
            }
            else
            {
                _view.setInvalidPort();
            }
            if (int.TryParse(timeout, out var outVal3) && outVal3>0)
            {
                retVal3 = true;
            }
            else
            {
                _view.setInvalidTimeout();
            }
            if (Byte.TryParse(slaveID, out var outVal4))
            {
                retVal4 = true;
            }
            else
            {
                _view.setInvalidSlaveID();
            }

            return (retVal && retVal2 && retVal3 && retVal4);
        }

        private void TimeoutChanged(object sender, string e)
        {
            timeout = e;
            isDirty = true;
        }

        private void SlaveIDChanged(object sender, string e)
        {
            slaveID = e;
            isDirty = true;
        }

        private void PortChanged(object sender, string e)
        {
            port = e;
            isDirty = true;
        }

        private void NameChanged(object sender, string e)
        {
            name = e;
            isDirty = true;
        }

        private void IPChanged(object sender, string e)
        {
            ipAddress = e;
            isDirty = true;
        }
        

    }
}
