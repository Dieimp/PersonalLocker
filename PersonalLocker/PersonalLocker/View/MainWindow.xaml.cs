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
    }
}