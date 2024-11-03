using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace Blockchain_View_Controller.controller
{
    public class memory
    {
        public class IO
        {
            public class TransactionsOps
            {
                public static void Load()
                {
                    try
                    {
                        //string json = File.ReadAllText(TRANSACTIONS_FILE_PATH);
                        //blockchain.infrastructure.db.Transactions_On_Blockchain = JsonConvert.DeserializeObject<List<Node>>(json) ?? new List<Node>();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error loading transactions", ex);
                    }
                }

                public static void Save()
                {
                    try
                    {
                        //string json = JsonConvert.SerializeObject(blockchain.infrastructure.db.Transactions_On_Blockchain, Formatting.Indented);
                        //File.WriteAllText(TRANSACTIONS_FILE_PATH, json);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving transactions: {ex.Message}");
                    }
                }
            }
            public class UserAccountsOps
            {
                public static void Load()
                {
                    try
                    {
                        //string json = File.ReadAllText(USERACCOUNTS_FILE_PATH);
                        //blockchain.infrastructure.db.Accounts_On_Blockchain = JsonConvert.DeserializeObject<List<Node>>(json) ?? new List<Node>();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error loading user accounts", ex);
                    }
                }

                public static void Save()
                {
                    try
                    {
                        //string json = JsonConvert.SerializeObject(blockchain.infrastructure.db.Accounts_On_Blockchain, Formatting.Indented);
                        //File.WriteAllText(USERACCOUNTS_FILE_PATH, json);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving user accounts: {ex.Message}");
                    }
                }
            }
            public class CurrenciesOps
            {
                public static void Load()
                {
                    try
                    {
                        //string json = File.ReadAllText(CURRENCIES_FILE_PATH);
                        //blockchain.infrastructure.db.Currencies_Supported_On_Blockchain = JsonConvert.DeserializeObject<List<Node>>(json) ?? new List<Node>();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error loading currencies", ex);
                    }
                }

                public static void Save()
                {
                    try
                    {
                        //string json = JsonConvert.SerializeObject(blockchain.infrastructure.db.Currencies_Supported_On_Blockchain, Formatting.Indented);
                        //File.WriteAllText(CURRENCIES_FILE_PATH, json);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving currencies: {ex.Message}");
                    }
                }
            }
        }
    }
}
