using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication2;

public partial class AddService : Window
{
    public AddService()
    {
        InitializeComponent();
    }
    public void BackAdd(object sender, RoutedEventArgs e)
    {
        new ServicesForUser().Show();
        Close();
    }
}