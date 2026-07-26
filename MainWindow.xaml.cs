using System.Windows;
using System.Windows.Input;

private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
{
    if (e.ClickCount == 2)
    {
        WindowState = WindowState == WindowState.Maximized
            ? WindowState.Normal
            : WindowState.Maximized;
    }
    else
    {
        DragMove();
    }
}

private void Minimize_Click(object sender, RoutedEventArgs e)
{
    WindowState = WindowState.Minimized;
}

private void Close_Click(object sender, RoutedEventArgs e)
{
    Close();
}
