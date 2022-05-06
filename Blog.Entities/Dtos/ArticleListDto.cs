using Blog.Common.Entities.Abstract;
using Blog.Entities.Concrete;
using System.Collections.Generic;

namespace Blog.Entities.Dtos
{
    public class ArticleListDto : DtoGetBase
    {
        public IList<Article> Articles { get; set; }

    }
}
