using Modware.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modware.Views
{
    public partial class TCPSlaveForm : Form, ITCPSlaveView
    {
        public TCPSlaveForm()
        {
            InitializeComponent();
        }

        private void TCPSlaveForm_Load(object sender, EventArgs e)
        {

        }
    }
}
