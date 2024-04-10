using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_KTK.Model
{
    public class Role
    {
        public int Id { get; }
        public string _Role { get; set; }
        public Role(string role) 
        {
            _Role = role;
        }
    }
}
