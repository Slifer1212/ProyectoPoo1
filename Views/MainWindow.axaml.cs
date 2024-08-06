using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace ProyectoPoo1.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            var window2 = new SecondWindow();
            window2.Show();
            this.Close();
        }

        private void IgButton_Click(object sender, RoutedEventArgs e)
        {
            openLink("https://www.instagram.com/yuniormo/");
        }

        private void WsButton_Click(object sender, RoutedEventArgs e)
        {
            openLink("https://wa.link/2zp2j8");

        }
        private void openLink(string url)
        {
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }
    }
}
