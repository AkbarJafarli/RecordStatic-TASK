using System.ComponentModel.DataAnnotations.Schema;

namespace RecordStatic_TASK
{
    class User
    {
        private static int _id;
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string fullName, string email, string password)
        {
            Id = _id++;
            FullName = fullName;
            Email = email;
            Password = password;
        }

        public bool PasswordChecker()
        {
            bool IsUpperLetter = false;
            bool IsLowerLetter = false;
            bool IsDigit = false;

            if (Password.Length < 8)
            {
                return false;
            }
            foreach (char c in Password)
            {
                if (char.IsUpper(c))
                {
                    IsUpperLetter = true;
                }
                if (char.IsLower(c))
                {
                    IsLowerLetter = true;
                }
                if (char.IsDigit(c))
                {
                    IsDigit = true;
                }
            }
            return IsUpperLetter && IsLowerLetter && IsDigit;

        }

        public void GetInfo()
        {
            Console.WriteLine($"Id: {Id} - Fullname: {FullName} - Email: {Email}");
        }

        public static User FindUserById(int id, User[] users)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }












    }
}
