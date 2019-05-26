using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modware.Models.Interfaces;
using Modware.Services.Interfaces;
using EasyModbus;
using Modware.Presenters.Interfaces;
using Modware.Services;
using System.IO;

namespace Modware.Models
{
    public class TCPSlave : ITCPSlave
    {
        ITCPSlaveConnector _connector;
        private ConnectionState _connectionState;
        public List<LogElement> logs { get; set; }
        public ModbusTCPConnectionParameters connectionParams { get; set; }
        public string name { get; set; }
        public ITCPSlavePresenter _presenter { get; set; }
        public event EventHandler<LogElement> logUpdated;

        public ConnectionState connectionState
        {
            get
            {
                return _connectionState;
            }
            set
            {
                _connectionState = value;
                log("Connection state changed to " + _connectionState.ToString());
            }
        }

        private void log(string logString)
        {
            LogElement element = new LogElement();
            element.setDescription(logString);
            logs.Add(element);
            logUpdated?.Invoke(this, element);
        }

        public TCPSlave(ITCPSlaveConnector connector)
        {
            logs = new List<LogElement>();
            _connector = connector;
            _connectionState = ConnectionState.disconnected;
        }

        public void connect()
        {
            this.connectionParams = connectionParams;
            connectionState = ConnectionState.connecting;
            if (_connector.connect(connectionParams.ipaddress, connectionParams.port))
            {
                connectionState = ConnectionState.connected;
            }
            else
            {
                connectionState = ConnectionState.disconnected;
            }
        }

        public List<T> sendReadMessage<T>(ModbusTCPReadMessage<T> message)
        {
            List<T> returnVal = new List<T>();

            switch (message.functionCode)
            {
                case ModbusTCPReadMessage<T>.FunctionCode.ReadCoils:
                    log("Read coils from " + message.startReg + ", register count " + message.length);
                    returnVal = _connector.ReadCoils(message.startReg, message.length).Cast<T>().ToList();
                    break;
                case ModbusTCPReadMessage<T>.FunctionCode.ReadDiscreteInputs:
                    log("Read discrete inputs from " + message.startReg + ", register count " + message.length);
                    returnVal = _connector.ReadDiscreteInputs(message.startReg, message.length).Cast<T>().ToList();
                    break;
                case ModbusTCPReadMessage<T>.FunctionCode.ReadHoldingRegisters:
                    log("Read holding registers from " + message.startReg + ", register count " + message.length);
                    returnVal = _connector.ReadHoldingRegisters(message.startReg, message.length).Cast<T>().ToList();
                    break;
                case ModbusTCPReadMessage<T>.FunctionCode.ReadInputRegisters:
                    log("Read input registers from " + message.startReg + ", register count " + message.length);
                    returnVal = _connector.ReadInputRegisters(message.startReg, message.length).Cast<T>().ToList();
                    break;
                default:
                    throw new Exception("Unknown read function code: " + message.functionCode.ToString());
                    log("Unknown read function code: " + message.functionCode.ToString());
            }
            log("Message response " + returnVal.ToString());
            return returnVal;
        }

        public void sendWriteMessage<T>(ModbusTCPWriteMessage<T> message)
        {
            //if we are dealing with bits
            if (typeof(T) == typeof(bool))
            {
                if (message.functionCode == ModbusTCPWriteMessage<T>.FunctionCode.WriteMultiple)
                {
                    log("Write multiple coils from " + message.startReg + ", values " + message.registers.Cast<bool>().ToArray().ToString());
                    _connector.WriteMultipleCoils(message.startReg, message.registers.Cast<bool>().ToArray());
                }
                else if (message.functionCode == ModbusTCPWriteMessage<T>.FunctionCode.WriteSingle)
                {
                    //send registers individually with single writes
                    foreach (bool bit in message.registers.Cast<bool>())
                    {
                        log("Write single coil " + message.startReg + ", value " + bit);
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
                    log("Write multiple registers from " + message.startReg + ", values " + message.registers.Cast<bool>().ToArray().ToString());
                    _connector.WriteMultipleRegisters(message.startReg, message.registers.Cast<int>().ToArray());
                }
                else if (message.functionCode == ModbusTCPWriteMessage<T>.FunctionCode.WriteSingle)
                {
                    //send registers individually with single writes
                    foreach (int reg in message.registers.Cast<int>())
                    {
                        log("Write single coil " + message.startReg + ", value " + reg);
                        _connector.WriteSingleRegister(message.startReg, reg);
                    }
                }
            }
        }
    }

}
