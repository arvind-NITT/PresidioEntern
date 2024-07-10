# Fixed Deposit (FD) Account Services 
## Overview

A Fixed Deposit (FD) is a financial instrument provided by banks or financial institutions that offers a higher interest rate compared to regular savings accounts, until the given maturity date. This document outlines how to implement FD account services in a .NET banking application.

## Key Characteristics of a Fixed Deposit

1. **Deposit Amount**: The amount of money that the depositor decides to lock in for a specific period.
2. **Interest Rate**: The rate of interest that the bank pays on the deposited amount.
3. **Duration**: The time period for which the money is deposited.
4. **Maturity Date**: The date on which the FD matures.
5. **Withdrawal and Closure**: The depositor can typically withdraw the money only upon maturity. After a withdrawal, the FD account is usually closed.

## How an FD Account Works

1. **Account Creation**: The depositor opens an FD account with a specified deposit amount and chooses the duration of the deposit.
2. **Interest Accrual**: Interest starts accruing from the date of deposit until the maturity date.
3. **Maturity**: On the maturity date, the depositor receives the principal amount along with the accrued interest.
4. **Withdrawal**: If the depositor withdraws the money before the maturity date, a penalty may be applied, and the interest rate might be adjusted. After the withdrawal, the FD account is closed.

## Example Scenario

- **Initial Deposit**: $10,000
- **Interest Rate**: 5% per annum
- **Duration**: 1 year
- **Maturity Amount**: $10,000 (principal) + $500 (interest) = $10,500

If the depositor withdraws the money after 6 months:
- **Accrued Interest**: $10,000 * (5%/2) = $250
- **Penalty**: For example, 1% of the principal or a reduced interest rate.

### FD Account Entity

```csharp
public class FDAccount
{
    public int FDAccountId { get; set; }
    public int AccountId { get; set; }
    public decimal DepositAmount { get; set; }
    public double InterestRate { get; set; }
    public string InterestType { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime MaturityDate { get; set; }
    public string Status { get; set; }// "Active", "Matured", "Closed", "Renewed"
}


+-----------------------+
|       FDAccount       |
+-----------------------+
| - FDAccountId: int    |
| - AccountId: int      |
| - DepositAmount: decimal |
| - InterestRate: double|
| - InterestType: string|
| - StartDate: DateTime |
| - MaturityDate: DateTime |
| - Status: string      |
+-----------------------+

+--------------------------+
|      FDAccountService    |
+--------------------------+
| + CreateFDAccountAsync(accountId: int, depositAmount: decimal, interestRate: double, duration: int): Task<FDAccountResponse> |
| + GetFDAccountDetailsAsync(fdAccountId: int): Task<FDAccountResponse> |
| + WithdrawFromFDAccountAsync(fdAccountId: int): Task<FDAccountResponse> |
| + PreMatureWithdrawFromFDAccount(fdAccountId: int): Task<FDAccountResponse> |
 + RenewFDAccountAsync(fdAccountId: int, newDuration: int): Task<FDAccountResponse> |
+--------------------------+

+--------------------------+
|      IFDAccountService   |
+--------------------------+
| + CreateFDAccountAsync(accountId: int, depositAmount: decimal, interestRate: double, duration: int): Task<FDAccountResponse> |
| + GetFDAccountDetailsAsync(fdAccountId: int): Task<FDAccountResponse> |
| + WithdrawFromFDAccountAsync(fdAccountId: int): Task<FDAccountResponse> |
| + PreMatureWithdrawFromFDAccount(fdAccountId: int): Task<FDAccountResponse> |
 + RenewFDAccountAsync(fdAccountId: int, newDuration: int): Task<FDAccountResponse> |
+--------------------------+

+--------------------------+
|      FDAccountResponse   |
+--------------------------+
| - FDAccountId: int       |
| - DepositAmount: decimal |
| - InterestRate: double   |
| - MaturityDate: DateTime |
| - Status: string         |
| - MaturityAmount: decimal|
+--------------------------+

+--------------------------+
|   CreateFDAccountRequest |
+--------------------------+
| - AccountId: int         |
| - DepositAmount: decimal |
| - InterestRate: double   |
| - Duration: int          |
+--------------------------+

+--------------------------+
|      FDAccountController |
+--------------------------+
| - _fdAccountService: IFDAccountService |
+--------------------------+
| + CreateFDAccount(request: CreateFDAccountRequest): Task<IActionResult> |
| + GetFDAccountDetails(fdAccountId: int): Task<IActionResult> |
| + WithdrawFromFDAccount(fdAccountId: int): Task<IActionResult> |
| + PreMatureWithdrawFromFDAccount(fdAccountId: int): Task<IActionResult> |
+--------------------------+
