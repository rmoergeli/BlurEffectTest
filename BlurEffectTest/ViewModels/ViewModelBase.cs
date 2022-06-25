using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlurEffectTest.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected internal void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        #region Properties

        private bool _canExecute = true;
        public bool CanExecute
        {
            get { return _canExecute; }
            set
            {
                _canExecute = value;
            }
        }

        #endregion

    }
}
