using Membership;
public class AuthManager{
    public static bool Validate(string? email, string? password){
        if(email=="sp@gmail.com" && password=="Saurav1998")
            return true;
        return false;
    } 

    public static bool Register(string firstName, string lastName, string contactNo, string email, string location){
        User newUser = new User(firstName, lastName, contactNo, email, location);
        return true;
    }
}