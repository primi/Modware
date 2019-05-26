using Modware.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modware.Views.Interfaces
{
    public interface ITCPSlaveView
    {
        event EventHandler<string> NameChanged;
        event EventHandler<string> TimeoutChanged;
        event EventHandler<string> IPChanged;
        event EventHandler<string> SlaveIDChanged;
        event EventHandler<string> PortChanged;
        event EventHandler ApplyClicked;
        event EventHandler ConnectClicked;

        void setFields(string name, string ipAddress, string port, string slaveID, string timeout);
        void setDirty(bool _isdirty);
        void setInvalidSlaveID();
        void setInvalidTimeout();
        void setInvalidPort();
        void setInvalidIPAddress();
        void setAllLogs(List<LogElement> logList);
        void addLog(LogElement element);
    }
}
