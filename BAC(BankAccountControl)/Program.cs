using System;

namespace BAC_BankAccountControl_
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bem vindo ao BAC!");
                do
                {
                    string accountInfo = string.Empty;
                    Model.AccountData accountData = new Model.AccountData();
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Digite o numero da agência/conta");

                    accountInfo = Console.ReadLine();

                    if (!String.IsNullOrEmpty(accountInfo))
                    {
                        accountData.Agency = accountInfo.Substring(0, 4);
                        accountData.AccountNumber = accountInfo.Substring(5);


                        new View.AccountBalance(accountData.Agency, accountData.AccountNumber);
                    }
                }
                while (true);
                
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}