namespace Labb
{
    public class UserDataAccess : IUserDataAccess
    {
        private readonly IEnumerable<User> _users = new List<User>()
        {
            new User(1, "Magic Johnson", "magic.johnson@nba.com", new Address("Aldervägen 1", "Gävle", "803 20"), new Company("IKEA", "Creating a better everyday life")),
            new User(2, "Kevin Durant", "kevin.durant@nba.com", new Address("Björkvägen 2", "Stockholm", "114 25"), new Company("Spotify", "Music for everyone")),
            new User(3, "Ben Simmons", "ben.simmons@nba.com", new Address("Cederstigen 3", "Östersund", "831 45"), new Company("Scania", "Driving the shift")),
            new User(4, "Lonzo Ball", "lonzo.ball@nba.com", new Address("Dovägen 4", "Borås", "503 37"), new Company("Ericsson", "Empowering an intelligent, sustainable, and connected world")),
            new User(5, "Jimmy Butler", "jimmy.butler@nba.com", new Address("Ekskogen 5", "Göteborg", "411 27"), new Company("Volvo", "For life")),
            new User(6, "Pelle Larsson", "pelle.larsoon@nba.com", new Address("Askervägen 10", "Malmö", "211 37"), new Company("Skanska", "Building for a better society")),
            new User(7, "Goran Dragic", "goran.dragic@nba.com", new Address("Björkvägen 20", "Sundsvall", "852 34"), new Company("Telia", "Connecting people")),
            new User(8, "Lebron James", "lebron.james@nba.com", new Address("Cederstigen 30", "Nässjö", "571 32"), new Company("H&M", "Fashion and quality at the best price")),
            new User(9, "Allen Iverson", "allen.iverson@nba.com", new Address("Dovägen 40", "Umeå", "903 25"), new Company("Electrolux", "Shape living for the better")),
            new User(10, "Luka Doncic", "luka.doncic@nba.com", new Address("Dovägen 230", "Luleå", "972 41"), new Company("Sandvik", "Advancing the world through engineering"))
        };





        public async Task<IEnumerable<User>> GetUsers()
        {
            await Task.Delay(0);
            return _users;
        }

    }
}
