using Blog.Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Dtos.CategoryDtos
{
    public class CategoryAddDto : IDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
    }
}
