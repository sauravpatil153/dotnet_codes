public class Authentication{
    public string? Email{get; set;}
    public string? Password{get; set;}
    public Authentication(string email, string password){
        this.Email=email;
        this.Password=password;
    }
}