# Blockchain View Controller Framework

A custom-built framework for building and managing blockchain applications in C#! This framework streamlines the development of blockchain-related functionalities, providing a robust infrastructure for managing accounts, currencies, and transactions.


> ## **Author: hmZa-Sfyn**
> ## ***Github: [hmZa](https://github.com/hmZa-Sfyn)***

## Motivation

The motivation behind creating the Blockchain View Controller Framework stems from the growing demand for efficient and scalable blockchain solutions. Traditional methods of blockchain application development can be cumbersome, requiring developers to build everything from scratch. This framework simplifies the process, allowing developers to focus on the core logic of their applications while leveraging pre-built components for account management, currency handling, and transaction processing.

## Idea and Development Process

The idea for this framework emerged from observing the complexities faced by developers in managing blockchain data. The development process involved:

1. **Research**: Understanding existing blockchain architectures and identifying common pain points in application development.
2. **Design**: Creating a modular architecture that allows for easy integration of new features and scalability.
3. **Implementation**: Building core functionalities such as account management, currency creation, and transaction processing.
4. **Testing**: Conducting rigorous testing to ensure reliability and performance across various scenarios.

# Why I Choose C#

C# is a versatile and powerful programming language that offers numerous advantages, making it an ideal choice for various types of software development. Here are a few reasons why I choose C#:

1. **Strongly Typed Language**: C# enforces type safety, which helps to catch errors at compile-time rather than runtime, enhancing reliability.

2. **Rich Library Support**: The .NET framework provides a vast collection of libraries and frameworks, facilitating rapid application development and reducing the need to reinvent the wheel.

3. **Cross-Platform Capabilities**: With .NET Core, C# applications can run on multiple platforms (Windows, Linux, macOS), providing flexibility in deployment.

4. **Modern Features**: C# supports modern programming paradigms, including asynchronous programming, LINQ, and advanced data types, which simplify complex tasks.

5. **Strong Community and Support**: The C# community is active and supportive, with a wealth of resources, tutorials, and forums available for developers.

6. **Integration with Microsoft Technologies**: C# integrates seamlessly with Microsoft products and services, making it the go-to language for Windows applications, Azure services, and more.

7. **Robust Development Tools**: Visual Studio, the primary IDE for C#, offers powerful features like IntelliSense, debugging tools, and integrated version control, enhancing developer productivity.


## Features

- **Account Management**: Easily add, remove, and manage user accounts on the blockchain.
- **Currency Handling**: Create and manage multiple currencies, supporting various value metrics.
- **Transaction Processing**: Streamlined handling of transactions between accounts with clear logging and error management.
- **Security**: Implement robust security measures for account access and transaction validation.

## Examples

### Adding a User Account

```csharp
blockchain.infrastructure.db.Accounts_On_Blockchain.Add(
    new blockchain.infrastructure.storage_medium.UserAccount
    {
        UserID = $"0xf001",
        UserName = $"MATRIX",
        Password = $"PASSWORD"
    }
);
```

### Creating a Currency

```csharp
blockchain.infrastructure.db.Currencies_Supported_On_Blockchain.Add(
    new blockchain.infrastructure.storage_medium.Currency
    {
        CurrencyCode = "Ox0000000001",
        CurrencyName = "HAMZA-COIN",
        CurrencyID = "0x0001",
        CurrencyValue = new blockchain.infrastructure.storage_medium.Dollar
        { 
            Amount = 1000
        },
        CurrencyWallet = new blockchain.infrastructure.storage_medium.UserAccount 
        {
            UserID = "0x0001",
            UserName = "HAMZA-COIN-ADMIN",
            Password = "PASSWORD"
        }
    }
);
```

### Listing Accounts

```csharp
@out.p_info("Total Accounts:");
foreach (blockchain.infrastructure.storage_medium.UserAccount __account__ in blockchain.infrastructure.db.Accounts_On_Blockchain)
{
    @out.p_info($"{__account__.UserID,-6} | {__account__.UserName,-7} | {__account__.Password,-7}");
}
```

## A complete **Test** Class 
> # **You can view it [here](./Blockchain-View-Controller/App/.tests/zzo.cs)**

# **Important-Points-Of-The-Test-Class**
# Test Suite Overview

This document highlights the important points of each test in the `Blockchain_View_Controller.App.tests` namespace.

## zzo Class - RunTests Method

### 1. Matrix Account Adding
- **Purpose**: Adding a new user account to the blockchain.
- **Details**: 
  - A user with `UserID` `0xf001`, `UserName` `MATRIX`, and a placeholder password is created and added to the accounts database.
  
### 2. Currency Support
- **Purpose**: Add a new currency to the blockchain.
- **Details**: 
  - Currency `HAMZA-COIN` with various attributes is defined and added.
  - Includes properties like `CurrencyCode`, `CurrencyName`, and an associated `UserAccount` with admin privileges.

### 3. User Account Listing
- **Purpose**: Display all user accounts in the blockchain.
- **Details**: 
  - A loop is utilized to add multiple user accounts (20 in total) to the blockchain.
  - Each account has a unique `UserID`, `UserName`, and `Password`.

### 4. Transaction Addition
- **Purpose**: Add transactions between user accounts.
- **Details**: 
  - Transactions are created between the admin account and other users.
  - The transaction amount is calculated based on a formula to ensure diversity.

### 5. Total Balances Calculation
- **Purpose**: Calculate and display the total balances for each user account.
- **Details**: 
  - Displays the balance associated with each user account based on their transactions.

### 6. Final Information
- **Output**: 
  - Outputs the height of the blockchain chain, showing the current status of the blockchain.

## zz2 Class - RunTests Method

### 1. Framework Version Tests
- **Purpose**: Placeholder for running various framework tests.
- **Details**: 
  - Contains commented code to run application tests and handle errors.

## zz3 Class - RunTests Method

### 1. Encryption and Decryption
- **Purpose**: Test encryption and decryption functionalities.
- **Details**: 
  - A simple message is encrypted and then decrypted using a specified password.
  - Validates that the decrypted message matches the original input.

## zz4 Class - RunTests Method

### 1. Error Display
- **Purpose**: List all registered errors in the application.
- **Details**: 
  - Iterates through various error categories to display error codes, types, and messages.
  - Ensures clarity on issues that may arise during application usage.

---
This document summarizes the key functionalities and purposes of the tests within the `Blockchain_View_Controller` application, aiding developers in understanding the testing framework.
