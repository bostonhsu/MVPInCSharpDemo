using System;
using IMsg;

namespace PluginOne
{
    public class myConsole : IMsgPlug
    {
        public void OnShowDlg()
        {
            Console.WriteLine("控制台调用插件的OnShowDlg方法");
        }

        public string OnShowInfo()
        {
            return "myConsole";
        }
    }
}
