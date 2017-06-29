using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPDemo
{
    public partial class MainForm : MvpForm, IMainForm<MainFormModel>
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainFormModel Model { get; set; }
        public TextBox TestTextBox { get { return txtText; } }
        public Button TestButton { get { return btnSubmit; } }

        public event EventHandler ViewLoadEvent;
        public event EventHandler ButtonSubmitEvent;

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ViewLoadEvent != null)
            {
                ViewLoadEvent(sender, e);
            }
        }

        public void ShowSubmitDialog()
        {
            MessageBox.Show("to submit?");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ButtonSubmitEvent != null)
            {
                ButtonSubmitEvent(sender, e);
            }
        }
    }
}
