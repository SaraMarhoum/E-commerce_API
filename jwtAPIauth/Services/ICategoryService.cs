using jwtAPIauth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Services
{
    public interface ICategoryService
    {
        Task<Category> Create(Category cat);
        Task Update(Category cat);
        Task Delete(int id);
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(int id);
    }
}
