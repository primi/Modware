using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modware.Models.Interfaces;
using Modware.Services.Interfaces;
using EasyModbus;

namespace Modware.Models
{
    public class TCPSlave : ITCPSlave
    {
        ConnectionState connectionState = ConnectionState.disconnected;
        ITCPSlaveConnector _connector;
        
        public TCPSlave(ITCPSlaveConnector connector)
        {
            _connector = connector;
        }

        public void connect(ModbusTCPConnectionParameters connectionParams)
        {
            connectionState = ConnectionState.connecting;
            _connector.connect(connectionParams.ipaddress, connectionParams.port);
        }

        public List<T> sendReadMessage<T>(ModbusTCPReadMessage<T> message)
        {
            List<T> returnVal = new List<T>();

            switch (message.functionCode)
            {
                case ModbusTCPReadMessage<T>.FunctionCode.ReadCoils:
                    returnVal = _connector.ReadCoils(message.startReg, message.length).Cast<T>().ToList();
                    break;
                case ModbusTCPReadMessage<T>.FunctionCode.ReadDiscreteInputs:
                    returnVal = _connector.ReadDiscreteInputs(message.startReg, message.length).Cast<T>().ToList();
                    break;
                case ModbusTCPReadMessage<T>.FunctionCode.ReadHoldingRegisters:
                    returnVal = _connector.ReadHoldingRegisters(message.startReg, message.length).Cast<T>().ToList();
                    break;
                case ModbusTCPReadMessage<T>.FunctionCode.ReadInputRegisters:
                    returnVal = _connector.ReadInputRegisters(message.startReg, message.length).Cast<T>().ToList();
                    break;
                default:
                    throw new Exception("Unknown read function code: " + message.functionCode.ToString());
            }
            return returnVal;
        }

        public void sendWriteMessage<T>(ModbusTCPWriteMessage<T> message)
        {
            //if we are dealing with bits
            if (typeof(T) == typeof(bool))
            {
                if (message.functionCode == ModbusTCPWriteMessage<T>.FunctionCode.WriteMultiple)
                {
                    _connector.WriteMultipleCoils(message.startReg, message.registers.Cast<bool>().ToArray());
                }
                else if (message.functionCode == ModbusTCPWriteMessage<T>.FunctionCode.WriteSingle)
                {
                    //send registers individually with single writes
                    foreach (bool bit in message.registers.Cast<bool>())
                    {
                        _connector.WriteSingleCoil(message.startReg, bit);
                    }
                }
                else throw new Exception("Unknown write function code " + message.functionCode.ToString());
            }
            //if we are dealing with ints
            else if (typeof(T) == typeof(int))
            {
                if (message.functionCode == ModbusTCPWriteMessage<T>.FunctionCode.WriteMultiple)
                {
                    _connector.WriteMultipleRegisters(message.startReg, message.registers.Cast<int>().ToArray());
                }
                else if (message.functionCode == ModbusTCPWriteMessage<T>.FunctionCode.WriteSingle)
                {
                    //send registers individually with single writes
                    foreach (int bit in message.registers.Cast<int>())
                    {
                        _connector.WriteSingleRegister(message.startReg, bit);
                    }
                }
            }
        }

        public enum ConnectionState
        {
            connecting,
            connected,
            disconnecting,
            disconnected
        }
    }
    
}
