using CoreAppHandle.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAppHandle.RemoteDesktop
{
    public class LoaderApp
    {
        private LoaderApp() { }

        public static Header launchApp()
        {
            return new Header();
        }
    }
}
