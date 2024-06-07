using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCourseWork.Programs
{
    public class Librarian
    {
        public string Username { get; set; }
        public string Password { get; set; }

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
