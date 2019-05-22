using Modware.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modware.Models.Interfaces;
using Modware.Services;
using Modware.Services.Interfaces;
using Modware.Factories;
using Modware.Presenters.Interfaces;

namespace Modware.Models
{
    class Session : ISession
    {
        

        public Session()
        {
            slavePresenters = new List<ITCPSlavePresenter>();
        }

        public List<ITCPSlavePresenter> slavePresenters
        { 
            get;
        }

        public void addNewTCPSlavePresenter()
        {
            string name;
            int index = 0;

            ITCPSlavePresenter slavePresenter = TCPSlavePresenterFactory.Instance.createPresenter();

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
