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
    }
}
