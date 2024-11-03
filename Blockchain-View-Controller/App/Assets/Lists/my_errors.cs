using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_View_Controller.App.Assets.Lists
{
    public class my_errors
    {
        public static class SystemErrors
        {
            public static readonly Dictionary<string, (string Type, string Message)> Definitions = new()
            {
                ["0x00001"] = ("NotImplementedError", "The requested functionality is not yet implemented"),
                ["0x00002"] = ("ProgramLogicError", "An public program logic error occurred"),
                ["0x00010"] = ("SystemOverloadError", "System is currently experiencing high load"),
                ["0x00011"] = ("MaintenanceModeError", "System is in maintenance mode"),
                ["0x00012"] = ("VersionMismatchError", "Client version is incompatible"),
                ["0x00013"] = ("ConfigurationError", "Invalid system configuration"),
                ["0x00014"] = ("ResourceExhaustionError", "System resources are exhausted"),
                ["0x00015"] = ("TimeoutError", "Operation timed out"),
                ["0x00016"] = ("NetworkError", "Network connectivity issues detected"),
                ["0x00017"] = ("DatabaseError", "Database operation failed"),
                ["0x00018"] = ("CacheError", "Cache operation failed"),
                ["0x00019"] = ("LoggingError", "Failed to write to logs"),
            };
        }

        public static class AccountErrors
        {
            public static readonly Dictionary<string, (string Type, string Message)> Definitions = new()
            {
                ["0x00003"] = ("AccountLoginError", "Failed to authenticate user credentials"),
                ["0x00004"] = ("AccountNotFoundError", "The specified account could not be found"),
                ["0x00005"] = ("AccountAlreadyExistsError", "An account with these credentials already exists"),
                ["0x00020"] = ("AccountLockedError", "Account has been locked due to suspicious activity"),
                ["0x00021"] = ("AccountSuspendedError", "Account has been suspended"),
                ["0x00022"] = ("AccountInactiveError", "Account is inactive"),
                ["0x00023"] = ("PasswordExpiredError", "Password has expired"),
                ["0x00024"] = ("InvalidPasswordError", "Invalid password provided"),
                ["0x00025"] = ("TwoFactorRequiredError", "Two-factor authentication required"),
                ["0x00026"] = ("InvalidTwoFactorCodeError", "Invalid two-factor code"),
                ["0x00027"] = ("AccountLimitExceededError", "Account operation limit exceeded"),
                ["0x00028"] = ("AccountTypeInvalidError", "Invalid account type for operation"),
                ["0x00029"] = ("AccountVerificationRequiredError", "Account requires verification"),
            };
        }

        public static class BalanceErrors
        {
            public static readonly Dictionary<string, (string Type, string Message)> Definitions = new()
            {
                ["0x00006"] = ("InsufficientBalanceError", "Insufficient balance for the requested operation"),
                ["0x00030"] = ("BalanceUpdateError", "Failed to update balance"),
                ["0x00031"] = ("BalanceLockError", "Balance is currently locked"),
                ["0x00032"] = ("BalanceOverflowError", "Balance operation would cause overflow"),
                ["0x00033"] = ("NegativeBalanceError", "Operation would result in negative balance"),
                ["0x00034"] = ("BalanceFrozenError", "Balance is frozen"),
                ["0x00035"] = ("BalanceReconciliationError", "Balance reconciliation failed"),
                ["0x00036"] = ("BalanceThresholdError", "Balance threshold exceeded"),
                ["0x00037"] = ("BalanceTypeError", "Invalid balance type"),
                ["0x00038"] = ("BalanceConversionError", "Balance conversion failed"),
            };
        }

        public static class CurrencyErrors
        {
            public static readonly Dictionary<string, (string Type, string Message)> Definitions = new()
            {
                ["0x00007"] = ("CurrencyNotFoundError", "The specified currency could not be found"),
                ["0x00008"] = ("CurrencyAlreadyExistsError", "The specified currency already exists"),
                ["0x00009"] = ("CurrencyAdminLoginError", "Failed to authenticate currency administrator"),
                ["0x00040"] = ("CurrencyInactiveError", "Currency is currently inactive"),
                ["0x00041"] = ("CurrencyRateError", "Failed to fetch currency exchange rate"),
                ["0x00042"] = ("CurrencyPairInvalidError", "Invalid currency pair"),
                ["0x00043"] = ("CurrencyPrecisionError", "Currency precision mismatch"),
                ["0x00044"] = ("CurrencyLimitError", "Currency operation limit exceeded"),
                ["0x00045"] = ("CurrencyConversionError", "Currency conversion failed"),
                ["0x00046"] = ("CurrencyValidationError", "Currency validation failed"),
            };
        }

        public static class TransactionErrors
        {
            public static readonly Dictionary<string, (string Type, string Message)> Definitions = new()
            {
                ["0x00050"] = ("TransactionFailedError", "Transaction processing failed"),
                ["0x00051"] = ("TransactionTimeoutError", "Transaction timed out"),
                ["0x00052"] = ("TransactionValidationError", "Transaction validation failed"),
                ["0x00053"] = ("TransactionLimitError", "Transaction limit exceeded"),
                ["0x00054"] = ("TransactionDuplicateError", "Duplicate transaction detected"),
                ["0x00055"] = ("TransactionRollbackError", "Transaction rollback failed"),
                ["0x00056"] = ("TransactionStateError", "Invalid transaction state"),
                ["0x00057"] = ("TransactionSignatureError", "Invalid transaction signature"),
                ["0x00058"] = ("TransactionBlockedError", "Transaction blocked by policy"),
                ["0x00059"] = ("TransactionExpiredError", "Transaction has expired"),
            };
        }

        public static class BlockchainErrors
        {
            public static readonly Dictionary<string, (string Type, string Message)> Definitions = new()
            {
                ["0x00060"] = ("BlockValidationError", "Block validation failed"),
                ["0x00061"] = ("BlockHashError", "Invalid block hash"),
                ["0x00062"] = ("BlockHeightError", "Invalid block height"),
                ["0x00063"] = ("BlockchainSyncError", "Blockchain synchronization failed"),
                ["0x00064"] = ("ConsensusError", "Consensus validation failed"),
                ["0x00065"] = ("OrphanBlockError", "Orphan block detected"),
                ["0x00066"] = ("ForkDetectedError", "Blockchain fork detected"),
                ["0x00067"] = ("BlockSizeError", "Block size exceeds limit"),
                ["0x00068"] = ("BlockTimeError", "Invalid block timestamp"),
                ["0x00069"] = ("BlockRewardError", "Invalid block reward"),
            };
        }

        public static class SmartContractErrors
        {
            public static readonly Dictionary<string, (string Type, string Message)> Definitions = new()
            {
                ["0x00070"] = ("ContractDeployError", "Contract deployment failed"),
                ["0x00071"] = ("ContractExecutionError", "Contract execution failed"),
                ["0x00072"] = ("ContractValidationError", "Contract validation failed"),
                ["0x00073"] = ("ContractGasError", "Insufficient gas for contract operation"),
                ["0x00074"] = ("ContractStateError", "Invalid contract state"),
                ["0x00075"] = ("ContractUpgradeError", "Contract upgrade failed"),
                ["0x00076"] = ("ContractPermissionError", "Insufficient contract permissions"),
                ["0x00077"] = ("ContractParamError", "Invalid contract parameters"),
                ["0x00078"] = ("ContractEventError", "Contract event processing failed"),
                ["0x00079"] = ("ContractTimeoutError", "Contract execution timed out"),
            };
        }

        public static class NetworkErrors
        {
            public static readonly Dictionary<string, (string Type, string Message)> Definitions = new()
            {
                ["0x00080"] = ("PeerConnectionError", "Failed to connect to peer"),
                ["0x00081"] = ("NetworkLatencyError", "Network latency too high"),
                ["0x00082"] = ("NetworkBandwidthError", "Insufficient network bandwidth"),
                ["0x00083"] = ("NetworkProtocolError", "Network protocol violation"),
                ["0x00084"] = ("NetworkVersionError", "Incompatible network version"),
                ["0x00085"] = ("NetworkSecurityError", "Network security violation"),
                ["0x00086"] = ("NetworkRoutingError", "Network routing failed"),
                ["0x00087"] = ("NetworkNodeError", "Network node failure"),
                ["0x00088"] = ("NetworkSyncError", "Network synchronization failed"),
                ["0x00089"] = ("NetworkTimeoutError", "Network operation timed out"),
            };
        }

        public static class ValidationErrors
        {
            public static readonly Dictionary<string, (string Type, string Message)> Definitions = new()
            {
                ["0x00090"] = ("InputValidationError", "Invalid input data"),
                ["0x00091"] = ("FormatValidationError", "Invalid data format"),
                ["0x00092"] = ("SchemaValidationError", "Data schema validation failed"),
                ["0x00093"] = ("SignatureValidationError", "Digital signature validation failed"),
                ["0x00094"] = ("TimestampValidationError", "Invalid timestamp"),
                ["0x00095"] = ("AddressValidationError", "Invalid blockchain address"),
                ["0x00096"] = ("PermissionValidationError", "Permission validation failed"),
                ["0x00097"] = ("QuotaValidationError", "Quota validation failed"),
                ["0x00098"] = ("RateValidationError", "Rate limit validation failed"),
                ["0x00099"] = ("ComplianceValidationError", "Compliance validation failed"),
            };
        }

        public static class SecurityErrors
        {
            public static readonly Dictionary<string, (string Type, string Message)> Definitions = new()
            {
                ["0x00100"] = ("AuthorizationError", "Authorization failed"),
                ["0x00101"] = ("AuthenticationError", "Authentication failed"),
                ["0x00102"] = ("TokenExpiredError", "Security token expired"),
                ["0x00103"] = ("AccessDeniedError", "Access denied to resource"),
                ["0x00104"] = ("RateLimitError", "Rate limit exceeded"),
                ["0x00105"] = ("FirewallError", "Blocked by firewall"),
                ["0x00106"] = ("EncryptionError", "Encryption operation failed"),
                ["0x00107"] = ("DecryptionError", "Decryption operation failed"),
                ["0x00108"] = ("CertificateError", "Invalid certificate"),
                ["0x00109"] = ("KeyManagementError", "Key management operation failed"),
            };
        }
    }
}
