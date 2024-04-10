using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_KTK.Model
{
    public class User
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Password { get; set; }
        public string RuleId { get; set; }
        public User(int id, string name, string surname, string patronymic, string password, string ruleId)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Password = password;
            RuleId = ruleId;
        }
    }
}
