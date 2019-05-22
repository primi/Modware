using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Modware.Presenters.Interfaces;
using Modware.Services.Interfaces;

namespace Modware.Models.Interfaces
{
    public interface ITCPSlave
    {
        string name { get; set; }
        void connect(ModbusTCPConnectionParameters connectionParams);
        List<T> sendReadMessage<T>(ModbusTCPReadMessage<T> message);
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
        public int length;

        public enum FunctionCode
        {
            ReadCoils,
            ReadDiscreteInputs,
            ReadHoldingRegisters,
            ReadInputRegisters
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
