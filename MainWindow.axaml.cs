using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace AvaloniaApplication2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            one.Background = Colors.brush;
            textOne.Foreground = Colors.brushTwo;
            textTwo.Foreground = Colors.brushTwo;
        }
        public void Enter(object sender, RoutedEventArgs e)
        {
            Colors.detect = 0;
            new ServicesForUser().Show();
            Close();
        }
        public void EnterAdmin(object sender, RoutedEventArgs e)
        {
            if (kod.Text == "0000")
            {
                Colors.detect = 1;
                new ServicesForUser().Show();
                Close();
            }
            else
            {
                Message.Text = "Ошибка!";
            }
        }
    }
}