using System.ComponentModel.DataAnnotations.Schema;

namespace RecordStatic_TASK
{
    class User : Account
    {
        private static int _id;
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string email, string password)
        {
            Id = ++_id;  //++id
            Email = email;
            Password = password;
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

        public static bool PasswordChecker(string password)
        {
            bool IsUpperLetter = false;
            bool IsLowerLetter = false;
            bool IsDigit = false;

            if (password.Length < 8)
            {
                return false;
            }
            foreach (char c in password)
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

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Fullname: {FullName} - Email: {Email}");
        }
    }
}
