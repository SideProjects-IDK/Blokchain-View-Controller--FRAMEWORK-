using Blockchain_View_Controller.App.Assets.Lists;
using Blockchain_View_Controller.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_View_Controller.App.tests
{
    public class zzo
    {
        public static void RunTests()
        {

            //
            // MATRIX ACCOUNT ADDING
            //

            blockchain.infrastructure.db.Accounts_On_Blockchain.Add(
                   new blockchain.infrastructure.storage_medium.UserAccount
                   {
                       UserID = $"0xf001",
                       UserName = $"MATRIX",
                       Password = $"PASSWORD"
                   }
               );

            //
            // FURTHER TESTING
            //

            //bool IsCurrencyOnline = controller.currencies.Add_New(
            //    new blockchain.infrastructure.storage_medium.Currency
            //    {
            //        CurrencyCode = "Ox0000000001",
            //        CurrencyName = "HAMZA-COIN",
            //        CurrencyID = "0x0001",
            //        CurrencyValue = new blockchain.infrastructure.storage_medium.Dollar
            //        { 
            //            Amount = 1000
            //        },
            //        CurrencyWallet = new blockchain.infrastructure.storage_medium.UserAccount 
            //        {
            //            UserID = "0x0001",
            //            UserName = "HAMZA-COIN-ADMIN",
            //            Password = "PASSWORD"
            //        },
            //        WalletBalance = 25_000
            //    }
            //);

            blockchain.infrastructure.db.Currencies_Supported_On_Blockchain.Add(
                new blockchain.infrastructure.storage_medium.Currency
                {
                    CurrencyCode = "Ox0000000001",
                    CurrencyName = "HAMZA-COIN",
                    CurrencyID = "0x0001",
                    CurrencyValue = controller.currencies.Doller.FromAmount(2500),
                    CurrencyWallet = new blockchain.infrastructure.storage_medium.UserAccount
                    {
                        UserID = "0x0001",
                        UserName = "HAMZA-COIN-ADMIN",
                        Password = "PASSWORD",
                        AdvancedConfig = new blockchain.infrastructure.storage_medium.AdvancedUserConfig
                        {
                            IsUserACurrencyManager = false,
                        }
                    }
                }
            );

            blockchain.infrastructure.db.Accounts_On_Blockchain.Add(
                new blockchain.infrastructure.storage_medium.UserAccount
                {
                    UserID = $"0x0001",
                    UserName = $"HAMZA-COIN-ADMIN",
                    Password = $"PASSWORD",
                    AdvancedConfig = new blockchain.infrastructure.storage_medium.AdvancedUserConfig
                    {
                        IsUserACurrencyManager = false,
                    }
                }
            );

            @out.p_info("Total Currencies:");
            foreach (blockchain.infrastructure.storage_medium.Currency __currency__ in blockchain.infrastructure.db.Currencies_Supported_On_Blockchain)
            {
                @out.p_info($"{__currency__.CurrencyID,-10} | {__currency__.CurrencyWallet.UserID,-10} | {__currency__.CurrencyName,-17}");
            }


            //if (!IsCurrencyOnline)
            //{
            //    @out.p_error("Failed to add currency.");
            //    Environment.Exit(-1);
            //}
            //else
            //{
            //    @out.p_info("Currency added!");
            //}

            //
            // USER ACCOUNT ADDING AND LISTING
            //

            @out.p_info("Adding User Accounts:");
            for (int i = 0; i <= 3; i++)
            {
                blockchain.infrastructure.db.Accounts_On_Blockchain.Add(
                    new blockchain.infrastructure.storage_medium.UserAccount
                    {
                        UserID = $"0x00a{i}",
                        UserName = $"user_{i}",
                        Password = $"password",
                        AdvancedConfig = new blockchain.infrastructure.storage_medium.AdvancedUserConfig
                        {
                            IsUserACurrencyManager = false,
                        }
                    }
                );
            }


            @out.p_info("Total Accounts:");
            foreach (blockchain.infrastructure.storage_medium.UserAccount __account__ in blockchain.infrastructure.db.Accounts_On_Blockchain)
            {
                @out.p_info($"{__account__.UserID,-6} | {__account__.UserName,-7} | {__account__.Password,-7}");
            }

            //
            // TRANSACTIONS ADDING AND LISTING
            //

            //bool IsIt = controller.transactions.Validator.IsACurrency(
            //    new blockchain.infrastructure.storage_medium.UserAccount
            //    {
            //        UserID = $"0x0001",
            //        UserName = $"HAMZA-COIN-ADMIN",
            //        Password = $"PASSWORD"
            //    }
            //);

            //Console.Write($"IS THIS A CURRENCY: {IsIt}\n");


            @out.p_info("Adding Transactions:");
            for (int j = 0; j <= 3; j++)
            {
                foreach (blockchain.infrastructure.storage_medium.UserAccount __account__ in blockchain.infrastructure.db.Accounts_On_Blockchain)
                {
                    if (__account__.UserID == "0x0001")
                    {
                        continue;
                    }

                    controller.transactions.New.Transaction(
                        controller.accounts.Select.FromID("0x0001"),
                        controller.accounts.Select.FromID(__account__.UserID),
                        299 + (j * 12) + (((j / (2 + (j / 69))) + 1) ^ 2 + (2 * j ^ j)),
                        controller.accounts.Select.FromID(
                                controller.currencies.Select.FromName("HAMZA-COIN").CurrencyID
                            )
                        );
                }
            }

            @out.p_info("Total Transactions:");
            foreach (blockchain.infrastructure.storage_medium.Transaction __t__ in blockchain.infrastructure.db.Transactions_On_Blockchain)
            {
                @out.p_info($"{__t__.TransactionID,-25} | {__t__.Currency_Of_Trade.CurrencyName,-10} | {__t__.Sender.UserName,-15} | {__t__.Reciever.UserName,-10} | {__t__.Amount,-10}");
            }

            //
            // BALANCE CALCULATING
            //

            //@out.p_info("Total Balances:");
            //foreach (blockchain.infrastructure.storage_medium.UserAccount __account__ in blockchain.infrastructure.db.Accounts_On_Blockchain)
            //{
            //    @out.p_info($"{__account__.UserID,-6} | {__account__.UserName,-17} | {controller.transactions.UserBlanace.Calculate(new blockchain.infrastructure.storage_medium.UserAccount { UserID = __account__.UserID }),-10} | ${controller.transactions.UserBlanace.Calculate(new blockchain.infrastructure.storage_medium.UserAccount { UserID = __account__.UserID }) * blockchain.infrastructure.nson.Global_Value_Constant,-10}");
            //}

            @out.p_info("Total Currencies:");
            foreach (blockchain.infrastructure.storage_medium.Currency __currency__ in blockchain.infrastructure.db.Currencies_Supported_On_Blockchain)
            {
                @out.p_info($"{__currency__.CurrencyID,-10} | {__currency__.CurrencyWallet.UserID,-10} | {__currency__.CurrencyName,-17} | {__currency__.CurrencyValue.Amount,-15}");
            }

            @out.p_info("Total Balances:");
            foreach (blockchain.infrastructure.storage_medium.UserAccount __account__ in blockchain.infrastructure.db.Accounts_On_Blockchain)
            {
                @out.p_info($"{__account__.UserID,-6} | {__account__.UserName,-17} | {controller.transactions.UserBlanace.Calculate(
                        controller.accounts.Select.FromID(__account__.UserID)
                    ),-10} | ${controller.transactions.UserBlanace.Calculate(
                        controller.accounts.Select.FromID(__account__.UserID)
                    ) * controller.currencies.Select.FromAdminAccountID("0x0001").CurrencyValue.Amount,-10}");
            }


            @out.p_info($"\n[*] Height of Chain `{blockchain.infrastructure.db.hnft_Chain.ChainName}`: {blockchain.infrastructure.db.hnft_Chain.ChainHeight}");
        }
    }
    public class zz2
    {
        public static void RunTests()
        {
            /// App tests for version one of the framework!
            //App.tests.zzo.RunTests();

            //foreach (var _item in App.tests.gen.gen.Product(["a", "b", "c", "d", "e", "f", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]))
            //{
            //    Console.WriteLine($"{_item}");
            //}

            //List<string> _Addrs = App.tests.gen.gen.Product.ToList_From(["a", "b", "c", "d", "e", "f", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]);

            //File.WriteAllText("G:\\s-cat\\Blockchain-View-Controller\\Blockchain-View-Controller\\App\\.tests\\.gen\\Hashes.txt", $"{_Addrs.Count}");

            //App.Main.Application.__main__();

            //@out.errorf(
            //    controller.custom.exceptions.Errf.New.Instance(
            //        "",
            //        "StdError",
            //        "0x00000000000000000000000000000001"
            //        )
            //);

            ////@out.p_info($"{controller.custom.exceptions.ErrorList.Get.Error._Errors["0x00000000000000000000000000000001"]}");
            //Environment.Exit(0);

            ///// To run the main Application, present in: ./App/Min/Application.cs, Function:__main__()
            //try
            //{
            //    App.Main.Application.__main__();
            //}
            //catch (Exception)
            //{

            //}
        }
    }
    public class zz3
    {
        public static void RunTests()
        {
            string message = "helo worlds i am hamza";
            string password = "password";

            string ENCRYPTED = controller.security.cryptography.hashes.Base64.EncryptData(message, password);
            string DECRYPTED = controller.security.cryptography.hashes.Base64.DecryptData(ENCRYPTED, password);

            Console.WriteLine(
                $"{message}: {ENCRYPTED}"
                );
            Console.WriteLine(
                $"{ENCRYPTED}: {DECRYPTED}"
                );
        }
    }
    public class zz4
    {
        public static void RunTests()
        {
            Console.WriteLine("All Registered Errors:\n");

            // Loop through all error categories and display each error
            DisplayErrors("System Errors", my_errors.SystemErrors.Definitions);
            DisplayErrors("Account Errors", my_errors.AccountErrors.Definitions);
            DisplayErrors("Balance Errors", my_errors.BalanceErrors.Definitions);
            DisplayErrors("Currency Errors", my_errors.CurrencyErrors.Definitions);
            DisplayErrors("Transaction Errors", my_errors.TransactionErrors.Definitions);
            DisplayErrors("Blockchain Errors", my_errors.BlockchainErrors.Definitions);
            DisplayErrors("Smart Contract Errors", my_errors.SmartContractErrors.Definitions);
            DisplayErrors("Network Errors", my_errors.NetworkErrors.Definitions);
            DisplayErrors("Validation Errors", my_errors.ValidationErrors.Definitions);
            DisplayErrors("Security Errors", my_errors.SecurityErrors.Definitions);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();

        }

        static void DisplayErrors(string category, Dictionary<string, (string Type, string Message)> errors)
        {
            Console.WriteLine($"--- {category} ---");
            foreach (var error in errors)
            {
                Console.WriteLine($"Code: {error.Key}, Type: {error.Value.Type}, Message: {error.Value.Message}");
            }
            Console.WriteLine();
        }
    }
}
