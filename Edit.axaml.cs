using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication2;

public partial class Edit : Window
{
    public Edit()
    {
        InitializeComponent();
        if (Colors.detect == 0)
        {
            EditForUser.Text = "Вернуться назад";
        }
        else EditForUser.Text = "Редактировать и назад";
    }
    public void BackEdit(object sender, RoutedEventArgs e)
    {
        new ServicesForUser().Show();
        Close();
    }
}