using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using Modware.Models.Interfaces;

namespace Modware.Services.Interfaces
{
    public interface ITCPSlaveConnector
    {
        byte nodeID { get; set; }
        int connectionTimeout { get; set; }
        void connect(string ipaddress, int port);
        bool[] ReadDiscreteInputs(int startReg, int length);
        int[] ReadHoldingRegisters(int startReg, int length);
        int[] ReadInputRegisters(int startReg, int length);
        bool[] ReadCoils(int startReg, int length);
        void WriteMultipleCoils(int startReg, bool[] bits);
        void WriteSingleCoil(int startReg, bool bit);
        void WriteSingleRegister(int startReg, int reg);
        void WriteMultipleRegisters(int startReg, int[] regs);
    }

    
}
