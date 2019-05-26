using Modware.Models.Interfaces;
using System;
using System.Collections.Generic;
using Modware.Factories;
using Modware.Presenters.Interfaces;

namespace Modware.Models
{
    class Session : ISession
    {
        public event EventHandler notifyChange;

        public Session()
        {
            slavePresenters = new List<ITCPSlavePresenter>();
        }

        public List<ITCPSlavePresenter> slavePresenters
        { 
            get;
        }

        public void notifyUpdate()
        {
            notifyChange(this, EventArgs.Empty);
        }

        public void addNewTCPSlavePresenter()
        {
            string name;
            int index = 0;

            ITCPSlavePresenter slavePresenter = TCPSlavePresenterFactory.Instance.createPresenter(this);

            do
            {
                name = "Slave " + index.ToString();

                //if name doesn't already exist, add
                if ((slavePresenters.Find((ITCPSlavePresenter presenter) => { return (presenter.slave.name == name); }) == null))
                {
                    slavePresenter.slave.name = name;
                    slavePresenters.Add(slavePresenter);
                    break;
                }
                else
                {
                    ++index;
                }
            } while (true);
            
        }
    }
}
