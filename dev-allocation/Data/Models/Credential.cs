using dev_allocation.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dev_allocation
{
    [Table("tbl_credential")]
    internal class Credential
    {
        // Primary Key
        public Int64 Id { get; set; }

        [Index(IsUnique = true)]
        [StringLength(250)]
        public String Email { get; set; }

        //-- Password encrypted
        /// String to salt password.
        public const String SALT = "RtgrMcbelsHerj";

        private String _password;

        [Required]
        [StringLength(64)]
        public String Password
        {
            get 
            { 
                return _password; 
            }
            set
            {
                if (value.Length == 64)
                {
                    _password = value;
                }
                else if (value.Length >= 8 || value.Length <= 12)
                {
                    _password = ComputeSHA256(value);
                }
                else
                {
                    throw new ArgumentException("Invalid Password!");
                }
            }
        }
        //--//

        // Is the user active?
        public Boolean Active { get; set; }

        // Is the user admin?
        public Boolean  Administrator { get; set; }

        // Atribut for ralation one-to-one with tbl_developer [FOREIGN KEY]
        [Required]
        public Developer Developer { get; set; }

        //-- Constructor()
        public Credential() { }
        public Credential(String email, String password, Boolean active, Boolean administrator)
        {
            Email = email;
            Password = password;
            Active = active;
            Administrator = administrator;
        }
        //--//

        #region Hashing
        public static String ComputeSHA256(String input)
        {
            String hash = String.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(SALT + input));

                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }
        #endregion

        /// Method to authenticate user login
        public static Boolean AuthenticateDeveloper(String email, String password)
        {
            Developer developer = DeveloperRepository.FindDeveloperByEmail(email);

            /// If email exists in database...
            if (developer != null)
            {
                /// ... autheticate the password.
                String passwordInDatabase = developer.Credential.Password;
                password = ComputeSHA256(password);

                if (passwordInDatabase == password)
                {
                    return true;
                }
                else
                {
                    /// Return a error Message to the user
                    MessageBox.Show("The password you entered is wrong, please try again", "PASSWORD WRONG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                /// Return a error Message to the user
                MessageBox.Show("The email you entered is wrong, please try again", "EMAIL WRONG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

    }
}

