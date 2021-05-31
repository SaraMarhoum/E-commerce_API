using jwtAPIauth.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.IntelviaData
{
    public interface ICategoryData
    {
        int Count();
       
        Category FetchById(int id);
        void Create(Category cat);
        Task Update(Category cat);
        Task Delete(int id);

        Task<Category> GetById(int id);

        Task<Tuple<int, List<Category>>> FetchPageWithImages(int page, int pageSize);

        Task<Category> Create(string name, string description, List<IFormFile> files,
            long? userId = null);

        Task<Tuple<int, List<Category>>> FetchPage(int page, int pageSize);

    }
}
