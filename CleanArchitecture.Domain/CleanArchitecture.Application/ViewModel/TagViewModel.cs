using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModel
{
    public class TagViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int BlogId { get; set; }
        //public List<BlogViewModel> Blog { get; set; }
        public List<int> SelectedBlogs { get; set; }
    }
}
