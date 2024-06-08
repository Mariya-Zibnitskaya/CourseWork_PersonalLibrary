using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCourseWork.Programs
{
    public class Librarian
    {
        private string username;
        private string password;
        public string Username
        {
            get => username;
            set
            {
                if (value.Length < 8 || value.Length > 32)
                    throw new ArgumentException("Ім'я користувача має бути більше 8 символів та менше 32");
                username = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value.Length < 8 || value.Length > 32)
                    throw new ArgumentException("Пароль має бути більше 8 символів та менше 16");
                password = value;
            }
        }

        public Librarian(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool Authenticate(string username, string password)
        {
            return Username == username && Password == password;
        }
    }
}
