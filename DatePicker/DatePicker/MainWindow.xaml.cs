using System.Windows;
using System.Windows.Controls;

namespace DatePicker
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

        private void DatePicker_OnSelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as System.Windows.Controls.DatePicker).SelectedDate != null)
            {
                string myDate = (sender as System.Windows.Controls.DatePicker).SelectedDate.ToString();

                MessageBox.Show("Date has been changed to " + myDate);
            }
        }
    }
}