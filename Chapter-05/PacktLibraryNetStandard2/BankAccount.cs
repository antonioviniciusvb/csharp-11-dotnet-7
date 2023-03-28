namespace PacktShare;
public class BankAccount
{
    public string? AccountName { get; set; } //instance member
    public decimal Balance { get; set; } // instance member
    public static decimal InterestRate { get; set; } //shared member
}
