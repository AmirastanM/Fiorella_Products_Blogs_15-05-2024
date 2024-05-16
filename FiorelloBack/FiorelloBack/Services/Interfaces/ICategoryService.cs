using FiorelloBack.Models;

namespace FiorelloBack.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }
}
