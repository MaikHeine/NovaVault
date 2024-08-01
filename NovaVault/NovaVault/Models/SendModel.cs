using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;

namespace NovaVault.Models
{
    public class SendModel
    {
        public BitcoinAddress DestinationAddress { get; set; }
        public Money Amount { get; set; }

        // Methods to handle sending Bitcoin
        
    }
}
