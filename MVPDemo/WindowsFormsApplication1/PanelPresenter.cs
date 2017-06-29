using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class PanelPresenter
    {
        public PanelPresenter(Form1 view)
        {
            this.View = view;

            //初始化Model
            this.View.Model = new PanelPresenterationModel() { Name = "Bao, Jianqiang" };
        }

        public Form1 View { get; set; }
    }
}
