using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace AvaloniaApplication2;

public partial class ServicesForUser : Window
{
    public ServicesForUser()
    {
        InitializeComponent();
        ourService.Foreground = Colors.brush;
        if (Colors.detect == 0)
        {
            AddS.IsVisible = false;
            Record.IsVisible = false;
        }
       
    }
    public void Add(object sender, RoutedEventArgs e)
    {
        new AddService().Show();
        Close();
    }
    public void EditService(object sender, RoutedEventArgs e)
    {
        new Edit().Show();
        Close();
    }
}