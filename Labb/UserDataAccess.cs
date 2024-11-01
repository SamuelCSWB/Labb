namespace Labb
{
    public class UserDataAccess : IUserDataAccess
    {
        private readonly IEnumerable<User> _users = new List<User>()
        {
            new User(1, "Ken", "ken@bio.io", new Address("Aldervägen 1", "Stockholm", "123"), new Company("Postnord", "We make everyday life easier")),
            new User(2, "Ben", "ben@bio.io", new Address("Björkvägen 2", "Stockholm", "123"), new Company("Postnord", "We make everyday life easier")),
            new User(3, "Jen", "jen@bio.io", new Address("Cederstigen 3", "Stockholm", "123"), new Company("Postnord", "We make everyday life easier")),
            new User(4, "Len", "len@bio.io", new Address("Dovägen 4", "Stockholm", "123"), new Company("Postnord", "We make everyday life easier")),
            new User(5, "Ren", "ren@bio.io", new Address("Ekskogen 5", "Stockholm", "123"), new Company("Postnord", "We make everyday life easier")),
            new User(6, "Fen", "fen@bio.io", new Address("Askervägen 10", "Malmö", "123"), new Company("Postnord", "We make everyday life easier")),
            new User(7, "Gen", "gen@bio.io", new Address("Björkvägen 20", "Malmö", "123"), new Company("Postnord", "We make everyday life easier")),
            new User(8, "Hen", "hen@bio.io", new Address("Cederstigen 30", "Malmö", "123"), new Company("Postnord", "We make everyday life easier")),
            new User(9, "Ien", "ien@bio.io", new Address("Dovägen 40", "Malmö", "123"), new Company("Postnord", "We make everyday life easier")),
            new User(10, "Pen", "pen@bio.io", new Address("Dovägen 230", "Malmö", "123"), new Company("Postnord", "We make everyday life easier"))

        };


        public async Task<IEnumerable<User>> GetUsers()
        {
            await Task.Delay(0);
            return _users;
        }

    }
}
