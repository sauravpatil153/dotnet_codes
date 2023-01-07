namespace HR;
public class SalesManager : SalesEmployee
{

    public float Bonus { get; set; }
    public SalesManager(string employeeId, string firstName, string lastName,
    DateTime dob, string contactNo, string email, string location, float da,
    float hra, float basicSalary, float target, float salesDone, float Bonus) :
    base(employeeId, firstName, lastName, dob, contactNo, email, location, da, hra, basicSalary, target, salesDone)
    {
        this.Bonus = Bonus;
    }

    public override void DoWork()
    {
        base.DoWork();
    }

    public override float ComputeSalary()
    {
        return base.ComputeSalary() + Bonus;
    }

    public override string? ToString()
    {
        return base.ToString() + ", Bonus = " + Bonus;
    }

}