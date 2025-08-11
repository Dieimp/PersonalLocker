using PersonalLocker.ViewModel;
using System.Windows;


namespace PersonalLocker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}