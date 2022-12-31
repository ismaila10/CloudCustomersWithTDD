using CloudCustomersAPIWithTDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomersTest.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new (){
                    Id = 1,
                    Name = "iso",
                    Email = "ish@gmail.com",
                    Address= new Address()
                    {
                        City = "Paris",
                        Street = "17",
                        ZipCode = "75017"
                    }
                },
                new (){
                    Id = 2,
                    Name = "awa",
                    Email = "awa@gmail.com",
                    Address= new Address()
                    {
                        City = "Paris",
                        Street = "13",
                        ZipCode = "75013"
                    }
                },
                new (){
                    Id = 3,
                    Name = "marieme",
                    Email = "marieme@gmail.com",
                    Address= new Address()
                    {
                        City = "Paris",
                        Street = "12",
                        ZipCode = "75012"
                    }
                }
            };
    }
}
