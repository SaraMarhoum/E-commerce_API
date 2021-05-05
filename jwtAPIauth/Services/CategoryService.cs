using jwtAPIauth.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Category> Create(Category cat)
        {
            _context.Categories.Add(cat);
            await _context.SaveChangesAsync();

            return cat;
        }

        public async Task Delete(int id)
        {
            var catToDelete = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(catToDelete);
            await _context.SaveChangesAsync();
        }


        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task Update(Category cat)
        {
            _context.Entry(cat).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

    }
}
