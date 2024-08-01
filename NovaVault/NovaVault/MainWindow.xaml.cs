using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NovaVault.Views;

namespace NovaVault
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnTabSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ContentArea != null)
            {
                switch ((e.AddedItems[0] as ListBoxItem).Content as string)
                {
                    case "Overview":
                        ContentArea.Content = new OverviewView();
                        break;
                    case "Send":
                        ContentArea.Content = new SendView();
                        break;
                    case "Receive":
                        ContentArea.Content = new ReceiveView();
                        break;
                    case "Transactions":
                        ContentArea.Content = new TransactionsView();
                        break;
                    case "Market":
                        ContentArea.Content = new MarketView();
                        break;
                    case "Settings":
                        ContentArea.Content = new SettingsView();
                        break;
                }
            }
        }
    }
}
