

// Doubles stores 4.12, 1.234, 32
// Decimal stores 4.12, 1.234, 32
// Decimal stores to a rounding point of 28 places approximately
// Cost Benefit analysis  = more precise variables take more memory
// Decimals used for Financial coding and Astronomical Units (Nasa)

decimal bankAccountsBalance;

bankAccountsBalance= 2.34M; //This value has been technically rounded so it causes an exception is its not, so have to add the M at end.
//typically used for constants

// Add, Subtract, Multiply typically don't return decimals they return whole numbers
Console.WriteLine(bankAccountsBalance);
bankAccountsBalance = (2.123456787654676545676545654456M *100.3432423235M) /30.5M;
Console.WriteLine(bankAccountsBalance);


// See decimals = double by default
// See money = do decimals




