public class Authentication
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public Authentication(string email, string password, string firstName, string lastName)
    {
        this.Email = email;
        this.Password = password;
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}