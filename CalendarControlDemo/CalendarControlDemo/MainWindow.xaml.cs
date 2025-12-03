using System.Windows.Controls;

namespace CalendarControlDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MyTextBlock.Text = MyCalendar.SelectedDate.ToString();
        }

        private void myCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyTextBlock != null)
                MyTextBlock.Text = MyCalendar.SelectedDate.ToString();
        }
    }
}