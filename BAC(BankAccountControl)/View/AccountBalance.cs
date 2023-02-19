using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BAC_BankAccountControl_.View
{
    class AccountBalance
    {
        Model.AccountData accountdata = new Model.AccountData();

        public AccountBalance(string agency, string accountnumber)
        {
            accountdata.Agency = agency;
            accountdata.AccountNumber = accountnumber;

            index();
        }

        string option = string.Empty;
        public void index()
        {
            switch (accountdata.Agency)
            {
                case "0001":
                    {
                        switch (accountdata.AccountNumber)
                        {
                            case "000001":
                                {
                                    accountdata.Owner = "Felipe Reis";
                                    inicio();
                                    break;

                                }
                        }
                    }
                    break;
                case "0002":
                    {
                        switch (accountdata.AccountNumber)
                        {
                            case "000002":
                                {
                                    accountdata.Owner = "Maomed Pinto";
                                    inicio();
                                    break;

                                }
                        }
                    }
                    break;
            }
        }

        private void inicio()
        {
            try
            {
                Console.Clear();

                Console.WriteLine("O que iremos fazer hoje " + accountdata.Owner + "?");
                Console.WriteLine();

                Console.WriteLine("1 - Ver balanço\n2 - Adicionar Balanço\n3 - Alterar Moeda");

                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        {
                            case1();

                            if (back())
                                Program.Main();
                            else
                                inicio();
                        }
                        break;
                    case "2":
                        {
                            case2();
                            if (back())
                                Program.Main();
                            else
                                inicio();
                        }
                        break;
                    case "3":
                        {
                            case3();
                            if (back())
                                Program.Main();
                            else
                                inicio();
                        }
                        break;
                    default:
                        {
                            throw new Exception("Você deve selecionar uma opção!");
                        }
                }
                while (true) ;

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                Console.ReadLine();
                inicio();
            }
        }

        private void case1()
        {
            Console.Clear();

            Console.WriteLine("Seu balanço é de: " + accountdata.Currency + accountdata.Balance);
            Console.ReadLine();
        }

        private void case2()
        {
            Console.Clear();

            Console.WriteLine("Qual valor deve ser adicionado a conta: ");
            Console.ReadLine();

            accountdata.Balance = double.Parse(Console.ReadLine());
        }

        private void case3()
        {
            Console.Clear();

            Console.WriteLine("Qual tipo de moeda deve ser usado na conta?");
            Console.ReadLine();

            accountdata.Currency = Console.ReadLine();
        }


        private bool back()
        {
            Console.WriteLine("Deseja voltar ao inicio?(S/N)");
            option = Console.ReadLine();

            if (!String.IsNullOrEmpty(option))
                if (option.Equals("S", StringComparison.OrdinalIgnoreCase))
                    return true;
                else
                    Console.WriteLine("Voltando ao menu de opções!");
            return false;
        }
    }
}
