using Blockchain_View_Controller.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Blockchain_View_Controller.controller
{
    public class transactions
    {
        public class Validator
        {
            public static bool Validate(blockchain.infrastructure.storage_medium.Transaction Transaction)
            {
                bool OK = false;

                if (blockchain.infrastructure.db.Accounts_On_Blockchain.Any(x => x.UserID.Equals(Transaction.Sender)) != null)
                {
                    OK = true;

                    if (blockchain.infrastructure.db.Accounts_On_Blockchain.FindAll(x => x.UserID.Equals(Transaction.Sender)).Count > 0)
                    {
                        OK = false;
                        @out.p_error("Multipule useraccounts found with the same `ID` as sender, (chain broken).");
                        return false;
                    }

                    if (blockchain.infrastructure.db.Accounts_On_Blockchain.FindAll(x => x.UserID.Equals(Transaction.Sender)).Count < 0)
                    {
                        OK = false;
                        @out.p_error("Sender does not exists.");
                        return false;
                    }

                    if (blockchain.infrastructure.db.Accounts_On_Blockchain.FindAll(x => x.UserID.Equals(Transaction.Reciever)).Count > 0)
                    {
                        OK = false;
                        @out.p_error("Multipule useraccounts found with the same `ID` as reciever, (chain broken).");
                        return false;
                    }

                    if (blockchain.infrastructure.db.Accounts_On_Blockchain.FindAll(x => x.UserID.Equals(Transaction.Reciever)).Count < 0)
                    {
                        OK = false;
                        @out.p_error("Reciever does not exists.");
                        return false;
                    }

                    if (UserBlanace.Calculate(Transaction.Sender) >= Transaction.Amount)
                    {
                        OK = true;
                    }
                    else
                    {
                        OK = false;
                        @out.p_error($"User does not have `{Transaction.Amount}` in his account.");
                        return false;
                    }
                }

                return OK;
            }
            public static bool IsACurrency(blockchain.infrastructure.storage_medium.UserAccount Account)
            {
                bool IsUserACurrency = false;

                if (Account.AdvancedConfig.IsUserACurrencyManager == true)
                {
                    IsUserACurrency = true;
                }
                else
                {
                    IsUserACurrency = false; 
                }

                return IsUserACurrency;
            }
        }

        public class UserBlanace
        {
            public static double Calculate(blockchain.infrastructure.storage_medium.UserAccount Account)
            {
                double Balance = 0.00;
                foreach (blockchain.infrastructure.storage_medium.Transaction __t__ in blockchain.infrastructure.db.Transactions_On_Blockchain)
                {
                    if (__t__.Sender.UserID == "0xf001" && __t__.Reciever.UserID != "0xf001")
                    {
                        Balance += __t__.Amount;
                    }
                    else if (__t__.Reciever.UserID != "0xf001")
                    {
                        if (__t__.Sender.AdvancedConfig.IsUserACurrencyManager == true)
                        {
                            //@out.p_info("this is a currency");
                            if (__t__.Reciever.UserID == Account.UserID)
                            {
                                Balance += __t__.Amount;
                            }
                            else if (__t__.Sender.UserID == Account.UserID)
                            {
                                Balance += __t__.Amount;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            if (__t__.Reciever.UserID == Account.UserID)
                            {
                                Balance += __t__.Amount;
                            }
                            else if (__t__.Sender.UserID == Account.UserID)
                            {
                                Balance -= __t__.Amount;
                            }
                            else if (blockchain.infrastructure.db.Currencies_Supported_On_Blockchain.Contains(blockchain.infrastructure.db.Currencies_Supported_On_Blockchain.FirstOrDefault(x => x.CurrencyID.Equals(Account.UserID))))
                            {
                                continue;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                return Balance;
            }
        }
        public class New
        {
            public static bool Transaction(
                blockchain.infrastructure.storage_medium.UserAccount _From,
                blockchain.infrastructure.storage_medium.UserAccount _To,
                double _Amount,
                blockchain.infrastructure.storage_medium.UserAccount _Chain_Admin_Account
                )
            {
                bool WasTransactionSuccessfull = new bool();

                blockchain.infrastructure.db.Transactions_On_Blockchain.Add(
                        new blockchain.infrastructure.storage_medium.Transaction
                        {
                            Sender = _From,
                            Reciever = _To,
                            Currency_Of_Trade = controller.currencies.Select.FromAdminAccountID(_Chain_Admin_Account.UserID),
                            Amount = _Amount,
                            Time_Of_Transaction = DateTime.Now,
                            TransactionID = $"0xff00{blockchain.infrastructure.db.hnft_Chain.ChainHeight+1}-{controller.currencies.Select.FromAdminAccountID(_Chain_Admin_Account.UserID).CurrencyID}"
                        }
                    );

                blockchain.infrastructure.db.hnft_Chain.ChainHeight += 1;

                //
                // Currency value manuplutation
                //

                if (_To.UserID != _Chain_Admin_Account.UserID)
                {
                    controller.currencies.Select.FromAdminAccountID(_Chain_Admin_Account.UserID).CurrencyValue.Amount += (
                        (
                            _Amount
                            /
                            controller.currencies.Select.FromAdminAccountID(_Chain_Admin_Account.UserID)
                            .CurrencyValue
                            .Amount
                        )
                        * 100
                    );
                }
                else
                {
                    controller.currencies.Select.FromAdminAccountID(_Chain_Admin_Account.UserID).CurrencyValue.Amount -= (
                        (
                            _Amount
                            /
                            controller.currencies.Select.FromAdminAccountID(_Chain_Admin_Account.UserID)
                            .CurrencyValue
                            .Amount
                        )
                        * 100
                    );
                }

                return WasTransactionSuccessfull;
            }
        }
        
    }
    public class currencies
    {
        public class ValueManager
        {
            public static blockchain.infrastructure.storage_medium.Dollar Calculate(blockchain.infrastructure.storage_medium.Currency Currency)
            {
                double Value_Measured = 0;

                foreach (blockchain.infrastructure.storage_medium.Transaction __transaction__ in blockchain.infrastructure.db.Transactions_On_Blockchain)
                {
                    if (__transaction__.Currency_Of_Trade.CurrencyID == Currency.CurrencyID)
                    {
                        if (__transaction__.Reciever == Currency.CurrencyWallet)
                        {
                            Value_Measured -= (__transaction__.Amount / Currency.CurrencyValue.Amount * 100);
                        }
                        else
                        {
                            Value_Measured += (__transaction__.Amount / Currency.CurrencyValue.Amount * 100);
                        }
                    }
                }

                blockchain.infrastructure.storage_medium.Dollar Value_In_Doller = new blockchain.infrastructure.storage_medium.Dollar 
                {
                    Amount = ((Value_Measured + 1) * blockchain.infrastructure.nson.Global_Value_Constant)
                };

                return Value_In_Doller;
            }
        }

        public static bool Add_New(blockchain.infrastructure.storage_medium.Currency New_Currency)
        {
            if (blockchain.infrastructure.db.Currencies_Supported_On_Blockchain.Any(x => x.CurrencyID.Equals(New_Currency.CurrencyID)) == null)
            { 
                blockchain.infrastructure.db.Currencies_Supported_On_Blockchain.Add(New_Currency);
                return true;
            }
            else
            {
                // idk, but it is keep messing around i dnt kneo why!
                return false;
            }
        }
        public static bool Remove(blockchain.infrastructure.storage_medium.Currency Target_Currency)
        {
            if (blockchain.infrastructure.db.Currencies_Supported_On_Blockchain.Any(x => x.CurrencyID.Equals(Target_Currency.CurrencyID)) != null)
            {
                blockchain.infrastructure.db.Currencies_Supported_On_Blockchain.Remove(Target_Currency);
                return true;
            }
            else
            {
                // idk, but it is keep messing around i dnt kneo why!
                return false;
            }
        }
        public class Select
        {
            public static blockchain.infrastructure.storage_medium.Currency FromName(string _name)
            {
                blockchain.infrastructure.storage_medium.Currency Found_Currency = new blockchain.infrastructure.storage_medium.Currency();

                blockchain.infrastructure.storage_medium.Currency _C_list = blockchain.infrastructure.db.Currencies_Supported_On_Blockchain.FirstOrDefault(x => x.CurrencyName.Equals(_name));

                if (_C_list != null)
                {
                    Found_Currency = _C_list;
                }

                return Found_Currency;
            }
            public static blockchain.infrastructure.storage_medium.Currency FromAdminAccountID(string _ID)
            {
                blockchain.infrastructure.storage_medium.Currency Found_Currency = new blockchain.infrastructure.storage_medium.Currency();

                blockchain.infrastructure.storage_medium.Currency _C_list = blockchain.infrastructure.db.Currencies_Supported_On_Blockchain.FirstOrDefault(x => x.CurrencyID.Equals(_ID));

                if (_C_list != null)
                {
                    Found_Currency = _C_list;
                }

                return Found_Currency;
            }
        }
        public class Doller
        {
            public static blockchain.infrastructure.storage_medium.Dollar FromAmount(double _amount)
            {
                blockchain.infrastructure.storage_medium.Dollar InDoller = new blockchain.infrastructure.storage_medium.Dollar
                { 
                    Amount = _amount,
                };

                return InDoller;
            }
        }
    }
    public class accounts
    {
        public class Select
        {
            public static blockchain.infrastructure.storage_medium.UserAccount FromID(string _id)
            {
                blockchain.infrastructure.storage_medium.UserAccount Found_UserAccount = new blockchain.infrastructure.storage_medium.UserAccount();

                blockchain.infrastructure.storage_medium.UserAccount _C_list = blockchain.infrastructure.db.Accounts_On_Blockchain.FirstOrDefault(x => x.UserID.Equals(_id));

                if (_C_list != null)
                {
                    Found_UserAccount = _C_list;
                }

                return Found_UserAccount;
            }
        }
    }
}
