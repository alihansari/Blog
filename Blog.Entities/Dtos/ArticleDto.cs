using Blog.Common.Entities.Abstract;
using Blog.Common.Utilities.Results.ComplexTypes;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Dtos
{
    public class ArticleDto : DtoGetBase
    {
        public Article Article { get; set; }

    }
}
