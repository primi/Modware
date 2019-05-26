using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modware.Services
{
    public class LogElement
    {
        public string _logString;
        public DateTime _timestamp;

        public string ToString()
        {
            return _timestamp.ToString() + "=>" + _logString;
        }

        public void setDescription(string logString)
        {
            _timestamp = DateTime.Now;
            _logString = logString;
        }

        public DateTime timestamp
        {
            get
            {
                return _timestamp;
            }
        }

        public string description
        {
            get
            {
                return _timestamp.ToString() + " => " + _logString;
            }
        }
       
    }
}
