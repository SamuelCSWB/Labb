namespace Labb
{
    public class UserDataAccess
    {
        private List<User> _users = new List<User>()
        {
            new User(1, "Ken", "ken@bio.io", new Address("Aldervägen 1", "Stockholm", 123), new Company("Postnord", "We make everyday life easier")),
            new User(2, "Ben", "ben@bio.io", new Address("Björkvägen 2", "Stockholm", 123), new Company("Postnord", "We make everyday life easier")),
            new User(3, "Jen", "jen@bio.io", new Address("Cederstigen 3", "Stockholm", 123), new Company("Postnord", "We make everyday life easier")),
            new User(4, "Len", "len@bio.io", new Address("Dovägen 4", "Stockholm", 123), new Company("Postnord", "We make everyday life easier")),
            new User(5, "Ren", "ren@bio.io", new Address("Ekskogen 5", "Stockholm", 123), new Company("Postnord", "We make everyday life easier")),

        };

        public List<User> GetUsers()
        {
            return _users;
        }

    }
}
