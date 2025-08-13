using PersonalLocker.Helpers;
using PersonalLocker.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PersonalLocker.ViewModel
{
    public class LockerMainWindowViewModel
    {
        private LockerModel _model;
        public ObservableCollection<LockerModel> Contents { get; set; }
        public LockerMainWindowViewModel()
        {
            _model = new LockerModel("","","", "C:\\Users\\marce\\Documents\\projetos\\databases\\FirstLocker.csv");
            Contents = new ObservableCollection<LockerModel>();
            FillContentsOfLocker();
            ShowMessageCommand = new RelayCommand(ShowMessage);

        }
        public ICommand ShowMessageCommand { get; }

        private void ShowMessage()
        {
            
            
            string message = (_model.pathExists(_model.sysPath)) ? "Caminho existe" : "Caminho nao existe";

            MessageBox.Show(_model.GetContentsInsideOfLocker(_model.sysPath).ToString());
        }

        private void FillContentsOfLocker()
        {
            try
            {
                List<LockerModel> contents = _model.GetContentsInsideOfLocker(_model.sysPath);

                foreach (LockerModel contet in contents)
                {
                    Console.WriteLine(contet);
                    Contents.Add(contet);
                }
            }
            catch (Exception ex)
            {
            }

        }
    }
}
