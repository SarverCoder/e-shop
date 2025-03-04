using e_shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.DataAccess.Services
{
    public class CategoryService
    {
        private readonly ShopContext _context;

        public CategoryService(ShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories;
        }

        public async Task<Category> GetByIdCategory(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
        }
        public int SaveChanges() => _context.SaveChanges();

    }
}
