using Government;
namespace Bank;
public class Account
{
    public event TaxOperation overbalance;
    public event ManagerOpr underbalance;
    public double Balance { get; set; }

    public Account(double balance)
    {
        this.Balance = balance;
    }

    public void deposit(double amount)
    {
        this.Balance += amount;
    }

    public void withdraw(double amount)
    {
        if((this.Balance-amount)<5000)
            underbalance();
        this.Balance -= amount;
    }

    public override string ToString()
    {
        return "Current Balance =" + this.Balance;
    }

    public void processTax(){
        if(this.Balance >= 250000){
            overbalance();
        }
    }
}