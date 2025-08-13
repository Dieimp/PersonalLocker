using PersonalLocker.ViewModel;
using System.Windows;

namespace PersonalLocker
{

    public partial class LockerMainWindow : Window
    {
        public LockerMainWindow()
        {
            InitializeComponent();
            this.DataContext = new LockerMainWindowViewModel();
        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
