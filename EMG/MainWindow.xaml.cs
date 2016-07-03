using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EMG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ChageView(Page.Welcome, false);
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == System.Windows.WindowState.Maximized) Windows.Margin = new Thickness(7);
            else if (WindowState == System.Windows.WindowState.Normal) Windows.Margin = new Thickness(0, 0, 0, 0);
        }

        private void BtnConfig_Click(object sender, RoutedEventArgs e)
        {
            ChageView(Page.Config, true);
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            ChageView(Page.Config, true);
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            ChageView(Page.Run, true);
        }
        void ChageView(Page Goto,bool UseTranslate)
        {
            VisualStateManager.GoToElementState(Windows, Goto.ToString(), UseTranslate);
        }
        enum Page
        {
            Welcome,
            Config,
            Run
        }
    }
}
