using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modware.Views.Interfaces
{
    public interface INavView
    {
        
        TreeNode addTCPSlaveNode(string text, object leafObject, ContextMenuType menuType, TreeNode node=null);
        event EventHandler addSlaveRequest;
        event TreeNodeMouseClickEventHandler nodeDoubleClicked;
        void clear();
    }
    public enum ContextMenuType
    {
        none,
        slave,
        slaveRoot,
        master,
        masterRoot,
    }
}
