using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class classUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Userstatus { get; set; }

        //insert constructor
        public classUser(string name, string surname, string title, string role, string email, string password, string userstatus)
        {
            this.Name = name;
            this.Surname = surname;
            this.Title = title;
            this.Role = role;
            this.Email = email;
            this.Password = password;
            this.Userstatus = userstatus;
        }

        //select constructor
        public classUser(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        //Select
        public classUser()
        {

        }

        // select User by Surname
        public classUser(string surname)
        {
            this.Surname = surname;
        }
    }
}
