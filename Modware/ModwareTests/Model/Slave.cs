﻿using NUnit.Framework;
using Modware.Models;
using Modware.Services.Interfaces;
using Modware.Services;
using Modware.Models.Interfaces;
using System.Collections.Generic;

namespace ModwareTests.UnitTests.Models
{
    [TestFixture]
    public class TCPSlaveTest
    {
        private TCPSlave slave;

        [SetUp]
        public void setup()
        {
            
        }

        [Test]
        [TestCase ("192.168.1.100", 502)]
        public void Connect_SlaveDoesntExist_RequestConnect(string IPAddress, int port)
        {
            var slaveConnector = new Moq.Mock<ITCPSlaveConnector>();
            slave = new TCPSlave(slaveConnector.Object);
            ModbusTCPConnectionParameters parameters = new ModbusTCPConnectionParameters();
            parameters.ipaddress = IPAddress;
            parameters.port = port;
            slave.connect(parameters);

            //verify the connect is called with correct parameters
            slaveConnector.Verify(s => s.connect(parameters.ipaddress, parameters.port));
        }

        [Test]
        [TestCase (1)]
        [TestCase (5)]
        public void nodeID_set_nodeIDSet(byte node)
        {
            var slaveConnector = new Moq.Mock<ITCPSlaveConnector>();
            slave = new TCPSlave(slaveConnector.Object);
            slaveConnector.Object.nodeID = node;

            slaveConnector.VerifySet(s=>s.nodeID = node);
        }

        [Test]
        public void sendWriteMessage_multipleTypeInt_sendMultipleRegister()
        {
            var slaveConnector = new Moq.Mock<ITCPSlaveConnector>();
            slave = new TCPSlave(slaveConnector.Object);
            ModbusTCPWriteMessage<int> message = new ModbusTCPWriteMessage<int>()
            {
                functionCode = ModbusTCPWriteMessage<int>.FunctionCode.WriteMultiple,
                startReg = 30,
                registers = new List<int> { 123, 124, 125}
            };

            slave.sendWriteMessage<int>(message);

            //verify the correct send Message is called
            int[] regs = message.registers.ToArray();
            slaveConnector.Verify(s => s.WriteMultipleRegisters(message.startReg, regs));
        }

        [Test]
        public void sendWriteMessage_singleTypeInt_sendSingleRegisters()
        {
            var slaveConnector = new Moq.Mock<ITCPSlaveConnector>();
            slave = new TCPSlave(slaveConnector.Object);
            ModbusTCPWriteMessage<int> message = new ModbusTCPWriteMessage<int>()
            {
                functionCode = ModbusTCPWriteMessage<int>.FunctionCode.WriteSingle,
                startReg = 30,
                registers = new List<int> { 123, 124, 125 }
            };

            slave.sendWriteMessage<int>(message);

            //verify the correct send Message is called
            int[] regs = message.registers.ToArray();
            slaveConnector.Verify(s => s.WriteSingleRegister(message.startReg, 123),Moq.Times.Once);
            slaveConnector.Verify(s => s.WriteSingleRegister(message.startReg, 124), Moq.Times.Once);
            slaveConnector.Verify(s => s.WriteSingleRegister(message.startReg, 125), Moq.Times.Once);

        }

        [Test]
        public void sendReadMessage_Coils_readCoil()
        {
            var slaveConnector = new Moq.Mock<ITCPSlaveConnector>();
            slave = new TCPSlave(slaveConnector.Object);
            ModbusTCPReadMessage<bool> message = new ModbusTCPReadMessage<bool>()
            {
                functionCode = ModbusTCPReadMessage<bool>.FunctionCode.ReadCoils,
                startReg = 30,
                length = 40,
            };

            slave.sendReadMessage<bool>(message);

            //verify the correct send Message is called
            slaveConnector.Verify(s => s.ReadCoils(message.startReg, (message.length)), Moq.Times.Once);
        }

        [Test]
        public void sendReadMessage_DiscreteInputs_readDiscreteInputs()
        {
            var slaveConnector = new Moq.Mock<ITCPSlaveConnector>();
            slave = new TCPSlave(slaveConnector.Object);
            ModbusTCPReadMessage<bool> message = new ModbusTCPReadMessage<bool>()
            {
                functionCode = ModbusTCPReadMessage<bool>.FunctionCode.ReadDiscreteInputs,
                startReg = 30,
                length = 40,
            };

            slave.sendReadMessage<bool>(message);

            //verify the correct send Message is called
            slaveConnector.Verify(s => s.ReadDiscreteInputs(message.startReg, (message.length)), Moq.Times.Once);
        }

        [Test]
        public void sendReadMessage_HoldingRegisters_readHoldingRegisters()
        {
            var slaveConnector = new Moq.Mock<ITCPSlaveConnector>();
            slave = new TCPSlave(slaveConnector.Object);
            ModbusTCPReadMessage<int> message = new ModbusTCPReadMessage<int>()
            {
                functionCode = ModbusTCPReadMessage<int>.FunctionCode.ReadHoldingRegisters,
                startReg = 30,
                length = 40,
            };

            slave.sendReadMessage<int>(message);

            //verify the correct send Message is called
            slaveConnector.Verify(s => s.ReadHoldingRegisters(message.startReg, (message.length)), Moq.Times.Once);
        }

        [Test]
        public void sendReadMessage_InputRegisters_readInputRegisters()
        {
            var slaveConnector = new Moq.Mock<ITCPSlaveConnector>();
            slave = new TCPSlave(slaveConnector.Object);
            ModbusTCPReadMessage<int> message = new ModbusTCPReadMessage<int>()
            {
                functionCode = ModbusTCPReadMessage<int>.FunctionCode.ReadInputRegisters,
                startReg = 30,
                length = 40,
            };

            slave.sendReadMessage<int>(message);

            //verify the correct send Message is called
            slaveConnector.Verify(s => s.ReadInputRegisters(message.startReg, (message.length)));
        }
    }
}
