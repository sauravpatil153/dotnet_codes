namespace HR;
public abstract class Employee
{
    public string? EmployeeId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DOB { get; set; }
    public string? ContactNo { get; set; }
    public string? Email { get; set; }
    public string? Location { get; set; }
    public float DA { get; set; }
    public float HRA { get; set; }
    public float BasicSalary { get; set; }
    public Employee() : this("5", "Saurav", "Patil",new DateTime(1998,9,5), "8881212", "sp@gmail.com", "Mumbai", 10000, 100000, 500000)
    {
        Console.WriteLine("Inside P'less Employee Ctor");
    }

    public Employee(string employeeId, string firstName, string lastName, DateTime dob, string contactNo, string email,
                    string location, float da, float hra, float basicSalary)
    {
        this.EmployeeId = employeeId;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.DOB = dob;
        this.ContactNo = contactNo;
        this.Email = email;
        this.Location = location;
        this.DA = da;
        this.HRA = hra;
        this.BasicSalary = basicSalary;
        Console.WriteLine("Inside P'rized Employee Ctor");
    }

    public abstract void DoWork();

    public virtual float ComputeSalary()
    {
        return (DA * 25) + HRA + BasicSalary;
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
