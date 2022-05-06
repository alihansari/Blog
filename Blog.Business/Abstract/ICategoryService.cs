using Blog.Common.Utilities.Results.Abstract;
using Blog.Entities.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Business.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<Category>> Get(int categoryId);
        Task<IDataResult<IList<Category>>> GetAll();
        Task<IDataResult<IList<Category>>> GetAllByNonDeleted();

        Task<IResult> Add(CategoryAddDto categoryAddDto,string createdByName);
        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto,string modifiedByName);

        Task<IResult> Delete(int categoryId,string modifiedByName);
        Task<IResult> HardDelete(int categoryId);

    }
}
