using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAC_BankAccountControl_.Model
{
    class AccountData
    {
        private string _agency = string.Empty;
        private string _accountNumber = string.Empty;
        private string _currency = string.Empty;
        private string _owner = string.Empty;
        private double _balance = 0.00;

        public string Agency { get => _agency; set => _agency = value; }
        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public string Currency { get => _currency; set => _currency = value; }
        public string Owner { get => _owner; set => _owner = value; }
        public double Balance { get => _balance; set => _balance = value; }
    }
}
