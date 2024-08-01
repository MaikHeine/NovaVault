using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NBitcoin;
using NovaVault.Models;

namespace NovaVault.ViewModels
{
    public class SendViewModel : INotifyPropertyChanged
    {
        private SendModel _sendModel;

        public SendViewModel()
        {
            _sendModel = new SendModel();
        }

        // Properties bound to the View
        public string DestinationAddress
        {
            get { return _sendModel.DestinationAddress.ToString(); }
            set
            {
                _sendModel.DestinationAddress = BitcoinAddress.Create(value, Network.Main);
                OnPropertyChanged(nameof(DestinationAddress));
            }
        }

        public decimal Ammount
        {
            get { return _sendModel.Amount.ToDecimal(MoneyUnit.BTC); }
            set
            {
                _sendModel.Amount = new Money(value, MoneyUnit.BTC);
                OnPropertyChanged(nameof(Ammount));
            }
        }


        // Commands to handle actions
        public ICommand SendCommand { get; }

        // Implement INotifyPropertyChanged to update the UI
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Constructor
        //public SendViewModel()
        //{
        //    SendCommand = new RelayCommand(async () => await SendBitcoinAsync());
        //}

        // Method to send Bitcoin
        private async Task SendBitcoinAsync()
        {
            // Use the model to send Bitcoin
        }
    }
}
