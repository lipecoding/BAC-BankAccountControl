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

        string option = string.Empty;
        public AccountBalance(string agency, string accountnumber)
        {
            switch (agency)
            {
                case "0001":
                    {
                        switch (accountnumber)
                        {
                            case "000001":
                                {
                                    accountdata.Owner = "Felipe Reis";
                                    do {
                                        Console.Clear();

                                        Console.WriteLine("Ola " + accountdata.Owner + "!");
                                        Console.WriteLine("O que iremos fazer hoje?");

                                        Console.WriteLine("1 - Ver balanço\n2 - Adicionar Balanço\n3 - Alterar Moeda");

                                        option = Console.ReadLine();

                                        switch (option)
                                        {
                                            case "1":
                                                {
                                                    Console.Clear();

                                                    Console.WriteLine("Seu balanço é de: " + accountdata.Currency + accountdata.Balance);

                                                    if (back())
                                                        return;
                                                }
                                                break;
                                            case "2":
                                                {
                                                    Console.Clear();

                                                    Console.WriteLine("Qual valor deve ser adicionado a conta: ");
                                                    
                                                    accountdata.Balance = double.Parse(Console.ReadLine());

                                                    if (back())
                                                        return;
                                                }
                                                break;
                                            case "3":
                                                {
                                                    Console.Clear();

                                                    Console.WriteLine("Qual tipo de moeda deve ser usado na conta?");

                                                    accountdata.Currency = Console.ReadLine();

                                                    if (back())
                                                        return;

                                                }
                                                break;
                                            default:
                                                {
                                                    Console.WriteLine("Você deve selecionar uma opção!");
                                                }
                                                break;
                                        }
                                    }
                                    while (true);

                                }
                        }
                    }
                    break;
                case "0002":
                    {
                        switch (accountnumber)
                        {
                            case "000002":
                                {
                                    accountdata.Owner = "Maomed Pinto";
                                    do
                                    {
                                        Console.Clear();

                                        Console.WriteLine("Ola " + accountdata.Owner + "!");
                                        Console.WriteLine("O que iremos fazer hoje?");

                                        Console.WriteLine("1 - Ver balanço\n2 - Adicionar Balanço\n3 - Alterar Moeda");

                                        option = Console.ReadLine();

                                        switch (option)
                                        {
                                            case "1":
                                                {
                                                    Console.Clear();

                                                    Console.WriteLine("Seu balanço é de: " + accountdata.Currency + accountdata.Balance);

                                                    if (back())
                                                        return;
                                                }
                                                break;
                                            case "2":
                                                {
                                                    Console.Clear();

                                                    Console.WriteLine("Qual valor deve ser adicionado a conta: ");

                                                    accountdata.Balance = double.Parse(Console.ReadLine());

                                                    if (back())
                                                        return;
                                                }
                                                break;
                                            case "3":
                                                {
                                                    Console.Clear();

                                                    Console.WriteLine("Qual tipo de moeda deve ser usado na conta?");

                                                    accountdata.Currency = Console.ReadLine();

                                                    if (back())
                                                        return;

                                                }
                                                break;
                                            default:
                                                {
                                                    Console.WriteLine("Você deve selecionar uma opção!");
                                                }
                                                break;
                                        }
                                    }
                                    while (true);

                                }
                        }
                    }
                    break;
            }
        }
        private bool back() 
        {
        Console.WriteLine("Deseja voltar ao inicio?(S/N)");
        option = Console.ReadLine();

        if (!String.IsNullOrEmpty(option))
            if (option == "S")
                return true;
            else
                Console.WriteLine("Voltando ao menu de opções!");
        return false;
        }
    }
}
