using Blockchain_View_Controller.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_View_Controller.blockchain
{
    public class infrastructure
    {
        public class db
        {
            public static List<storage_medium.UserAccount> Accounts_On_Blockchain = [];
            public static List<storage_medium.Transaction> Transactions_On_Blockchain = [];
            public static List<storage_medium.Currency> Currencies_Supported_On_Blockchain = [];


            public static storage_medium.BlockchainInstince hnft_Chain = new storage_medium.BlockchainInstince
            {
                ChainName = "hNFT-Chain",
                ChainHeight = db.Transactions_On_Blockchain.Count,
                Admin_Of_Chain = accounts.Select.FromID("0xf001")
            };
        }
        public class nson
        {
            public static double Global_Value_Constant = 0.004;
        }
        public class storage_medium
        {
            public class UserAccount
            { 
                public string UserID { get; set; }
                public string UserName { get; set; }
                public string Password { get; set; }
                public AdvancedUserConfig AdvancedConfig { get; set; }
            }
            public class AdvancedUserConfig
            { 
                public bool IsUserACurrencyManager { get; set; }
            }


            public class BlockchainInstince
            { 
                public string ChainName { get; set; }
                public int ChainHeight { get; set; } = db.Transactions_On_Blockchain.Count;
                public UserAccount Admin_Of_Chain { get; set; }

            }


            public class Transaction
            { 
                public string TransactionID { get; set; }
                public DateTime Time_Of_Transaction { get; set; }
                public UserAccount Sender { get; set; }
                public UserAccount Reciever { get; set; }
                public Currency Currency_Of_Trade { get; set; }   
                public double Amount { get; set; }
            }


            public class Currency
            { 
                public string CurrencyID { get; set; }
                public string CurrencyName { get; set; }
                public string CurrencyCode { get; set; }
                public Dollar CurrencyValue { get; set; }
                public UserAccount CurrencyWallet { get; set; }
            }
            public class Dollar
            { 
                public double Amount { get; set; }
            }
        }
    }
}
