using System;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace ImageControl
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


		private void Image_MouseUp(object sender, MouseButtonEventArgs e)
		{
			myImage.Source = new BitmapImage(
				new Uri(@"/ImageControl;component/Images/Homer_Simpson.png", UriKind.Relative));
		}
	}
}