using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Store.Models;

namespace Store.ViewModel
{
    public class CustomerVM : INotifyPropertyChanged
    {
        private string _tempWarning;

        public string tempWarning
        {
            get { return _tempWarning; }
            set { _tempWarning = value; NotifyPropertyChanged(); }
        }


        private Customer _customer;

        public Customer customer
        {
            get { return _customer; }
            set { _customer = value; NotifyPropertyChanged(); }
        }

        private ObservableCollection<Customer> _customers;

        public ObservableCollection<Customer> customers
        {
            get { return _customers; }
            set { _customers = value; NotifyPropertyChanged(); }
        }

        private ObservableCollection<string> _genders;

        public ObservableCollection<string> Genders
        {
            get { return new ObservableCollection<string> { "Male", "Female", "Other" }; }
           // set { _genders = value; NotifyPropertyChanged(); }
        }

     //   public ObservableCollection<string> Genders = new ObservableCollection<string> { "Male", "Female", "Other" };
     


        public CustomerVM()
        {
            customer = new Customer();
            _customers = new ObservableCollection<Customer>();
        }

  
        private ICommand _saveCommand;
        public ICommand saveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand(Save, canExecute, true);
                }
                return _saveCommand;
            }
        }

        private ICommand _clearCommand;

        public ICommand clearCommand
        {
            get
            {
                if (_clearCommand == null)
                {
                    _clearCommand = new RelayCommand(clear, canExecute, true);
                }
                return _clearCommand;
            }
        }

        private ICommand _closeCommand;

        public ICommand closeCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new RelayCommand(close, canExecute, true);
                }
                return _closeCommand;
            }
        }



        private void Save(object parameter)
        {
            if (IsModelValid())
            {
                _customers.Add(customer);
                customer = new Customer();
            }
            else
            {
                tempWarning = "Please enter valid data.";
            }
        }

        private void clear(object parameter)
        {
            this.customer = new Customer();
        }

        private void close(object parameter)
        {
            var window = parameter as Window;
            window?.Close();
        }

        private bool canExecute(object parameter)
        {
            return true;
        }

        private bool IsModelValid()
        {
            return !(string.IsNullOrEmpty(this.customer.Name) &&
                string.IsNullOrEmpty(this.customer.Address) &&
                string.IsNullOrEmpty(this.customer.Mobile));

        }

          

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName]string name = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
