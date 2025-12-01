using System.Windows;
using System.Windows.Media;

namespace RadioButtonDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rbTrump_Checked(object sender, RoutedEventArgs e)
        {
            lblTrump.Background = Brushes.Aquamarine;
        }

        private void rbTrump_Unchecked(object sender, RoutedEventArgs e)
        {
            lblTrump.Background = Brushes.White;
        }
    }
}