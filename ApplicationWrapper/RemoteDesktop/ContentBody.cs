using CoreAppHandle.Managewindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAppHandle.RemoteDesktop
{
    public class ContentBody : BaseWindow
    {
        public bool IsTextDisplayed(String text)
        {
            return appDriver.FindElementByName(text).Displayed;
        }
    }
}
