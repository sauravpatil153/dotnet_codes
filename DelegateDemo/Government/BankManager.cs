namespace Bank;
public delegate void ManagerOpr();
public class BankManager{
    public void SMSAlert(){
        Console.WriteLine("Inside SMSAlert");
    }

    public void EmailAlert(){
        Console.WriteLine("Inside EmailAlert");
    }

    public void BlockAccount(){
        Console.WriteLine("Inside BlockAccount");
    }
}