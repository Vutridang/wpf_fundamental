using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ButtonDemo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double myFontSize = MyLabel.FontSize ;
            MyLabel.FontSize = myFontSize + 1;
        }

        private void MyButton_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            double myFontSize = MyLabel.FontSize ;
            MyLabel.FontSize = myFontSize - 1;
        }

        private void MyButton_OnMouseEnter(object sender, MouseEventArgs e)
        {
            MyLabel.Foreground = Brushes.White;
        }

        private void MyButton_OnMouseLeave(object sender, MouseEventArgs e)
        {
            MyLabel.Foreground = Brushes.Black;
        }
    }
}