using blog_template_practice.Repositories;
using blog_template_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Repositories
{
    public class CommentRepository : Repository<Comment>, IRepository<Comment>
    {
        public CommentRepository(BlogContext db) : base(db)
        {

        }
    }
}
