using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginDemo
{
    /// <summary>
    /// 这是插件必须实现的接口，也是主程序与插件通信的唯一接口
    /// 换句话说，主程序只认识插件里的这些方法
    /// </summary>
    public interface IMsgPlug
    {
        void OnShowDlg();
        string OnShowInfo();
    }
}
