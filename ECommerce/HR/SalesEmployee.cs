namespace HR;
public class SalesEmployee : Employee
{
    public float Target { get; set; }
    public float SalesDone { get; set; }
    public float Incentive { get; set; }
    public SalesEmployee(string employeeId, string firstName, string lastName, DateTime dob, string contactNo, string email,
                    string location, float da, float hra, float basicSalary,
                    float target, float salesDone) : base(employeeId, firstName, lastName, dob, contactNo, email,
                    location, da, hra, basicSalary)
    {
        this.Target = target;
        this.SalesDone = salesDone;
        this.Incentive = 0;
    }
    public override void DoWork()
    {
        if (SalesDone >= Target)
        {
            this.Incentive = 10000;
        }
    }
    public override float ComputeSalary()
    {
        return base.ComputeSalary() + Incentive;
    }

    public override string? ToString()
    {
        return base.ToString()+"Incentive =" +Incentive + ", Target="+ Target;
    }
}