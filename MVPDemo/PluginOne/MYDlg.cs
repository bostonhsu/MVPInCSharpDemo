using IMsg;
using System.Windows.Forms;
using System;

namespace PluginOne
{
    class MYDlg : Form, IMsgPlug
    {
        public void OnShowDlg()
        {
            this.Text = "插件子窗体";
            this.ShowDialog();              //调用Form的ShowDialog,显示窗体
        }

        public string OnShowInfo()
        {
            return "MyDlg";
        }
    }
}
