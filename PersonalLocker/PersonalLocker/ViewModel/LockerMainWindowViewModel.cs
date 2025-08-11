using PersonalLocker.Helpers;
using PersonalLocker.Model;
using System;
using System.Collections.Generic;
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

        public LockerMainWindowViewModel()
        {
            _model = new LockerModel("","","", "C:\\Users\\marce\\Documents\\projetos\\databases\\FirstLocker.csv");
            ShowMessageCommand = new RelayCommand(ShowMessage);
        }
        public ICommand ShowMessageCommand { get; }

        private void ShowMessage()
        {
            
            
            string message = (_model.pathExists(_model.sysPath)) ? "Caminho existe" : "Caminho nao existe";

            // A exibição de um MessageBox é uma responsabilidade da View,
            // mas para um exemplo simples, podemos fazê-lo aqui.
            // Em uma aplicação real, seria preferível usar um serviço de diálogo.
            MessageBox.Show(message);
        }



    }
}
