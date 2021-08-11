using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UWUVCI_MEDIA.Models;
using UWUVCI_MEDIA.UI.Frames;

namespace UWUVCI_MEDIA.UI.Windows
{
    /// <summary>
    /// Interaktionslogik für MainWIndow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        InitializeComponent();
            load_frame.Content = new MainFrame();
            //(FindResource("mvm") as MainViewModel).setMW(this);
        }
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }
        private void ButtonCloseMenu_Click(object sender, MouseEventArgs e)
        {
          

        }

        private void ButtonOpenMenu_Click(object sender, MouseEventArgs e)
        {
            
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            min.Background = new SolidColorBrush(Color.FromArgb(100, 255, 255, 255));
        }
        private void close_MouseEnter(object sender, MouseEventArgs e)
        {
            close.Background = new SolidColorBrush(Color.FromArgb(150, 255, 100, 100));
        }

        private void close_MouseLeave(object sender, MouseEventArgs e)
        {
            close.Background = new SolidColorBrush(Color.FromArgb(0, 250, 250, 250));
        }

        private void min_MouseLeave(object sender, MouseEventArgs e)
        {
            min.Background = new SolidColorBrush(Color.FromArgb(0, 250, 250, 250));
        }
        public void ListView_Click(object sender, MouseButtonEventArgs e)
        {
        }
            private void Window_Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            
            try
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    
                    DragMove();
                }
            }
            catch (Exception)
            {
                //left empty on purpose
            }
           
        }
        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            new Task(() =>
            {
                System.Threading.Thread.Sleep(30);
                
            }).Start();
        }
        private void Window_Minimize(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
