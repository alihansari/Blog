using Blog.Dto.Interfaces;

namespace Blog.Dto.CategoryDtos
{
    public class CategoryAddDto : IDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
    }
}
