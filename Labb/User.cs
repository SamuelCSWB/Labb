namespace Labb
{

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Address Address { get; set; }
        public Company Company { get; set; }

        public User()
        {
            Address = new Address();
            Company = new Company();
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
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;

        public Address()
        {
        
        }
        public Address(string street, string city, string zipcode)
        {
            Street = street;
            City = city;
            Zipcode = zipcode;
        }
    }

    public class Company
    {
        public string Name { get; set; } = string.Empty;
        public string CatchPhrase { get; set; } = string.Empty;

        public Company()
        {
        
        }
        public Company(string name, string catchPhrase)
        {
            Name = name;
            CatchPhrase = catchPhrase;
        }
    }
    

}

