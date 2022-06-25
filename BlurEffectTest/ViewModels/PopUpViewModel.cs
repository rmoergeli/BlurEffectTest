using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BlurEffectTest.ViewModels
{
    class PopUpViewModel: ViewModelBase
    {

        #region Properties

        private string _title = "";
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        #endregion

        #region Commands       

        private readonly ICommand _confirmCommand;
        public ICommand ConfirmCommand
        {
            get { return _confirmCommand; }
        }

        #endregion

        public PopUpViewModel()
        {
            _confirmCommand = new RelayCommand(CloseWindow, param => CanExecute);

            Title = "PopUp Test";
        }

        #region Methods

        private void CloseWindow(object obj)
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this)
                {
                    item.Close();
                }
            }
        }

        #endregion
    }
}
