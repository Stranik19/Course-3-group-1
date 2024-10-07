public class userService 
{
    private readonly List<User> _users = new(); 

    public void AddUser(User user) => _users.Add(user);

    public void EditUser(User user)
    {
        var existingUser = GetUser(user.UserId);
        if (existingUser != null)
        {
            existingUser.Update(user); 
        }
    }

    public void DeleteUser(int userId)
    {
        var user = GetUser(userId);
        if (user != null)
        {
            _users.Remove(user);
        }
    }

    public User GetUser(int userId) => _users.FirstOrDefault(u => u.UserId == userId);

    public IEnumerable<User> GetUsers() => _users; 
}

