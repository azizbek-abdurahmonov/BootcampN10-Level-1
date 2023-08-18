using N26_HT1.Models;
using N26_HT1.Enums;

var money1 = new Money { Amount = 150_000, Type = MoneyType.InBalance, Currency = Currency.UZS};
var money2 = new Money { Amount = 2, Type = MoneyType.Loan, Currency = Currency.USD};

var result = money1 + money2;

Console.WriteLine(result);