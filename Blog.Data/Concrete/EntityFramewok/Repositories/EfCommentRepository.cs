using Blog.Common.Data.Concrete.EntityFramework;
using Blog.Data.Abstract;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Concrete.EntityFramewok.Repositories
{
    public class EfCommentRepository : EfEntityRepositoryBase<Comment>,ICommentRepository
    {
        public EfCommentRepository(DbContext context) : base(context)
        {

        }
    }

}
