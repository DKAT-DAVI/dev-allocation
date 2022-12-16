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
        

        /// Method to authenticate user login
        public static Developer AuthenticateDeveloper(String email, String password)
        {
            try
            {
                Developer developer;

                using (Repository dbContext = new Repository())
                {
                    developer = DeveloperRepository.FindDeveloperByEmail(email);
                }

                /// If email exists in database...
                if (developer != null)
                {
                    
                    if (!developer.Credential.Active)
                    {
                        throw new Exception("Unactive user, wait for an administrator to activate it");
                    }
                    else
                    {
                        /// ... autheticate the password.
                        String passwordInDatabase = developer.Credential.Password;
                        password = Credential.ComputeSHA256(password);

                        if (passwordInDatabase == password)
                        {
                            FrmLogin.DevLoggedIn = developer;
                            return developer;
                        }
                        else
                        {
                            throw new Exception("The password you entered is wrong, please try again!");
                        }
                    }
                }
                else
                {
                    throw new Exception("The email you entered is wrong, please try again!");
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

    }
}
