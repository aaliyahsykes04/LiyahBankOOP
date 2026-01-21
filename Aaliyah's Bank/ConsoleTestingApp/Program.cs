using System;
using Class_Library;

Console.WriteLine("Console Testing App for Liyahs Bank Library");

//Base Account Test

Account testAcct = new Account();
testAcct.IsActive = true;
Console.WriteLine("Base Account Created:");
Console.WriteLine($"Account Number: {testAcct.AccountNumber}");
Console.WriteLine($"Owner Name: {testAcct.OwnerName}");
Console.WriteLine($"Balance : {testAcct.Balance: C}");
Console.WriteLine($"Is Actvie: {testAcct.IsActive}");
Console.WriteLine($"Date Opened: {testAcct.DateOpened}");

//Base Account Deposit Test
testAcct.Deposit(500);
Console.WriteLine($"After depositing $500, Balance: {testAcct.Balance:C}");

//Base Account Withdraw Test
bool withdrawSuccess = testAcct.Withdraw(200);
Console.WriteLine($"Attempt to withdrae $200: {(withdrawSuccess ? "Success" : "Failed")}, New Balance: {testAcct.Balance:C}");