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
    public class MainWindowViewModel
    {
        private HelloWorldModel _model;
        public MainWindowViewModel()
        {
            _model = new HelloWorldModel();
            ShowMessageCommand = new RelayCommand(ShowMessage);
        }

        public ICommand ShowMessageCommand { get; }

        private void ShowMessage()
        {
            // O ViewModel chama a lógica de negócio do Model
            string message = _model.GetMessage();

            // A exibição de um MessageBox é uma responsabilidade da View,
            // mas para um exemplo simples, podemos fazê-lo aqui.
            // Em uma aplicação real, seria preferível usar um serviço de diálogo.
            MessageBox.Show(message);
        }

        
      
    }
}
