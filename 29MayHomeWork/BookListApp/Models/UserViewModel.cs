using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListApp.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
