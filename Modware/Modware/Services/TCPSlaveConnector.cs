using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modware.Services.Interfaces;
using EasyModbus;

namespace Modware.Services
{
    public class TCPSlaveConnector : ITCPSlaveConnector
    {
        #region private 
        private ModbusClient _client;
        #endregion

        #region constructors
        public TCPSlaveConnector(ModbusClient client)
        {
            _client = client;
        }
        #endregion
        
        #region public methods
        public void connect(string ipaddress, int port)
        {
            _client.Connect(ipaddress, port);
        }

        public bool[] ReadDiscreteInputs(int startReg, byte length)
        {
            return _client.ReadDiscreteInputs(startReg, length);
        }

        public int[] ReadHoldingRegisters(int startReg, byte length)
        {
            return _client.ReadHoldingRegisters(startReg, length);
        }

        public int[] ReadInputRegisters(int startReg, byte length)
        {
            return _client.ReadInputRegisters(startReg, length);
        }

        public bool[] ReadCoils(int startReg, byte length)
        {
            return _client.ReadCoils(startReg, length);
        }

        public void WriteMultipleCoils(int startReg, bool[] bits)
        {
            _client.WriteMultipleCoils(startReg, bits);
        }

        public void WriteSingleCoil(int startReg, bool bit)
        {
            _client.WriteSingleCoil(startReg, bit);
        }

        public void WriteSingleRegister(int startReg, int reg)
        {
            _client.WriteSingleRegister(startReg, reg);
        }

        public void WriteMultipleRegisters(int startReg, int[] regs)
        {
            _client.WriteMultipleRegisters(startReg, regs);
        }


        #endregion

        #region properties
        public byte nodeID
        {
            get
            {
                return _client.UnitIdentifier;
            }
            set
            {
                _client.UnitIdentifier = value;
            }
        }

        public int connectionTimeout
        {
            get
            {
                return _client.ConnectionTimeout;
            }
            set
            {
                _client.ConnectionTimeout = value;
            }
        }
        #endregion
    }

    public enum ConnectionState
    {
        connecting,
        connected,
        disconnecting,
        disconnected
    }
}
