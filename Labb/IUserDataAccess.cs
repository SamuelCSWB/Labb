namespace Labb
{
    public interface IUserDataAccess
    {
        Task<IEnumerable<User>> GetUsers();

    }
}
