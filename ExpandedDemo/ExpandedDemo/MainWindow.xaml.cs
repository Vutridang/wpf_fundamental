using System.Windows;

namespace ExpandedDemo
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

        private void Expander_OnExpanded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Expander was clicked");
        }
    }
}