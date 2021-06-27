using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(DbContext context) : base(context)
        {
        }
        public Tag GetTagByName(string name)
        {          
                return _context.Set<Tag>().SingleOrDefault(t => t.Name == name && !t.Deleted);
   
        }
    }
}

