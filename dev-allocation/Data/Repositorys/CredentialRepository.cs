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
                    /// If user isn't active... 
                    if (!developer.Credential.Active)
                    {
                        /// ... return a error message
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
                            // Error message
                            throw new Exception("The password you entered is wrong, please try again!");
                        }
                    }
                }
                else
                {
                    // Error message
                    throw new Exception("The email you entered is wrong, please try again!");
                }
            }
            catch (Exception error)
            {
                // Error message
                throw new Exception(error.Message);
            }
        }

        /// Method to validate a new email
        public static Boolean EmailIsValid(String email)
        {
            List<Developer> Developers = DeveloperRepository.FindAllDevelopers();
            Boolean EmailIsValid = false;

            foreach (Developer developer in Developers)
            {
                /// If already exists email in database
                if (email == developer.Credential.Email)
                {
                    /// email is not valid 
                    throw new Exception("This emails already is registered");
                    return false;
                }

                /// if not exists
                else
                {
                    /// email is valid
                    EmailIsValid = true;
                }
            }

            return EmailIsValid;
            
        }

    }
}
