using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Navigation;

namespace tebeBlock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            TextBlock myTb = new TextBlock();
            myTb.Text = "Hello World";
            myTb.Inlines.Add(" this is added using Inline");
            myTb.Inlines.Add(new Run("Run text that I added in Code behind")
            {
                Foreground = Brushes.Red,
                TextDecorations = TextDecorations.Underline,
            });
            myTb.TextWrapping = TextWrapping.Wrap;
            myTb.Foreground = Brushes.BurlyWood;
            this.Content = myTb;
        }
    }
}