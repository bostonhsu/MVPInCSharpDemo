using System;
using System.Windows.Forms;

namespace MVPDemo
{
    public interface IMainForm<T> : IView<T>
    {
        Button TestButton { get; }
        TextBox TestTextBox { get; }
        event EventHandler ViewLoadEvent;
        event EventHandler ButtonSubmitEvent;
        void ShowSubmitDialog();
    }
}
