using Modware.Models;
using Modware.Models.Interfaces;
using Modware.Presenters;
using Modware.Presenters.Interfaces;
using Modware.Services;
using Modware.Views;
using Modware.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modware.Factories
{
    public class TCPSlavePresenterFactory
    {
        private static readonly Lazy<TCPSlavePresenterFactory> _TCPSlaveFactorySingleton = new Lazy<TCPSlavePresenterFactory>
            (() => new TCPSlavePresenterFactory());

        public static TCPSlavePresenterFactory Instance
        {
            get
            {
                return _TCPSlaveFactorySingleton.Value;
            }
        }

        public ITCPSlavePresenter createPresenter()
        {
            return (ITCPSlavePresenter)new TCPSlavePresenter(
                new TCPSlave(
                    new TCPSlaveConnector(
                        new EasyModbus.ModbusClient())),
                null);
        }
    }
}
