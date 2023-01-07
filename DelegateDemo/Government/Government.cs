namespace Government;

public delegate void TaxOperation();
public class CentralGov
{
    public void DeductIncomeTax(){
        Console.WriteLine("Inside deductIT");
    }

    public void DeductServiceTax(){
        Console.WriteLine("Inside deductST");
    }

    public void DeductProfessionalTax(){
        Console.WriteLine("Inside deductPT");
    }
}
