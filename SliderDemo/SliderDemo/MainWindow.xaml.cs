using System.Windows;

namespace SliderDemo
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

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // if (MyTextBlock != null && MySlider.Value > 0d)
            // {
            //     MyTextBlock.Text = "Slider value is " + MySlider.Value.ToString();
            //     MyTextBlock.FontSize = MySlider.Value;
            // }
                
        }
    }
}