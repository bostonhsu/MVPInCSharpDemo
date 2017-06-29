namespace MVPDemo
{
    public interface IView<T> : MVPDemo.IView
    {
        T Model { get; set; }
    }
}
