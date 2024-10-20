namespace Labb
{

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public Company Company { get; set; }

        public User()
        {

        }
        public User(int id, string name, string email, Address address, Company company)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
            Company = company;
        }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }

        public Address(string street, string city, int zip)
        {
            Street = street;
            City = city;
            Zip = zip;
        }
    }

    public class Company
    {
        public string Name { get; set; }
        public string CatchPhrase { get; set; }

        public Company(string name, string catchPhrase)
        {
            Name = name;
            CatchPhrase = catchPhrase;
        }
    }
    

}

