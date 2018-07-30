using System.Linq;
using EFCoreDemos.EFCSharp.Entities;
using static System.Console;

namespace DbCoreDemos.EFCSharpMySql
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var dbContext = new SugarcrmContext())
            {
                var accounts = dbContext.Accounts
                                .Where(x => x.Deleted == 0)
                                .Select(x => new
                                {
                                    // I had to create an anonymous object for this demo
                                    // becasue EF core with MySql fails with Guids.
                                    Name = x.Name,
                                    PhoneOffice = x.PhoneOffice
                                })
                                .ToList();

                // Print all the active accounts.
                foreach(var account in accounts)
                {
                    WriteLine($"{account.Name}\t{account.PhoneOffice}");
                }
            }

            ReadLine();
        }
    }
}
