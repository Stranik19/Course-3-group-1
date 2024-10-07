public class user
{
    public int userId {get; set;}
    public string userName {get; set;}
    public string userEmail {get; set;}
    public int pasword {get; set;}

    public void Update(User otherUser)
    {
        userId = otherUser.UserId;
        username = otherUser.Username;
        userEmail = otherUser.userEmail;
        pasword = otherUser.Pasword; 
    }
}

