namespace BoardGameScorer.Application.Services.Kingdomino;
public class UserService : IUserService
{
    //TODO: Remove hardcoded strings
    public int Id { get; set; } = 1;
    public string Name { get; set; } = "anna@test.com";
    public User GetById(int id)
    {
        var testUser = new User
        {
            Id = id,
        };
        return testUser;
    }
}
