using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dev_allocation.Data.Repositorys
{
    internal class CredentialRepository
    {
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

        /// Method to authenticate user login
        public static Boolean AuthenticateDeveloper(String email, String password)
        {
            FrmLogin.DevLoggedIn = FindDeveloperByEmail(email);

            /// If email exists in database...
            if (FrmLogin.DevLoggedIn != null)
            {
                /// ... autheticate the password.
                String passwordInDatabase = FrmLogin.DevLoggedIn.Credential.Password;
                password = Credential.ComputeSHA256(password);

                if (passwordInDatabase == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
