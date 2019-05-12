using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Modware.Services.Interfaces;

namespace Modware.Models.Interfaces
{
    public interface ITCPSlave
    {
        void connect(ModbusTCPConnectionParameters connectionParams);
        List<T> sendReadMessage<T>(ModbusTCPReadMessage message);
        void sendWriteMessage<T>(ModbusTCPWriteMessage<T> message);
    }

    public struct ModbusTCPConnectionParameters
    {
        public string ipaddress;
        public int port;
        public int timeout;
        public short nodeID;

    }

    public struct ModbusTCPReadMessage<T>
    {
        public FunctionCode functionCode;
        public int startReg;
        public int offset;
        public byte length;

        public enum FunctionCode
        {
            ReadMultiple,
            ReadSingle
        }
    }

    public struct ModbusTCPWriteMessage<T>
    {
        public FunctionCode functionCode;
        public List<T> registers;
        public int startReg;
        public byte length;

        public enum FunctionCode
        {
            WriteMultiple,
            WriteSingle
        }
    }

}
