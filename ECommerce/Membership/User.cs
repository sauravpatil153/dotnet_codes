namespace Membership;
public class User
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? ContactNo { get; set; }
    public string? Email { get; set; }
    public string? Location { get; set; }

    public User(string firstName, string lastName, string contactNo, string email, string location)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.ContactNo = contactNo;
        this.Email = email;
        this.Location = location;
    }

}
