using Modware.Services;
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

        public event EventHandler<string> NameChanged;
        public event EventHandler<string> TimeoutChanged;
        public event EventHandler<string> IPChanged;
        public event EventHandler<string> SlaveIDChanged;
        public event EventHandler<string> PortChanged;
        public event EventHandler ApplyClicked;
        public event EventHandler ConnectClicked;

        private void TCPSlaveForm_Load(object sender, EventArgs e)
        {

        }

        private void TimeoutTextBox_TextChanged(object sender, EventArgs e)
        {
            TimeoutChanged(sender, TimeoutTextBox.Text);
            TimeoutTextBox.BackColor = SystemColors.Window;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameChanged(sender, NameTextBox.Text);
            NameTextBox.BackColor = SystemColors.Window;
        }

        private void IPTextBox_TextChanged(object sender, EventArgs e)
        {
            IPChanged(sender, IPTextBox.Text);
            IPTextBox.BackColor = SystemColors.Window;
        }

        private void PortTextBox_TextChanged(object sender, EventArgs e)
        {
            PortChanged(sender, PortTextBox.Text);
            PortTextBox.BackColor = SystemColors.Window;
        }

        private void SlaveIDTextBox_TextChanged(object sender, EventArgs e)
        {
            SlaveIDChanged(sender, SlaveIDTextBox.Text);
            SlaveIDTextBox.BackColor = SystemColors.Window;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ApplyClicked(sender, e);
        }

        //do what is required to the gui components when the form is dirty
        public void setDirty(bool isDirty)
        {
            ApplyButton.Enabled = isDirty;
        }
        
        public void setFields(string name, string ipAddress, string port, string slaveID, string timeout)
        {
            NameTextBox.Text = name;
            IPTextBox.Text = ipAddress;
            PortTextBox.Text = port;
            SlaveIDTextBox.Text = slaveID;
            TimeoutTextBox.Text = timeout;
        }

        public void setInvalidSlaveID()
        {
            SlaveIDTextBox.BackColor = Color.Yellow;
        }

        public void setInvalidTimeout()
        {
            TimeoutTextBox.BackColor = Color.Yellow;
        }

        public void setInvalidPort()
        {
            PortTextBox.BackColor = Color.Yellow;
        }

        public void setInvalidIPAddress()
        {
            IPTextBox.BackColor = Color.Yellow;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ConnectClicked(sender, EventArgs.Empty);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        public void setAllLogs(List<LogElement> logList)
        {
            LogListBox.Items.Clear();
            foreach (LogElement element in logList)
            {
                LogListBox.Items.Add(element.description);
            }
        }

        public void addLog(LogElement element)
        {
            LogListBox.Items.Add(element.description);
        }
    }
}
