using BlurEffectTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Effects;

namespace BlurEffectTest.ViewModels
{
    class MainWindowViewModel: ViewModelBase
    {       

        #region Properties
        private Visibility _spinnerVisibility = Visibility.Visible;
        public Visibility SpinnerVisibility
        {
            get { return _spinnerVisibility; }
            set
            {
                _spinnerVisibility = value;
                OnPropertyChanged(nameof(SpinnerVisibility));
            }
        }
        #endregion

        #region Commands
        private readonly ICommand _showPopupCommand;
        public ICommand ShowPopupCommand
        {
            get { return _showPopupCommand; }
        }

        private readonly ICommand _changePopupVisibilityCommand;
        public ICommand ChangePopupVisibilityCommand
        {
            get { return _changePopupVisibilityCommand; }
        }

        #endregion


        public MainWindowViewModel()
        {
            _spinnerVisibility = Visibility.Visible;
            _showPopupCommand = new RelayCommand(ShowPopup, param => CanExecute);
            _changePopupVisibilityCommand = new RelayCommand(ChangePopupVisibility, param => CanExecute);
        }

        private void ShowPopup(object obj)
        {           
            SplashScreen.ShowBlurEffectAllWindow();

            PopUp pu = new();
            _ = pu.ShowDialog();

            SplashScreen.StopBlurEffectAllWindow();
        }

        private void ChangePopupVisibility(object obj)
        {
            if(SpinnerVisibility == Visibility.Visible)
            {
                SpinnerVisibility = Visibility.Collapsed;
            }
            else
            {
                SpinnerVisibility = Visibility.Visible;
            }
        }
    }
}
