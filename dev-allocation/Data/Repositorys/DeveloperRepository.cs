using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_allocation.Data
{
    internal class DeveloperRepository
    {

        // Save developer in database
        public static void SaveDeveloper(Developer developer)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (developer.Id == 0)
                    {
                        dbContext.Developers.Add(developer);
                    }
                    else
                    {
                        dbContext.Entry(developer).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Select a developer
        public static Developer FindDeveloperByEmail(String email)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers
                        .Include("Credential")
                        .Where(d => d.Credential.Email == email)
                        .FirstOrDefault<Developer>();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
