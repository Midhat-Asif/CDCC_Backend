using CDCC_Backend.Models;

namespace CDCC_Backend.Data;

public static class SeedDataHelper
{
    public static void SeedData(ApplicationDbContext context)
    {
        if (!context.Users.Any())
        {
            var users = new List<User>
            {
                new()
                {
                    UserName = "user1",
                    FirstName = "John",
                    LastName = "Doe",
                    Password = "password",
                    Email = "john@example.com"
                },
                new()
                {
                    UserName = "user2",
                    FirstName = "Jane",
                    LastName = "Smith",
                    Password = "password",
                    Email = "jane@example.com"
                }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }

        if (!context.Addresses.Any())
        {
            var addresses = new List<Address>
            {
                new()
                {
                    User = context.Users.First(u => u.UserName == "user1"),
                    Street = "123 Main St",
                    City = "City1",
                    StateCode = "ST",
                    PostalCode = "12345",
                    CountryCode = "US"
                },
                new()
                {
                    User = context.Users.First(u => u.UserName == "user2"),
                    Street = "456 Elm St",
                    City = "City2",
                    StateCode = "ST",
                    PostalCode = "67890",
                    CountryCode = "US"
                }
            };

            context.Addresses.AddRange(addresses);
            context.SaveChanges();
        }
    }
}
